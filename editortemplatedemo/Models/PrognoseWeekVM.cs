using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace editortemplatedemo.Models
{
    public class PrognoseWeekVM
    {
        public DateTime StartOfWeek { get; set; }
       
        public IEnumerable<PrognoseDayVM> PrognoseDays { get; set; }

        public PrognoseWeekVM()
        { }

        public PrognoseWeekVM(int days)
        {
            StartOfWeek = DateTime.Now.Date;
            var result = new List<PrognoseDayVM>();
            for (int i = 1; i <= days; i++)
            {
                result.Add(new PrognoseDayVM());
            }
            PrognoseDays = result;
        }
    }
}
