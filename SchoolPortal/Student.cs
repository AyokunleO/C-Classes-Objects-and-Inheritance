namespace SchoolPortal
{
    public class Student
    {
        public string RegNum { get; set; }
        public string StudName { get; set; }
        public int Department { get; set; }

        public Student(string regNum, string studName, string department)
        {
            RegNum = regNum;
            StudName = studName;
            Department = department;
        }
    }
}