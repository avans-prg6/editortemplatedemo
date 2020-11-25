using System;
using System.ComponentModel.DataAnnotations;

namespace editortemplatedemo.Models
{

    public class PrognoseDayVM
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yy}")]
        [DataType(DataType.Date)]
        [Display(Name ="Dag")]
        public DateTime DagVanPrognose { get; set; }
        public int Klanten { get; set; }
        public int Colli { get; set; }
        public bool Spiegelen { get; set; }

        public PrognoseDayVM()
        { }
    }
}
