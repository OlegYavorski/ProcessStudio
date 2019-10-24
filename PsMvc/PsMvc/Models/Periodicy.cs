using System.ComponentModel.DataAnnotations;


namespace PsMvc.Models
{
    public class Periodicy
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}