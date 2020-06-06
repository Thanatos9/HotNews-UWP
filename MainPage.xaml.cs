using HotNews_UWP.Pages;
using System;
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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace HotNews_UWP {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Hello));
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            if (args.IsSettingsInvoked) {
                //ContentFrame.Navigate(typeof(SettingsPage));
            }
            else {
                //选中项的内容
                switch (args.InvokedItem) {
                    case "每日热榜":
                        ContentFrame.Navigate(typeof(AllNews));
                        sender.Header = "想看看那个网站的信息？";
                        break;

                    case "最新资讯":
                        ContentFrame.Navigate(typeof(RandomNews));
                        sender.Header = "一天的精彩时刻";
                        break;

                    //case "吉师":
                    //    ContentFrame.Navigate(typeof(Jlnu));
                    //    sender.Header = "吉林师范大学";
                    //    break;

                    case "Home":
                        ContentFrame.Navigate(typeof(Hello));
                        sender.Header = "我的小程序";
                        break;
                }
            }
        }

        private void NavView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args) {
            if (ContentFrame.CanGoBack) {
                ContentFrame.GoBack();
            }
        }


        //private void AllBtn_Click(object sender, RoutedEventArgs e) {
        //    this.Frame.Navigate(typeof(AllNews));
        //}

        //private void RandomBtn_Click(object sender, RoutedEventArgs e) {
        //    this.Frame.Navigate(typeof(RandomNews));
        //}
    }
}
