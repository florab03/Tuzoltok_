using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Dnn.PoolTableBookingDNN.Tuzoltok.PoolTableBooking.Models
{
    [TableName("Asztal")]
    //setup the primary key for table
    [PrimaryKey("AsztalID", AutoIncrement = true)]
    //configure caching using PetaPoco
    [Cacheable("Asztal", CacheItemPriority.Default, 20)]
    //scope the objects to the ModuleId of a module on a page (or copy of a module on a page)
    [Scope("ModuleId")]
    public class Asztal
    {
        public int AsztalID { get; set; } = -1;

        public string Name { get; set; }

        

        
    }
}