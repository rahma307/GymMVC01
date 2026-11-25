namespace GymSessionDemo1.Entities
{
    public class Session :BaseEntity
    {

        public string Description { get; set; } = default!;
        public int Capacity { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // trainer and session relationship 1 to m  mandatory from two sides

        public int sessionTrainerId { get; set; } // fk convention name
        public Trainer sessionTrainer { get; set; } = default!;

    }
}
