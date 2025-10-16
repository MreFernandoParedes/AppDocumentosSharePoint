using System;

namespace AppDocumentosSharePoint.Models
{
    public class PreguntaRespuestaCanonica
    {
        public int QAID { get; set; }
        public string Tema { get; set; }
        public string PreguntaCanonica { get; set; }
        public string RespuestaOficial { get; set; }
        public string FuenteOficial { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Vigente { get; set; }
        public byte[] Embedding { get; set; }
    }
}
