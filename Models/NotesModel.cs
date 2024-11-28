using System.Text.Json.Serialization;

namespace NoteKeeper.Models
{
    public class NotesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime? Updated_at { get; set;} 
        public DateTime? Delete_at { get; set; } 
        public int? UserId { get; set; }

        [JsonIgnore]
        public UserModel? User { get; set; }
    }
}
