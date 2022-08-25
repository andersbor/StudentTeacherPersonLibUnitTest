using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPersonLibUnitTest
{
    public class StudentValidator: PersonValidator
    {
        public static void ValidateSemester(int semester)
        {
            if (semester < 0)
                throw new ArgumentOutOfRangeException("Semester must be at least 1: " + semester);
            if (semester > 5)
                throw new ArgumentOutOfRangeException("Semester must be at most 5: " + semester);
        }

        public static void Validate(Student student)
        {
            ValidateSemester(student.Semester);
            ValidateName(student.Name);
        }
    }
}
