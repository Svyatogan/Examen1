using System;
using System.Windows;

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bread bread = new Bread();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Bread bread = new Bread();
            int v = Convert.ToInt32(tb1.Text);
            int m = Convert.ToInt32(bread.Qwe());
            int r = v * m;
            rez.Text = Convert.ToString(r);
        }
    }
}
