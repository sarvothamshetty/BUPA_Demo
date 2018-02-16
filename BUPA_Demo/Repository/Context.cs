using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BUPA_Demo.Model;

namespace BUPA_Demo.Repository
{
    public class Context: DbContext
    {
        public Context()

            : base("name=SDemo_BUPAEntities")

        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}