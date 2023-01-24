﻿using NLog.Layouts;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace ViewModels
{
	public class MainViewModel: BindableBase
    {


        private string postText;

        public string PostText
        {
            get { return postText; }
            set { SetProperty(ref postText, value); }
        }


        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri)
             );
            e.Handled = true;
        }


        public MainViewModel()
        {
            var isValidated = Template2.Properties.Settings.Default.Validated;
            PostText = "";
            if ( isValidated ) { PostText += " *** Not Validated For Clinical Use ***"; }
            

        }

    }
}