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

        // Időpontok lekérése
        public IEnumerable<BookableTime> GetBookableTime(string tableName, string date)
        {
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(date))
                yield break;
            Asztal asztal = FindAsztalByName(tableName);
            int[] dateN = Array.ConvertAll(date.Split('.'), Int32.Parse);
            for (int hour = 13; hour <= 22; hour++)
            {
                DateTime dateTime = new DateTime(dateN[0], dateN[1], dateN[2], hour, 0, 0);
                bool isBooked = false;
                using (var ctx = DataContext.Instance())
                {
                    var rendelesRepo = ctx.GetRepository<Rendeles>();
                    isBooked = rendelesRepo.Get()
                        .Where(r =>
                        r.AsztalID == asztal.AsztalID &&
                        r.BookingDateTime == dateTime &&
                        r.IsCancelled == false)
                        .Count() == 1;
                }
                yield return new BookableTime($"{hour}:00", isBooked);

            }
        }

        public string GetDatePickerStringFormRequest(string date)
        {
            if (string.IsNullOrEmpty(date))
                return string.Empty;
            int[] numbers = Array.ConvertAll(date.Split('.'), Int32.Parse);
            return $"{numbers[1]}/{numbers[2]}/{numbers[0]}";
        }

        public string GetSelectedTableCommand(string tableName)
        {
            if (string.IsNullOrEmpty(tableName))
                return string.Empty;
            return $"window.onload = changeColor(document.getElementById('table{tableName}'), 'table');";
        }

        [HttpPost]
        public ActionResult AddBooking(FormCollection form)
        {
            Vasarlo vasarlo = null;
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
                vasarlo = FindVasarlo(kersztNev, vezetekNev, telefon, email);
                if (vasarlo == null)
                {
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
                }
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

            }
            catch (Exception ex)
            {
                return JavaScript("\"Error\"");
            }

        }

    }

    public struct BookableTime
    {
        public string Time;
        public string Class;
        public string OnClick;

        public BookableTime(string time, bool isBooked)
        {
            Time = time;
            Class = isBooked ? "bookedRectangle rectangle" : "rectangle";
            OnClick = isBooked ? "" : "changeColor(this, 'time')";
        }

    }
}