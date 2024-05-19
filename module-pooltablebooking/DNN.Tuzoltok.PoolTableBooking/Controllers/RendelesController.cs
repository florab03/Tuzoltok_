using Dnn.PoolTableBookingDNN.Tuzoltok.PoolTableBooking.Models;
using DotNetNuke.Data;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Dnn.PoolTableBookingDNN.Tuzoltok.PoolTableBooking.Controllers
{
    public class RendelesController : DnnController
    {
        // GET: Rendeles
        public Rendeles FindRendelesByID(int rendelesid)
        {
            using (var ctx = DataContext.Instance())
            {
                var r = ctx.GetRepository<Rendeles>();
                return r.GetById(rendelesid);
            }
        }

        public Asztal FindAsztalByName(string nev)
        {
            using (var ctx = DataContext.Instance())
            {
                var asztalRepo = ctx.GetRepository<Asztal>();
                return asztalRepo.Get().Where(a => a.Name==nev).First();
            }
        }

        public Vasarlo FindVasarlo(string kersztNev, string vezetekNev, string telefon, string email)
        {
            using (var ctx = DataContext.Instance())
            {
                var vasarloRepo = ctx.GetRepository<Vasarlo>();
                var result = vasarloRepo.Get().Where(v => (
                v.KeresztNev==kersztNev &&
                v.VezetekNev==vezetekNev &&
                v.Email==email &&
                v.Telefonszam==telefon
                )
                );
                if (result.Count() == 0)
                    return null;
                return result.First();
            }
        }

        public int GetVasarloCount()
        {
            using (var ctx = DataContext.Instance())
            {
                var vasarloRepo = ctx.GetRepository<Vasarlo>();
                return vasarloRepo.Get().Count();
            }
        }


        //asztal nevek kiíratása
        public IEnumerable<string> GetTableNames()
        {
            using (var ctx = DataContext.Instance())
            {
                var r = ctx.GetRepository<Asztal>();
                return r.Get().Select(x => x.Name);
            }
        }

        public IEnumerable<string> GetBookableTime()
        {
            for (int i = 13; i <= 22; i++)
                yield return $"{i}:00";
        }

        [HttpPost]
        public ActionResult AddBooking(FormCollection form)
        {
            try
            {
                string kersztNev = form["firstname"];
                string vezetekNev = form["lastname"];
                string telefon = form["phone"];
                string email = form["email"];
                string tableName = form["tableName"];
                int[] time = Array.ConvertAll(form["bookingTime"].Split(':'), Int32.Parse);
                int[] date = Array.ConvertAll(form["date"].Split('.'), Int32.Parse);
                DateTime dateTime = new DateTime(date[0], date[1], date[2], time[0], time[1], 0);

                //string recurrence = form["Recurrence"];
                Asztal asztal = FindAsztalByName(tableName);
                Vasarlo vasarlo = FindVasarlo(kersztNev, vezetekNev, telefon, email);
                if (vasarlo == null)
                    vasarlo = new Vasarlo()
                    {
                        KeresztNev = kersztNev,
                        VezetekNev= vezetekNev,
                        Telefonszam=telefon,
                        Email= email
                    };
                using (var ctx = DataContext.Instance())
                {
                    var vasarloRepo = ctx.GetRepository<Vasarlo>();
                    vasarloRepo.Insert(vasarlo);
                }
                DataContext.Instance().Commit();
                vasarlo = FindVasarlo(kersztNev, vezetekNev, telefon, email);

                Rendeles rendeles = new Rendeles()
                {
                    AsztalID=asztal.AsztalID,
                    VasarloID=vasarlo.VasarloID,
                    BookingDateTime=dateTime,
                    IsCancelled=false,
                };

                using (var ctx = DataContext.Instance())
                {
                    var rendelesRepo = ctx.GetRepository<Rendeles>();
                    rendelesRepo.Insert(rendeles);
                }
                DataContext.Instance().Commit();

                return RedirectToDefaultRoute();
                //return JavaScript("\"OK\"");

            }
            catch (Exception ex)
            {
                var s = form.ToString();
                var t = form["bookingTime"];
                var d = form["date"];
                var tn = form["tableName"];
                s = $"\"{ex.Message}, {ex.StackTrace}, {ex}, {s}, time={t}, date={d}, tn={tn} \"";
                return JavaScript(s);

            }


        }


    }
}