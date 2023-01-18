namespace Ropot_Anastasia.Models
{
    public class ProfesorCurs
    {
        public int ID { get; set; }
        public string Nume_ProfesorCurs { get; set; }
        public ICollection<Examen>? Examene { get; set; } //navigation propert
    }
}
