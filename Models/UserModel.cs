﻿namespace NoteKeeper.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }

        public string password { get; set; }

        public ICollection<NotesModel> Notes { get; set; }

     
    }
}
