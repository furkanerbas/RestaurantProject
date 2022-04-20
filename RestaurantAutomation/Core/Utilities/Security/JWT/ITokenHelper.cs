using RestaurantAutomation.Models;
using System.Collections.Generic;

namespace RestaurantAutomation.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Employee employee, List<OperationClaim> operationClaims);
    }
}
