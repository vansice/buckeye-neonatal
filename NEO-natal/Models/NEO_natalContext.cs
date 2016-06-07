using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NEO_natal.Models
{
    public class NEO_natalContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NEO_natalContext() : base("name=Survey")
        {
        }

        public System.Data.Entity.DbSet<NEO_natal.Models.Survey> Surveys { get; set; }

        public System.Data.Entity.DbSet<NEO_natal.Models.CommunityHealthWorker> CommunityHealthWorkers { get; set; }

        public System.Data.Entity.DbSet<NEO_natal.Models.Mothers_Data> Mothers_Data { get; set; }
    }
}
