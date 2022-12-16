using System;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Timers;

namespace LE07_02_Kropf
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
        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void BtnMinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void BtnCloseClick(object sender, RoutedEventArgs e)
        {
            WindowGoodbye windowGoodbye = new WindowGoodbye();
            windowGoodbye.ShowDialog();
        }
        private void RadioBtnCheckedChangeImageToThumbsUp(object sender, RoutedEventArgs e)
        {
            if(radioBtn3.IsChecked == true) image1.Source = new BitmapImage(new Uri("Pictures/thumbUp.png", UriKind.Relative));
            else if(radioBtn6.IsChecked == true) image2.Source = new BitmapImage(new Uri("Pictures/thumbUp.png", UriKind.Relative));
            else if(radioBtn8.IsChecked == true) image3.Source = new BitmapImage(new Uri("Pictures/thumbUp.png", UriKind.Relative));
            else image4.Source = new BitmapImage(new Uri("Pictures/thumbUp.png", UriKind.Relative));
        }
        private void RadioBtnCheckedChangeImageToThumbsDown(object sender, RoutedEventArgs e)
        {
            if(radioBtn1.IsChecked== true || radioBtn2.IsChecked == true) image1.Source = new BitmapImage(new Uri("Pictures/thumbDown.png", UriKind.Relative));
            else if(radioBtn4.IsChecked == true || radioBtn5.IsChecked == true) image2.Source = new BitmapImage(new Uri("Pictures/thumbDown.png", UriKind.Relative));
            else if(radioBtn7.IsChecked == true || radioBtn9.IsChecked == true) image3.Source = new BitmapImage(new Uri("Pictures/thumbDown.png", UriKind.Relative));
            else image4.Source = new BitmapImage(new Uri("Pictures/thumbDown.png", UriKind.Relative));
        }
        private void ReloadClick(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("Pictures/space.png", UriKind.Relative));
            image2.Source = new BitmapImage(new Uri("Pictures/space.png", UriKind.Relative));
            image3.Source = new BitmapImage(new Uri("Pictures/space.png", UriKind.Relative));
            image4.Source = new BitmapImage(new Uri("Pictures/space.png", UriKind.Relative));
        }
    }
}
