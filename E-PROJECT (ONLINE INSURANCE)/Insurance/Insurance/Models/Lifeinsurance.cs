using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insurance.Models
{
    public class Lifeinsurance
    {
        [Key]

        public int Policynumber { get; set; }


        [Required]
        public int CNICnumber { get; set; }

        [Required]
        
        public int BankACC { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string HolderName { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerAddress { get; set; }


        [Required]

        public int Contact { get; set; }


        [Required]
       
        public string Gender { get; set; }

        [Required]

        public string MartialStatus { get; set; }



        [Required]

        public string Occupation { get; set; }

        [Required]
        public DateTime  PolicyValidity { get; set; }


        [Required]
        public DateTime PolicyStart { get; set; }


        [Required]
        public DateTime DOB { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string MotherName { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string NextofKIN {get; set; }



        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string RelationshipwithKIN { get; set; }


        [Required]
    
        public int KinContact { get; set; }




        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string FatherName { get; set; }







        [Required]
        public string Package { get; set; }













    }
}
