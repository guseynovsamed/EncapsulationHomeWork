using Encapsulation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Controllres
{
    internal class DoctorControllers
    {
        public void GetDoctorInfo()
        {
            DoctorService doctorService = new DoctorService();

            DateTime starDate = new DateTime(1993, 05, 25);
            DateTime endDate = new DateTime(2002, 12, 15);

            var result = doctorService.GetDoctorBirthDay(starDate, endDate);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + item.Surname);
            }
        }
    }
}
