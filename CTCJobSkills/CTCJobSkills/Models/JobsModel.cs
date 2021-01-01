using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CTCJobSkills.Models
{

    //----------Below calls the Jobs API
    public class JobsModel
    {
       
        public string uuid { get; set; }


        //-------------- Below is where I would store the form Data into a DB / set certain fields to required.

        [Required]
        [MinLength(2)] // Atleast 2 letters for First name.
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)] // Needs an @ symbol basically. 
        [EmailAddress(ErrorMessage = "Please enter vaild email address.")]
        public string eMail { get; set; }

        [Required]
        public string District { get; set; }
    }


    // -------------- Below is for calling the Related skills API 

    public class JobSkills
    {  
        public JSimport[] skills { get; set; }
    }

    public class JSimport
    {
        public string skill_name { get; set; }
        public string description { get; set; }
        public float importance { get; set; }
    }

   
}
