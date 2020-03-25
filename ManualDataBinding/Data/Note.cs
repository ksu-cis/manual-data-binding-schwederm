using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// The title of the Note
        /// </summary>
        private string title = DateTime.Now.ToString();
        public string Title
        {
            get { return title; }
            set
            {
                if (value == title) return;
                title = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// The text of the note
        /// </summary>
        private string body = "";
        public string Body
        {
            get { return body; }
            set
            {
                if (value == body) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Notifies the note editor that Note has changed
        /// </summary>
        public event EventHandler NoteChanged;
    }
}
