using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Models
{
    class UserData
    {
        public int idUser { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public bool status { get; set; }
        public DateTime updateTime { get; set; }
    }
}
