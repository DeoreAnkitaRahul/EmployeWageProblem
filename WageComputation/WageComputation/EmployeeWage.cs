using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageComputation
{ 
     public class EmployeeCheck
    {
        public int IS_FULLTIME = 1;
        public int EMP_RATE_PER_HOUR = 20;
        public int IS_PART_TIME = 2;
        public void CheckEmployee()
        {
            int empHrs = 0;
            int empWage = 0;

             Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == IS_FULLTIME)
                empHrs = 8;

            else if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else
                empHrs = 0;
              empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is: " + empWage);

        }
    }
}
