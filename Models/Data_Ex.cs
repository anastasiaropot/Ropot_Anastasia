namespace Ropot_Anastasia.Models
{
    public class Data_Ex
    {
        public int ID { get; set; }
        public DateTime Dati_de_examen{ get; set; }
        public ICollection<Examen>? Examene { get; set; } //navigation property
    }
}
