using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication15.Models
{
    public class QuestRoomContext:DbContext
    {
        public DbSet<QuestRoom> QuestRooms { get; set; }
    }
}