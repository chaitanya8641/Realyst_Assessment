using Newtonsoft.Json;

namespace Realyst.Common
{
    public class ResponseModel
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        [JsonProperty(PropertyName = "result")]
        public string? Result { get; set; }
    }
}
