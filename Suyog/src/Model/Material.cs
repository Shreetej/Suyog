using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suyog.src.Model
{
    public class Material
    {


        public Material(string MaterialType,int Qty, int Units )
        {
            this.MaterialType = MaterialType;
            this.Qty = Qty;
            this.Units = Units;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int materialId { get; set; }
        public int Units { get; set; }
        public string MaterialType { get; set; }
        public int Qty { get; set; }
    }
}
