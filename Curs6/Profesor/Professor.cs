namespace Profesor
{
    public class Professor
    {
        public Professor()
        {
        }
        public string Name { get; set; }

        public string Faculty { get; set; }

        public string Specialization { get; set; }

        public string Print()
        {
            return $"{Name} is teaching at {Faculty} with {Specialization}";
        }
    }
}