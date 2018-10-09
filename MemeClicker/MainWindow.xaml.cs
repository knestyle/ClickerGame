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
using WpfAnimatedGif;
using System.Windows.Threading;

namespace MemeClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void DispatcherTimerSample()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToLongTimeString();
        }

        public MainWindow()
        {
            InitializeComponent();
            SetImage();
            DispatcherTimerSample();
        }

        private void SetImage()
        {
            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("LOL-Trol-Face.gif",UriKind.Relative);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(imgGif, image);
            
        }
    }
}
