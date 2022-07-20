using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace final_db.DbModels
{
    public class Song
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }

        public string Title { get; set; }

        public DateTime Duration { get; set; }

        public DateTime ReleasedDate { get; set; }

        [ForeignKey("GenreId")]

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<Performance> Performances { get; set; } = new List<Performance> { };
    }
}
