using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisMVC.Models
{
    [Table("Imovel")]
    public class ImovelModel
    {
        [Key]
        public int IdImovel { get; set; }
        [Required]
        [StringLength(100)]
        public string DscImovel { get; set; }
        [Required]
        public decimal VlrImovel { get; set; }
        [Required] 
        public int NumQrtImovel { get; set; }
        [Required]
        public int NumVagImovel { get; set; }
        [Required]
        [StringLength(15)]
        public string TipImovel { get; set; }
        [Required]
        [StringLength(100)]
        public string RuaImovel { get; set; }
        [Required]
        [StringLength(30)]
        public string BroImovel { get; set; }
        [Required]
        [StringLength(30)]
        public string CddImovel { get; set; }
        [Required]
        [StringLength(30)]
        public string UFImovel { get; set; }
        [Required]
        [StringLength(8)]
        public string CEPImovel { get; set; }
    }
}
