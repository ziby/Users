using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Users.Models
{
    public class LoginInfo
    {
        [MaxLength(50)]
        public string Login { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }
    }
}