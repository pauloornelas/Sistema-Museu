namespace MuseuAPI.Dtos
{
    public class QuestionarioDto
    {
        public int Id { get; set; }
        public string Avaliacao { get; set; } // Ex.: Excelente, Boa, Ruim
        public string Sugestao { get; set; } // Campo opcional
        public string Email { get; set; } // Campo opcional
    }
}
