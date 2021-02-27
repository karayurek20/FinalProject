using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenhelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
