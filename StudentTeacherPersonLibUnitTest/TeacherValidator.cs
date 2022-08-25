using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPersonLibUnitTest
{
    public  class TeacherValidator: PersonValidator
    {
        public static void ValidateSalary(int salary)
        {
            if (salary < 0)
                throw new ArgumentOutOfRangeException("Salary must be at least 0: " + salary);
        }

        public static void Validate(Teacher teacher)
        {
            ValidateSalary(teacher.Salary);
            ValidateName(teacher.Name);
        }
    }
}
