using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Models
{
    class WaybillData
    {
        public int id { get; set; }
        public double amount { get; set; }
        public DateTime dateOfEnrollment { get; set; }
        public int idEmployee { get; set; }
    }
}
