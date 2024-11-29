namespace MuseuAPI.Entities
{
    public class Questionario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Pergunta1 { get; set; }
        public string Resposta1 { get; set; }
        public string Pergunta2 { get; set; }
        public string Resposta2 { get; set; }
        public string Pergunta3 { get; set; }
        public string Resposta3 { get; set; }
        public string Pergunta4 { get; set; }
        public string Resposta4 { get; set; }
        public string Pergunta5 { get; set; }
        public string Resposta5 { get; set; }
        public string Comentarios { get; set; }
    }
}
