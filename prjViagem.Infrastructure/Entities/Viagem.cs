namespace prjViagem.Infrastructure.Entities
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string? Rota { get; set; }
        public int Custo { get; set; }
    }
}
