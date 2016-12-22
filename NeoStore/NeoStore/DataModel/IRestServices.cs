using NeoStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.DataModel
{
    public interface IRestServices
    {
        Task<RegistrationResponse> RegisterUserDetails(RegisterViewModel regDetails);
    }
}
