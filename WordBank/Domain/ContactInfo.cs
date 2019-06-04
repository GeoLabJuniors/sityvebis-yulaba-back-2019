using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ContactInfo
    {
        public int id { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [EmailAddress,MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string PhoneNumber { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagramm { get; set; }

        public string AboutUs  { get; set; }
    }
}
