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
using System.Windows.Shapes;

namespace HyunApp.Pages
{
    /// <summary>
    /// Interaction logic for AppAccessGuide.xaml
    /// </summary>
    public partial class AppAccessGuide : Window
    {
        public static AppAccessGuide Instance;
        public AppAccessGuide()
        {
            InitializeComponent();

            Instance=this;

            MainGrid.Children.Add(new Pages.LanguagePage());
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
