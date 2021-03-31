namespace SchoolPortal
{
    public class CommerceStudent: Student
    {
        public int ElectCirc { get; set; }
        public int CircuitAna { get; set; }
        public int AnaCom { get; set; }

        public CommerceStudent(int electCirc, int circuitAna, int anaCom,string regNum, string studName, string department): base(regNum, studName, department)
        {
            ElectCirc = electCirc;
            circuitAna = circuitAna;
            AnaCom = anaCom;
        }
    }
}