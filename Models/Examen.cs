using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Policy;
using System.Xml.Linq;

namespace Ropot_Anastasia.Models
{
    public class Examen
    {
        public int ID { get; set; }
        [Display(Name = "Disciplina examen")]

        public string Materie { get; set; }


        [Column(TypeName = "decimal(3, 0)")]
        public decimal Sala { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataExamen { get; set; }
        public int? Data_ExID { get; set; }
        public Data_Ex? Data_Ex { get; set; } //navigation property
        public string Profesor{ get; set; }
        
    } 



}

