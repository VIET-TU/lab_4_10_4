namespace lab4_10_4.Models
{
    public class Major
    {
        
        public int MajorID { get; set; }
        public string MajorName { get; set; }
        public ICollection<Learner> Learners { get; set; }

    }
}
