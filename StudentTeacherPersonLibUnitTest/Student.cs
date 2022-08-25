namespace StudentTeacherPersonLibUnitTest
{
    public class Student : Person
    {
        public int Semester { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Semester;
        }

        public override void Validate()
        {
            StudentValidator.Validate(this);
        }
    }
}