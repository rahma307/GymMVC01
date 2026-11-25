namespace GymSessionDemo1.Entities
{
    // not mabed to table -- abstract to don't create object
    public abstract class BaseEntity // AuditEntity
    {

        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } // دي nullable علشان انا مش هحط فيها قيمه غير لما اعدل فيها 

    }

}
