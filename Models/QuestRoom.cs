using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class QuestRoom
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string DurationTime { get; set; }

        public int MinPlayersCount { get; set; }
        public int MaxPlayersCount { get; set; }

        public int FearLevel { get; set; }

        public int Difficulty { get; set; }

        public string LogoPath { get; set; }
        public string PhoneNumbers { get; set; }
    }
}