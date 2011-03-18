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
    }
}