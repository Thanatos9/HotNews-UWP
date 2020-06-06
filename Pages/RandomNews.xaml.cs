using HotNews_UWP.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace HotNews_UWP.Pages {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class RandomNews : Page {

        public static string rdUrl;

        public ObservableCollection<RandomInfo> Data { get; set; }
        public RandomNews() {
            this.InitializeComponent();

            Data = new ObservableCollection<RandomInfo>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            await JsonManage.RandomDataManageAsync(Data);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e) {
            var selectUrl = (RandomInfo)e.ClickedItem;
            rdUrl = selectUrl.Url;
            this.Frame.Navigate(typeof(RdContent));
            
        }
    }
}
