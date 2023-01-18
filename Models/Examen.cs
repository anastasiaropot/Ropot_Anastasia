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


        [Column(TypeName = "decimal (3,0)")]
        public decimal Sala { get; set; }
        public string Profesor{ get; set; }
        [DataType(DataType.Date)]
        public DateTime DataExamen { get; set; }
        public int? ProfesorCursID { get; set; }
        public ProfesorCurs? ProfesorCurs { get; set; } //navigation property
}
   



}

