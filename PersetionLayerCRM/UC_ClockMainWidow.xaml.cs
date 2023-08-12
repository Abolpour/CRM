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
using System.Windows.Threading;
namespace PersetionLayerCRM
{
    /// <summary>
    /// Interaction logic for UC_ClockMainWidow.xaml
    /// </summary>
    public partial class UC_ClockMainWidow : UserControl
    {
        public UC_ClockMainWidow()
        {
            InitializeComponent();
           
        }
        private void Timer_Tick(object sender , EventArgs e)
        {
            txtClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
    }
}
