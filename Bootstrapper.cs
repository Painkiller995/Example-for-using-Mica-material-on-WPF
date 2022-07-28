using WPFwithMica.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace WPFwithMica
{
    public class Bootstrapper : BootstrapperBase
    {

        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            var settings = new Dictionary<string, object>
            {
            { "WindowStartupLocation", WindowStartupLocation.CenterScreen },
            { "SizeToContent", SizeToContent.Manual },
            { "Height" , SystemParameters.PrimaryScreenHeight / 1.3 },
            { "Width"  , SystemParameters.PrimaryScreenWidth / 1.3 },
            };

            if (Environment.OSVersion.Version.Build >= 22000)
            {
                SolidColorBrush BackgroundColor = new SolidColorBrush(Colors.Transparent);
                settings.Add("Background", BackgroundColor); 
                settings.Add("WindowStyle", WindowStyle.None);
            }
            DisplayRootViewForAsync<ShellViewModel>(settings);
        }
    }
}