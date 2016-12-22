using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore
{
    public interface IValidation
    {
        void numberLength();
        void Fname();
        void Lname();
        void EmailID();
        void Pass();
        void ConfirmPass();

    }
}
