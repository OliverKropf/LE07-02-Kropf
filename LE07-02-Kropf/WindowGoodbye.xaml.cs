using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LE07_02_Kropf
{
    /// <summary>
    /// Interaction logic for WindowGoodbye.xaml
    /// </summary>
    public partial class WindowGoodbye : Window
    {
        public WindowGoodbye()
        {
            InitializeComponent();
            ClosingProcess();
        }
        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private async void ClosingProcess()
        {
            await Task.Delay(10000);
            Environment.Exit(0);
        }
    }
}
