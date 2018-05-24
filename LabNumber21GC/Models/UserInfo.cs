using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabNumber21GC.Models
{
    public class UserInfo
    {
        [Required]
        public string Fname
        {
            set; get;
        }
        [Required]
        public string Lname
        {
            set; get;
        }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Bad email, stupid!")]
        public string Email
        {
            set; get;
        }
        [Required]
        public string Phone
        {
            set; get;
        }
        [Required]
        public string Pass
        {
            set; get;
        }
        public UserInfo()
        {

        }
        public UserInfo(string fname,string lname, string email, string phone, string pass)
        {
            Fname = fname;
            Lname = lname;
            Email = email;
            Phone = phone;
            Pass = pass;
        }


    }
}