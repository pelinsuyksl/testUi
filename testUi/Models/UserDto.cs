using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testUi.Models
{
    public class RegisterDto
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class RemindIdDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ChangePasswordDto
    {
        public string Email { get; set; }
        public string p_old { get; set; }
        public string p_new { get; set; }
    }
}