using Encapsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Service
{
    public class DoctorService
    {
        public Doctor[] GetAllDoctors()
        {
            Doctor doc1 = new Doctor()
            {
                Name = "Semed",
                Surname = "Huseynov",
                Address = "Ehmedli",
                Birthday = new(1997, 04, 20)
            };
            Doctor doc2 = new Doctor()
            {
                Name = "Meryem",
                Surname = "Aliyeva",
                Address = "Yasamal",
                Birthday = new(2003, 01, 29)
            };
            Doctor doc3 = new Doctor()
            {
                Name = "Arzu",
                Surname = "Kerimova",
                Address = "Qaradag",
                Birthday = new(1998, 10, 21)
            };
            Doctor doc4 = new Doctor()
            {
                Name = "Tunzale",
                Surname = "Memmedova",
                Address = "Nesimi",
                Birthday = new(1999, 09, 09)
            };
            return new Doctor[] { doc1, doc2, doc3, doc4 };
        }

        public Doctor[] GetDoctorBirthDay(DateTime startDate , DateTime endDate)
        {
            return GetAllDoctors().Where(n=>n.Birthday>startDate&&n.Birthday<endDate).ToArray();
        }
    }
}




