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

namespace Wpf1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Color_Black(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
        private void MenuItem_Click_Color_White(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
        private void MenuItem_Click_Color_Red(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(205, 92, 92));
        }
        private void MenuItem_Click_Color_Blue(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(135, 206, 235));
        }
        private void MenuItem_Click_Color_Green(object sender, RoutedEventArgs e)
        {
            window.Background = new SolidColorBrush(Color.FromRgb(144, 238, 144));
        }

        private void MenuItem_Click_Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Работу сделала Морочка Ксения", "Информация о разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Menu_MouseEnter_Menu(object sender, MouseEventArgs e) 
        {
            stbar.Text = "Элемент управления: Menu";
        }
        private void Menu_MouseLeave_Menu(object sender, MouseEventArgs e)
        {
            stbar.Text = "";
        }

        private void Menu_MouseEnter_ToolBar(object sender, MouseEventArgs e)
        {
            stbar.Text = "Элемент управления: ToolBar";
        }
        private void Menu_MouseLeave_ToolBar(object sender, MouseEventArgs e)
        {
            stbar.Text = "";
        }




    }
}
