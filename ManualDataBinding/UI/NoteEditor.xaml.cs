using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Holds the Note that will be edited
        /// </summary>
        private Note note;
        public Note Note
        {
            get { return note; }
            set
            {
                if (note == value) return;
                if (note != null) note.NoteChanged -= OnNoteChanged;
                note = value;
                if (note != null)
                {
                    note.NoteChanged += OnNoteChanged;
                    OnNoteChanged(note, new EventArgs());
                }
            }
        }
        
        /// <summary>
        /// Handles the change of the Title's text
        /// </summary>
        /// <param name="sender">The text box that was changed</param>
        /// <param name="e">The event arguments</param>
        public void OnTitleChanged(object sender, TextChangedEventArgs e)
        {
            Note.Title = Title.Text;
        }

        /// <summary>
        /// Handles the change of the Body's text
        /// </summary>
        /// <param name="sender">The text box that was changed</param>
        /// <param name="e">The event arguments</param>
        public void OnBodyChanged(object sender, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }

        /// <summary>
        /// Handles the change of the Note
        /// </summary>
        /// <param name="sender">The changed Note</param>
        /// <param name="e">The event arguments</param>
        public void OnNoteChanged(object sender, EventArgs e)
        {
            if (Note == null) return;
            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }
    }
}