using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Domain
{

    public class Example
    {
        public int ID { get; set; }

        [Required]
        public string ExampleText { get; set; }

        public DateTime CteateDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = false;

        public bool IsMain { get; set; } = false;

        public string UserID { get; set; }

        [ForeignKey("UserID")]
        public virtual ApplicationUser User { get; set; }

        public int ExplanationID { get; set; }

        [ForeignKey("ExplanationID")]
        public virtual Explanation Explanation { get; set; }

    }
}