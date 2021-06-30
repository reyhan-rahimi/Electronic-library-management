using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.entity
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string UserLastName { get; set; }
        [Required]
        public int UserNationNumber { get; set; }
        [Required]
        public string UserAddress { get; set; }
        [Required]
        public DateTime UserBirthday { get; set; }
        [Required]
        public string UserJob { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }

        public IList<Books> rerbooks { get; set; }
    }
}
