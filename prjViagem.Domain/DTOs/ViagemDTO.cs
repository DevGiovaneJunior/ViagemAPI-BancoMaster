using System.Text.Json.Serialization;

namespace prjViagem.Domain.DTOs
{
    public class ViagemDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Rota { get; set; }
        public int Custo { get; set; }
    }
    public class ViagemRequestDTO
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        [JsonIgnore]
        public string? Rota { get; set; }
        public int Custo { get; set; }
    }
}
