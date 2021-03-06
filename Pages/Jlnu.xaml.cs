﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using HotNews_UWP.Data;
using System.Collections.ObjectModel;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HotNews_UWP.Pages {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Jlnu : Page {

        public ObservableCollection<Jlinfo> jlnuNews;
        public ObservableCollection<Jlinfo> jlnuNotices;
        public Jlnu() {
            this.InitializeComponent();

            jlnuNews = new ObservableCollection<Jlinfo>();
            jlnuNotices = new ObservableCollection<Jlinfo>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            jlnuNews = GetJlnu.GetJlnuNews();
            //jlnuNotices = GetJlnu.GetJlnuNotices();
        }
    }
}
