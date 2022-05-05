using Newtonsoft.Json;

namespace KS.Fiks.Protokoller.V1.Models.Feilmelding
{
    public abstract class FeilmeldingBase
    {
        [JsonProperty("errorId")]
        public string ErrorId { get; set; } = null!;

        [JsonProperty("feilmelding")]
        public string Feilmelding { get; set; } = null!;

        [JsonProperty("correlationId")]
        public string? CorrelationId { get; set; }
    }
}