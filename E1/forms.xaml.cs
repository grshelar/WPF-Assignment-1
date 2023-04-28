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

namespace E1
{
    /// <summary>
    /// Interaction logic for forms.xaml
    /// </summary>
    public partial class forms : Page
    {
        public forms()
        {
            InitializeComponent();
        }

        private void Applybutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"your status:{this.BasicformlayoutText.Text}");
        }

        private void Applyreset_Click(object sender, RoutedEventArgs e)
        {
            this.Abox.IsChecked = this.Bbox.IsChecked = this.Cbox.IsChecked = this.Dbox.IsChecked = false;

        }

        private void suppliernametext_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.statusText.Text = this.suppliernamettext.Text;
        }
    }
}
