using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.Record
{
    public record SignUpModel(string UserName, string Email, string Phone, string Password, string ConfirmPassword);

    public class SignUp
    {
        public string UserName { get; init; }
        public string Email { get; init; }
        public string Phone { get; init; }
        public string Password { get; init; }
        public string ConfirmPassword { get; init; }
    }
}
