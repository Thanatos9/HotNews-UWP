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
    public sealed partial class AllNews : Page {

        public ObservableCollection<Datum> allData { get; set; }
        public int id = 7;
        public static string myUrl;
        public AllNews() {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

            allData = new ObservableCollection<Datum>();
            
        }

        private async void Zhihu_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 1;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e) {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e) {
            var selectUrl = (Datum)e.ClickedItem;
            myUrl = selectUrl.Url;
            this.Frame.Navigate(typeof(AllContent));
        }

        private async void Douyin_Click(object sender, RoutedEventArgs e) {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 148;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void WeiBoHot_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 58;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void DouBan_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 57;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void HuPu_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 2;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void NGA_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 106;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void ItHome_Click(object sender, RoutedEventArgs e) {

            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 112;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void WeChat_Click(object sender, RoutedEventArgs e) {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 11;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }

        private async void GuanChaZhe_Click(object sender, RoutedEventArgs e) {
            MyProgressRing.IsActive = true;
            MyProgressRing.Visibility = Visibility.Visible;

            id = 123;
            allData.Clear();

            await JsonManage.AllDataManageAsync(allData, id);

            MyProgressRing.IsActive = false;
            MyProgressRing.Visibility = Visibility.Collapsed;
        }
    }
}
