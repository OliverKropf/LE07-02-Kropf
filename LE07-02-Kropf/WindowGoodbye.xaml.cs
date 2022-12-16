using System.Threading;
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
        
        }
        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void SleepAndClose()
        {
            Thread.Sleep(10000);
            Close();
        }
    }
}
