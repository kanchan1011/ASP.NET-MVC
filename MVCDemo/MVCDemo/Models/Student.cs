using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Student
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
        public string Gender{ get; set; }
        public string Address { get; set; }
        public string Hobbies { get; set; }
        public Courses Course { get; set; } 
        public string Skills { get; set; }
        public enum Courses
        {
           CSharp,
           ASP,
           MVC,
           SQLServer


        }
    }
}