using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Insurance.Models
{
    public class User
    {


        [Key]

        public int UserId { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(12)")]
        public string UserName { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }




        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }


        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Role { get; set; }




    }
}
