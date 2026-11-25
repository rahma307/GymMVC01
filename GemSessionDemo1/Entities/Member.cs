namespace GymSessionDemo1.Entities
{
    public class Member:User
    {

        public string? Photo { get; set; }

        public ICollection<MemberShip> MemberSubscriptions { get; set; } = default!;
    }
}
