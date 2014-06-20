using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using MyAuth.Model;

namespace MyAuth.Controllers
{
    public class AuthController : ApiController
    {
        [ActionName("Register")]
        [HttpPost]
        public string PostRegister(UserSignUpForm userSignUpForm) {
            MembershipCreateStatus membershipCreateStatus;
            Membership.CreateUser(userSignUpForm.EmailId, userSignUpForm.Password, userSignUpForm.EmailId, "", "", true, out membershipCreateStatus);

            return membershipCreateStatus.ToString();
        }

        [HttpGet]
        public bool GetUserExist(string emailId)
        {
            MembershipUserCollection membershipUserCollection = Membership.FindUsersByEmail(emailId);
            if (membershipUserCollection != null && membershipUserCollection.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
            
        }
    }
}
