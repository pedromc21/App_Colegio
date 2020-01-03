namespace Cole.Common.Models
{
    using Newtonsoft.Json;
    using System;
    public class Tutor
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("persona_Id")]
        public long PersonaId { get; set; }

        [JsonProperty("clave_Familia")]
        public string ClaveFamilia { get; set; }

        [JsonProperty("apellido_Paterno")]
        public string ApellidoPaterno { get; set; }

        [JsonProperty("apellido_Materno")]
        public string ApellidoMaterno { get; set; }

        [JsonProperty("nombres")]
        public string Nombres { get; set; }

        [JsonProperty("parentesco")]
        public string Parentesco { get; set; }

        [JsonProperty("tutor_Principal")]
        public bool TutorPrincipal { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
