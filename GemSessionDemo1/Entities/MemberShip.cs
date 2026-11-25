namespace GymSessionDemo1.Entities
{
    public class MemberShip:BaseEntity // خليناها تورث علشان تاخد id ومش هنعمل ليها composite primarykey 
        // وده علشان ممكن نفس الشخص يرجع يشترك في البلان دي تاني بس بعد ماتخلص 

    {

        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }

        public Member Member { get; set; } = default!;

        public int MemberId { get; set; }


        public Plan Plan { get; set; } = default!;
        public int PlanId { get; set; }


        // computed  property not mapped as column in database
        public string Status => StartDate > DateTime.Now ? "Upcomming" : EndtDate > DateTime.Now ? "Active" : "Expired";

    }
}
