namespace Cole.Common.Models
{
    using Newtonsoft.Json;

    public partial class Student
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("persona_Id")]
        public long PersonaId { get; set; }

        [JsonProperty("clave_Plantel")]
        public string ClavePlantel { get; set; }

        [JsonProperty("plantel")]
        public string Plantel { get; set; }

        [JsonProperty("matricula")]
        public long Matricula { get; set; }

        [JsonProperty("clave_Familia")]
        public string ClaveFamilia { get; set; }

        [JsonProperty("apellido_Paterno")]
        public string ApellidoPaterno { get; set; }

        [JsonProperty("apellido_Materno")]
        public string ApellidoMaterno { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("nivel")]
        public string Nivel { get; set; }

        [JsonProperty("grado")]
        public string Grado { get; set; }

        [JsonProperty("grupo")]
        public string Grupo { get; set; }
    }
}
