using DotNetNuke.Common.Utilities;
using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Dnn.PoolTableBookingDNN.Tuzoltok.PoolTableBooking.Models
{
    [TableName("Vasarlo")]
    //setup the primary key for table
    [PrimaryKey("VasarloID", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Vasarlo", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class Vasarlo
    {
        public int VasarloID { get; set; } = -1;

        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public string Email { get; set; }

        public string Telefonszam { get; set; }



        
    }
}