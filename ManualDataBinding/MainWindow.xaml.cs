using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Created a Note instance for the Editor instance
        /// </summary>
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Handles the New Note button click
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Handles the Clear Note button click
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Handles the Mutate Note button click
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The event arguments</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splinter:";
            note.Body = "There is no monster more dangerous than a lack of compassion.";
        }
    }
}
