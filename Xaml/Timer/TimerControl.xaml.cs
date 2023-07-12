using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace XamlTest.Xaml.Timer
{
    public partial class TimerControl : UserControl
    {
        private DispatcherTimer _timer;
        private TimeSpan _elapsedTime;

        public TimeSpan ElapsedTime
        {
            get => _elapsedTime;
            set
            {
                _elapsedTime = value;
                UpdateTimerValue();
            }
        }

        public TimerControl()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            ElapsedTime = ElapsedTime.Add(TimeSpan.FromSeconds(1));
        }

        private void StartTimer_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
        }

        private void StopTimer_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }

        private void ResetTimer_Click(object sender, RoutedEventArgs e)
        {
            ElapsedTime = TimeSpan.Zero;
        }

        private void UpdateTimerValue()
        {
            TimerValue.Text = ElapsedTime.ToString(@"hh\:mm\:ss");
        }
    }
}
