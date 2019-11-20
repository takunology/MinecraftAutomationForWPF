using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MinecraftAutomationForWPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_North(object sender, RoutedEventArgs e)
        {      
            try
            {
                Task.Run(() => {
                    AutomationInstance Automation = new AutomationInstance();
                    Automation.MOVE.ButtonBitMove(3);
                });

            }
            catch (Exception ex){ LOG.Text = ex.ToString(); }
        }

        private void Button_South(object sender, RoutedEventArgs e)
        {
            try
            {
                Task.Run(() => {
                    AutomationInstance Automation = new AutomationInstance();
                    Automation.MOVE.ButtonBitMove(2);
                });                
            }
            catch (Exception ex) { LOG.Text = ex.ToString(); }
        }

        private void Button_East(object sender, RoutedEventArgs e)
        {
            try
            {
                Task.Run(() => {
                    AutomationInstance Automation = new AutomationInstance();
                    Automation.MOVE.ButtonBitMove(0);
                });
            }
            catch (Exception ex) { LOG.Text = ex.ToString(); }
        }

        private void Button_West(object sender, RoutedEventArgs e)
        {
            try
            {
                Task.Run(() => {
                    AutomationInstance Automation = new AutomationInstance();
                    Automation.MOVE.ButtonBitMove(1);
                });
            }
            catch (Exception ex) { LOG.Text = ex.ToString(); }
        }

        private void Button_Position(object sender, RoutedEventArgs e)
        {
            try
            {
                Task.Run(() => {
                    AutomationInstance Automation = new AutomationInstance();
                    Automation.MOVE.Position();
                });
            }
            catch (Exception ex) { LOG.Text = ex.ToString(); }
        }
    }
}
