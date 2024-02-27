using SAR_Resid__Beta_Version_3_.Model.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SAR_Resid__Beta_Version_3_.Services
{
    public class MenuButtonManager
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        public bool SettingsPage = false;
        public MenuButtonManager(Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            this.button1 = button1;
            this.button2 = button2;
            this.button3 = button3;
            this.button4 = button4;
            this.button5 = button5;
        }
        public MenuButtonManager(Button button1, Button button2, Button button3, Button button4)
        {
            this.button1 = button1;
            this.button2 = button2;
            this.button3 = button3;
            this.button4 = button4;
            this.button5 = new Button();
        }
        private void ResetButtons()
        {
            if (Settings1.Default.Theme == "Dark")
            {
                this.button1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                this.button2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                this.button3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                this.button4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                this.button5.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                this.button2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                this.button3.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                this.button4.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                this.button5.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            if (SettingsPage == false)
            {
                this.button1.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                this.button2.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                this.button3.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                this.button4.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                this.button5.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
            }
            else if (SettingsPage == true)
            {
                if (Settings1.Default.Theme == "Dark")
                {
                    this.button1.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                    this.button2.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                    this.button3.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                    this.button4.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                    this.button5.Background = new SolidColorBrush(Color.FromArgb(32, 255, 255, 255));
                }
                else if (Settings1.Default.Theme == "Light")
                {
                    this.button1.Background = new SolidColorBrush(Color.FromArgb(32, 0, 0, 0));
                    this.button2.Background = new SolidColorBrush(Color.FromArgb(32, 0, 0, 0));
                    this.button3.Background = new SolidColorBrush(Color.FromArgb(32, 0, 0, 0));
                    this.button4.Background = new SolidColorBrush(Color.FromArgb(32, 0, 0, 0));
                    this.button5.Background = new SolidColorBrush(Color.FromArgb(32, 0, 0, 0));
                }
            }
        }
        public void SetButton1()
        {
            ResetButtons();
            if (Settings1.Default.Theme == "Dark")
            {
                this.button1.Background = new SolidColorBrush(Color.FromArgb(255, 42, 166, 232));
                this.button1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button1.Background = new SolidColorBrush(Color.FromArgb(255, 34, 21, 110));
                this.button1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
        public void SetButton2()
        {
            ResetButtons();
            if (Settings1.Default.Theme == "Dark")
            {
                this.button2.Background = new SolidColorBrush(Color.FromArgb(255, 42, 166, 232));
                this.button2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button2.Background = new SolidColorBrush(Color.FromArgb(255, 34, 21, 110));
                this.button2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
        public void SetButton3()
        {
            ResetButtons();
            if (Settings1.Default.Theme == "Dark")
            {
                this.button3.Background = new SolidColorBrush(Color.FromArgb(255, 42, 166, 232));
                this.button3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button3.Background = new SolidColorBrush(Color.FromArgb(255, 34, 21, 110));
                this.button3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
        public void SetButton4()
        {
            ResetButtons();
            if (Settings1.Default.Theme == "Dark")
            {
                this.button4.Background = new SolidColorBrush(Color.FromArgb(255, 42, 166, 232));
                this.button4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button4.Background = new SolidColorBrush(Color.FromArgb(255, 34, 21, 110));
                this.button4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
        public void SetButton5()
        {
            ResetButtons();
            if (Settings1.Default.Theme == "Dark")
            {
                this.button5.Background = new SolidColorBrush(Color.FromArgb(255, 42, 166, 232));
                this.button5.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
            else if (Settings1.Default.Theme == "Light")
            {
                this.button5.Background = new SolidColorBrush(Color.FromArgb(255, 34, 21, 110));
                this.button5.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
    }
}
