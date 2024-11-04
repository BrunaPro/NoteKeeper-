namespace NoteKeeper.Models
{
    public class NotesModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public string email { get; set; }

        public DateTime updated_at { get; set;} = DateTime.Now;
        public DateTime delete_at { get; set; } = DateTime.Now; 

        public string userId { get; set; }
        public virtual UserModel? User { get; set; }
    }
}
