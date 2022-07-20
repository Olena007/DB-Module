using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_db.DbModels
{
    public class Performance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PerformanceId { get; set; }

        [ForeignKey("ArtistId")]

        public int ArtistId { get; set; }

        public Artist Artist { get; set; }

        [ForeignKey("SongId")]

        public int SongId { get; set; }

        public Song Song { get; set; }

        public DateTime? DateOfPerformance { get; set; }

        public string? LocationPlatform { get; set; }
    }
}
