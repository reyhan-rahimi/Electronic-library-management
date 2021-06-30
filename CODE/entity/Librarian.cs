using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.entity
{
    public class Librarian
    {
        public int LibrarianID { get; set; }
        [Required]
        [StringLength(50)]
        public string LibrarianName { get; set; }
        [Required]
        [StringLength(50)]
        public string LibrarianLastName { get; set; }
        [Required]
        [Range(8, 16,
            ErrorMessage = "Price must be between 8(for hous number) and 16(for phone number)")]
        public int LibrarianPhoneNumber { get; set; }
        [Required]
        public string LibrarianAddress { get; set; }
    }
}
