using System;
using System.Threading;
using System.Timers;
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
            Timer();
        }
        private void WindowMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void Timer()
        {
            System.Timers.Timer timer = new System.Timers.Timer();

            timer.Interval = 10000;
            timer.Elapsed += TimerElapsed;
            timer.Start();
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
