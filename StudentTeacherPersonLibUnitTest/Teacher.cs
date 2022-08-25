using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPersonLibUnitTest
{
    public class Teacher : Person
    {
        public int Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Salary;
        }

        public override void Validate()
        {
            TeacherValidator.Validate(this);
        }
    }
}
