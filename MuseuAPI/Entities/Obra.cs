namespace MuseuAPI.Entities
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; } // Dados binários da imagem
    }
}
