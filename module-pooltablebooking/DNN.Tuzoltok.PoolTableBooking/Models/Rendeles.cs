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
    [TableName("Rendeles")]
    //setup the primary key for table
    [PrimaryKey("BookingID", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Rendeles", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class Rendeles
    {
        public int BookingID { get; set; } = -1;

        public int VasarloID { get; set; }
        public int AsztalID { get; set; }
        public DateTime BookingDateTime { get; set; }

        public bool IsCancelled { get; set; }



        
    }
}