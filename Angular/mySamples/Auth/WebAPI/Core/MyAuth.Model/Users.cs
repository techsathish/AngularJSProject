using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAuth.Model
{
    public class UserSignUpForm {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string RetypePassword { get; set; }
    }
}
