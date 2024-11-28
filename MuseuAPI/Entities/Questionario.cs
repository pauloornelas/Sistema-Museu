namespace MuseuAPI.Entities
{
    public class Questionario
    {
        public int Id { get; set; }
        public string Avaliacao { get; set; } // Ex.: Excelente, Boa, Regular, Ruim
        public string Sugestao { get; set; } // Opcional
        public string Email { get; set; } // Opcional
    }
}