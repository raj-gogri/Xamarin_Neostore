using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.ForgetPasswordPage
{
    interface IRestServiceForgetPassword
    {
        Task<ForgetPasswordResponse> ForgetPasswordTodoAsync(ForgetPasswordViewModel item);
    }
}
