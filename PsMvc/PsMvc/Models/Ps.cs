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

        [Display(Name="Имя процесса")]
        public string Description { get; set; }

        [Display(Name = "Описание")]
        public int? OwnerId { get; set; }

        [Display(Name = "Теги")]
        public int[] Tags { get; set; }

        [Display(Name = "Тип")]
        public int? Type { get; set; }

        [Display(Name = "Входящие документы")]
        public int[] InputDocuments { get; set; }

        [Display(Name = "Исходящие документы")]
        public int[] OutputDocuments { get; set; }

        [Display(Name = "Участники")]
        public int[] Participants { get; set; }

        [Display(Name = "Статус")]
        public int? StatusId { get; set; } //Active Paused Started Finished Cancelled

        [Display(Name = "Важность")]
        public int Importance { get; set; }

        [Display(Name = "Дочерние процессы")]
        public int[] Subprocesses { get; set; }

        [Display(Name = "Препятствующие процессы")]
        public int[] ObstacleProcesses { get; set; }

        [Display(Name = "Кому мешает данный процесс")]
        public int[] ImAnObstacleFor { get; set; } // I'm an obstacle for ... Processes for which this one is an obstacle.

        [Display(Name = "Методы процесса")]
        public int[] Methods { get; set; }

        [Display(Name = "Стоимость процесса")]
        [DataType(DataType.Currency)]
        public decimal? Cost { get; set; }

        [Display(Name = "Периодичность")]
        public int? PeriodicityId { get; set; } // Периодичность dayly weekly every Tuesday at 19-00


    }
}