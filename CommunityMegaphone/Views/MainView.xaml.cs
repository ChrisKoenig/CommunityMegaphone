using System;
using CommunityMegaphone.Messages;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Phone.Controls;

namespace CommunityMegaphone.Views
{
    public partial class MainView : PhoneApplicationPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Messenger.Default.Send<RefreshEventListMessage>(new RefreshEventListMessage());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AboutPage.xaml", UriKind.Relative));
        }
    }
}