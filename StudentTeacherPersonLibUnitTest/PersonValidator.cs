using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherPersonLibUnitTest
{
    public class PersonValidator
    {
        public static void ValidateName(string? name)
        {
            if (name == null)
                throw new ArgumentNullException("name is null");
            if (name.Length < 1)
                throw new ArgumentException("name must be at least 1 character");
        }

        public static void Validate(Person person)
        {
            ValidateName(person.Name);
        }
    }
}
