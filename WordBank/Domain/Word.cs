using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Word
    {
        public Word()
        {
            Explanations = new HashSet<Explanation>();
        }
        public int ID { get; set; }

        [Required,MaxLength(200)]
        public string WordText { get; set; }

        public DateTime CteateDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = false;
       
        public string UserID{ get; set; }

        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }

        public ICollection<Explanation> Explanations { get; set; }

    } 

}