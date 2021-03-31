namespace SchoolPortal
{
    public class ScienceStudent: Student
    {
        public int ComputerNetwork { get; set; }
        public int DataStructure { get; set; }
        public int C_Sharp { get; set; }
        public ScienceStudent(int computerNet, int dataStructure, int cSharp,string regNum, string studName, string department): base(regNum, studName, department)
        {
            ComputerNetwork = computerNet;
            DataStructure = dataStructure;
            C_Sharp = cSharp;
            
        }
    }
}