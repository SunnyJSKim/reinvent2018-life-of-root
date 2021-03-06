using System;
using System.Collections.Generic;

namespace GotTalent_API.Models
{
    public class Ranking
    {
        public int total_rank { get; set; }
        public int game_id { get; set; }
        public string name { get; set; }
        public int total_score { get; set; }
        public int total_found_objects { get; set; }
        public int total_playtime { get; set; }
    }
}