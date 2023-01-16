namespace Ropot_Anastasia.Models
{
    public class Data_Examen
    {
        public int ID { get; set; }
        public decimal Data_Ex{ get; set; }
        public ICollection<Examen>? Examene { get; set; } //navigation property
    }
}
