using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PsMvc.Models
{
    public class Ps // Process
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? OwnerId { get; set; }

        public int[] Tags { get; set; }

        public int? Type { get; set; }

        public int[] InputDocuments { get; set; }

        public int[] OutputDocuments { get; set; }

        public int[] Participants { get; set; }

        public int? StatusId { get; set; } //Active Paused Started Finished Cancelled

        public int Importance { get; set; }

        public int[] ObstacleProcesses { get; set; }

        public int[] Subprocesses { get; set; }

        public int[] ImAnObstacleFor { get; set; } // I'm an obstacle for ... Processes for which this one is an obstacle.

        public int[] Methods { get; set; }

        public decimal? Cost { get; set; }

        public int? PeriodicityId { get; set; } // Периодичность dayly weekly every Tuesday at 19-00


    }
}