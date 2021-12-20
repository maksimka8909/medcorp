using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Models
{
    class RecordData
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string address { get; set; }
        public bool status { get; set; }
        public DateTime dateOfUpdate { get; set; }
        public int idPatient { get; set; }
        public int idEmployee { get; set; }
    }
}
