using Caliburn.Micro;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WPFwithMica.ViewModels
{
    class ShellViewModel : Screen
    {

        public void CloseApp()
        {
            this.TryCloseAsync();   
        }
    }

}


