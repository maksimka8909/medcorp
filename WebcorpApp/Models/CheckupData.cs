using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Models
{
    class CheckupData
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string patientComplaints { get; set; }
        public string resultOfPatientCheckup { get; set; }
        public string presciption { get; set; }
        public string conclusion { get; set; }
        public int idRecord { get; set; }
    }
}
