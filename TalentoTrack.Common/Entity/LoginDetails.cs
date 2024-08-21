using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalentoTrack.Common.Entity
{
    public class LoginDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool IsBlocked { get; set; }

        [ForeignKey("UserId")]
        public User? user { get; set; }  

    }
}
