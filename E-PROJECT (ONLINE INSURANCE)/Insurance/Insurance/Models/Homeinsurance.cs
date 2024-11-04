using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Insurance.Models
{
    public class Homeinsurance
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

        public string Occupation { get; set; }


        [Required]
        public string HouseAddress { get; set; }

        [Required]
        public int HouseMembers { get; set; }


        [Required]
        public string HouseOwner { get; set; }


        [Required]
        public string Housesqyard { get; set; }

        [Required]
        
        public string Houseprice { get; set; }


        [Required]
        public string Housetype  { get; set; }



        [Required]
        public DateTime PolicyValidity { get; set; }


        [Required]
        public string Package { get; set; }

    }
}
