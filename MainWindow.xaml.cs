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

namespace zaharov_8pr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {

            double x0 = Convert.ToDouble(X0.Text);
            double xk = Convert.ToDouble(Xk.Text);
            double dx = Convert.ToDouble(Dx.Text);
            double a = Convert.ToDouble(A.Text);

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Log(x);

                X.Text += "x=" + Convert.ToString(x) + Environment.NewLine;
                Y.Text += "y=" + Convert.ToString(y) + Environment.NewLine;

                x = x + dx;
            }
            }
    }
}
