using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    /// <summary>
    /// Person Model
    /// </summary>
    public class Person
    {
        /// <summary>
        /// User unique Id in the database
        /// </summary>
        public int id = 0;
        
        /// <summary>
        /// User First Name
        /// </summary>
        public string FirstName = "";

        /// <summary>
        /// User Last Name
        /// </summary>
        public string LastName  = "";
    }
}