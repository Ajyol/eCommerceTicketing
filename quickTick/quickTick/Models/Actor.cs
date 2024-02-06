using System;
namespace quickTick.Models
{
	public class Actor
	{
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }

    }
}

