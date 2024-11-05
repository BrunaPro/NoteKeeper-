namespace NoteKeeper.Models
{
    public class NotesModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Updated_at { get; set;} = DateTime.Now;
        public DateTime Delete_at { get; set; } = DateTime.Now;
        public int? UserId { get; set; }
        public virtual UserModel? User { get; set; }
    }
}
