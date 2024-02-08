using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace wpf2dubik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Lst_control.Visibility = Visibility.Hidden;
            MainFrame.SetValue(Grid.ColumnSpanProperty, 2);
            MainFrame.Navigate(new Auth());
            Tran.MainFrame = MainFrame;
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if(Auths.InAuth == false)
            {
                Lst_control.Visibility = Visibility.Hidden;
                MainFrame.SetValue(Grid.ColumnSpanProperty, 2);
            }
            else
            {
                Lst_control.Visibility= Visibility.Visible;
                MainFrame.SetValue(Grid.ColumnProperty, 1);
                MainFrame.SetValue(Grid.ColumnSpanProperty, 1);
                Lst_control.Items.Clear();
                Lst_control.Items.Add("Продукция");
                if(Auths.Status == "Admin" || Auths.Status == "Manager")
                {
                    Lst_control.Items.Add("Материалы");
                }
                if (Auths.Status == "Admin")
                {
                    Lst_control.Items.Add("Поставщики");
                }
                Lst_control.Items.Add("Выход");
            }

        }

        private void Lst_control_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Lst_control.Items.Count > 0 && Lst_control.SelectedIndex != -1)
            {
                if (Lst_control.Items[Lst_control.SelectedIndex].ToString() == "Материалы")
                {
                    MainFrame.Navigate(new Materials());
                }

                if (Lst_control.Items[Lst_control.SelectedIndex].ToString() == "Поставщики")
                {
                    MainFrame.Navigate(new Providers());
                }

                if (Lst_control.Items[Lst_control.SelectedIndex].ToString() == "Продукция")
                {
                    MainFrame.Navigate(new Product());
                }

                if (Lst_control.Items[Lst_control.SelectedIndex].ToString() == "Выход")
                {
                    Lst_control.Visibility = Visibility.Hidden;
                    MainFrame.SetValue(Grid.ColumnSpanProperty, 2);
                    MainFrame.Navigate(new Auth());
                    Auths.InAuth = false;
                    Auths.Login = null;
                    Auths.Status = null;
                }
            }

        }
    }
}
