
using System.ComponentModel.DataAnnotations;

namespace cptis.domain.Logger
{
    public class Log
    {
        [Key]
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        [StringLength(50)]
        public string Level { get; set; } = string.Empty;

        [StringLength(8000)]
        public string Message { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Method { get; set; }

        [StringLength(255)]
        public string? Source { get; set; }

        [StringLength(500)]
        public string? ClassName { get; set; }

        [StringLength(255)]
        public string? Exception { get; set; }

        [StringLength(255)]
        public string? ExceptionType { get; set; }

        [StringLength(8000)]
        public string? InnerException { get; set; }

        [StringLength(8000)]
        public string? Stacktrace { get; set; }

        [StringLength(100)]
        public string Process { get; set; } = string.Empty;

        [StringLength(100)]
        public string User { get; set; } = string.Empty;
    }
}
