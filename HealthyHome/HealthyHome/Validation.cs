using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHome
{
    class Validation
    {
        public MTRSignUpForm MSF { get; set; }
        public Validation(MTRSignUpForm SF)
        {
            this.MSF = SF;
        }
        public bool IsIdValid(string id)
        {
            if (id.Length > 3 && id.Length < 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPasswordValid(string password)
        {
            if (password.Length >= 4 && password.Length < 32)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPhoneNoValid(string phoneNo)
        {
            if (phoneNo.Length >= 10)
            {
                if (phoneNo[0] == '0')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
