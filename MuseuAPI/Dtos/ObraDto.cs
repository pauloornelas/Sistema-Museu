namespace MuseuAPI.Dtos
{
    public class ObraDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; } // Dados binários da imagem
    }
}
