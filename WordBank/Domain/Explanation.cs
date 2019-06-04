using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain
{
    public class Explanation
    {
        public Explanation()
        {
            Examples = new HashSet<Example>();
        }

        public int ID { get; set; }

        [Required]
        public string ExplanationText { get; set; }

        public DateTime CteateDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = false;

        public bool IsMain { get; set; } = false;

        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }

        public int WordID { get; set; }

        [ForeignKey("WordID")]
        public virtual Word Word { get; set; }

        public ICollection<Example> Examples { get; set; }
    }
}