using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GotTalent_API.Models
{
    [Table("tb_game_result")]
    public class GameResult
    {
        [Key]
        public int game_id { get; set; }
        public string result_page_url { get; set; }
        public int total_score { get; set; }
        public int total_rank { get; set; }
        public int total_found_objects { get; set; }
        public int total_playtime { get; set; } // sec
    }
}