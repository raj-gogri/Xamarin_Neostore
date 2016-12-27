using NeoStore.RegisterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.HomePage
{
    interface IRestServices
    {
        Task<HomePageResponse> RegisterUserDetails(HomepageModelView regResponse);
    }
}
