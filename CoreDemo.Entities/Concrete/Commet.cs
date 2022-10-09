using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Entities.Concrete
{
    public class Commet
    {
        [Key]
        public int CommetId { get; set; }
        public string CommerUsername { get; set; }
        public string CommerTitle { get; set; }
        public string CommetContent { get; set; }
        public DateTime CommetDate { get; set; }
        public bool CommetStatus { get; set; }

        public int BlogId { get; set; }
        public Blog blog { get; set; }
    }
}
