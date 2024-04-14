using Api.Data;

namespace Api.Model
{
    public class Lead
    {

        public int LeadId { get; set; } // Add LeadId as the primary key

        public int CustomerId { get; set; }
        public string LeadName { get; set; }
        // public Customer Customer { get; set; }

        public LeadStatus LeadStatus { get; set; }
        //public ICollection<Opportunity> Opportunities { get; set; }

        public string ApplicationUserId { get; set; } // Add this property to establish the relationship with ApplicationUser

        public ApplicationUser ApplicationUser { get; set; } // Navigation property

        public Lead()
        {
            CustomerId = default;
        }
    }
}

