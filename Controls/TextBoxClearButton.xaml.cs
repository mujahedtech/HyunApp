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

namespace HyunApp.Controls
{
    /// <summary>
    /// Interaction logic for TextBoxClearButton.xaml
    /// </summary>
    public partial class TextBoxClearButton : UserControl
    {

        public string Placeholder { get; set; }
        public string Text { get; set; }
        public TextBoxClearButton()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = "";
            txtValue.Focus();
        }
    }
}
