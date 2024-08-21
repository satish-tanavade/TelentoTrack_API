using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entity;

namespace TalentoTrack.Dao.Db
{
    public class TalentoTrack_DbContext : DbContext
    {
        public TalentoTrack_DbContext(DbContextOptions option )  :  base(option)
        {
            
        }

        public DbSet<User> tbl_user { get; set; }

        public DbSet<LoginDetails> tbl_login_details { get; set; }
    }
}
