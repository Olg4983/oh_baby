using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ColumnAttribute = System.Data.Linq.Mapping.ColumnAttribute;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UI_Design
{
    public class Growth_Weight
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Required]
        public int AgeMonth { get; set; }
        [Required]
        public int Growth { get; set; }

        [Required]
        public float Weight { get; set; }
        public int Child_Id { get; set; }

        [ForeignKey("Child_Id")]
        public Child Child { get; set; }
    }
}
