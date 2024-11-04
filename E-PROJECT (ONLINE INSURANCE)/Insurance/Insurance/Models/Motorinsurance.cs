using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insurance.Models
{
    public class Motorinsurance
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
       
        public string Category { get; set; }


        [Required]
        public string Brand { get; set; }


        [Required]
        public string Owner { get; set; }


        [Required]
        public string Vehiclenubmer { get; set; }


        [Required]
        public DateTime Purchasedate { get; set; }


        [Required]
        public DateTime PolicyValidity { get; set; }


        [Required]
        public string Package { get; set; }


    }
}
