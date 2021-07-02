using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryUnivercity.entity
{
    public class Books
    {
        public int BookID { get; set; }
        [Required]
        [StringLength(50)]
        public string BookName { get; set; }
        [Required]
        public int BookCode { get; set; }
        public int Time { get; set; }
        [Required]
        [StringLength(50)]
        public string BookWriter { get; set; }

        public int? UserID { get; set; }
        public User user { get; set; }
    }
}
