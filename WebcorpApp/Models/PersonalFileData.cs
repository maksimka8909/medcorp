using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcorpApp.Models
{
    class PersonalFileData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public string gender { get; set; }
        public DateTime birthday { get; set; }
        public string inn { get; set; }
        public string snils { get; set; }
        public string passportSeries { get; set; }
        public string passportNumber { get; set; }
        public string employmentHistory { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string education { get; set; }
        public string requisites { get; set; }
        public string militaryId { get; set; }
    }
}
