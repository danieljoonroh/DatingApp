using System;

namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public string PublicId { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        // always have to add migration when a model is created or an existing model is updated

    }
}