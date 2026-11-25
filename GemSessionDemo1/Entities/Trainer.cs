using GymSessionDemo1.Entities.Enums;

namespace GymSessionDemo1.Entities
{
    public class Trainer:User
    {

        public DateTime HireDate { get; set; }
        public Specialities Specialities { get; set; }

        // trainer and session relationship 1 to m  mandatory from two sides

        public ICollection<Session> TrainerSessions { get; set; } = new HashSet<Session>();


    }
}
