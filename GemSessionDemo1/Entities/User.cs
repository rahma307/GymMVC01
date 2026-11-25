using GymSessionDemo1.Entities.Enums;

namespace GymSessionDemo1.Entities
{
    //hirarechy of inheritance
    public abstract class User:BaseEntity
    {

        public string Name { get; set; } = default!;

        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public Genders Gender { get; set; }
        public Adress Address { get; set; } = default!;


    }
}
