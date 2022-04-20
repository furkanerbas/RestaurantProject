using RestaurantAutomation.Core.Model;

namespace RestaurantAutomation.Models
{
    public class EmployeeOperationClaim : IModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
