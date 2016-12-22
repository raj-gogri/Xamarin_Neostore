using NeoStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore
{
    public interface IRestService
    {
        Task<LoginResponse> LoginTodoAsync(LoginViewModel item);
    }
}
