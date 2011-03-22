using System;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using CommunityMegaphone.Messages;
using CommunityMegaphone.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Threading;

namespace CommunityMegaphone.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private const string STR_HttpcommunitymegaphonecomwsCMEventDSsvc = "http://communitymegaphone.com/ws/CMEventDS.svc";
        CMEventsEntities context = new CMEventsEntities(new Uri(STR_HttpcommunitymegaphonecomwsCMEventDSsvc, UriKind.Absolute));

        public MainViewModel()
        {
            MessengerInstance.Register<RefreshEventListMessage>(this, (message) => RunQuery());
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                Events = new DataServiceCollection<ApprovedEvents>(context);
                RunQuery();
            }
        }

        private void RunQuery()
        {
            IsBusy = true;
            Uri queryUri = new Uri("/ApprovedEvents?$filter=state eq 'TX'&$orderby=starttime", UriKind.Relative);
            Events.Clear();
            Events.LoadCompleted += Events_LoadCompleted;
            Events.LoadAsync(queryUri);
        }

        private void Events_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
            Events.LoadCompleted -= Events_LoadCompleted;
            DispatcherHelper.CheckBeginInvokeOnUI(() => IsBusy = false);
        }

        #region IsBusy property

        public const string IsBusyPropertyName = "IsBusy";

        private bool _isBusy = false;

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                if (_isBusy == value)
                {
                    return;
                }

                var oldValue = _isBusy;
                _isBusy = value;
                RaisePropertyChanged(IsBusyPropertyName);
            }
        }

        #endregion IsBusy property

        #region Events property

        public const string EventsPropertyName = "Events";

        private DataServiceCollection<ApprovedEvents> _events = new DataServiceCollection<Models.ApprovedEvents>();

        public DataServiceCollection<ApprovedEvents> Events
        {
            get
            {
                return _events;
            }

            set
            {
                if (_events == value)
                {
                    return;
                }
                var oldValue = _events;
                _events = value;
                RaisePropertyChanged(EventsPropertyName);
            }
        }

        #endregion Events property

        public ObservableCollection<ApprovedEvents> EventsOC
        {
            get
            {
                return _events as ObservableCollection<ApprovedEvents>;
            }
        }

        #region SelectedEvent property

        public const string SelectedEventPropertyName = "SelectedEvent";

        private ApprovedEvents _selectedEvent = null;

        public ApprovedEvents SelectedEvent
        {
            get
            {
                return _selectedEvent;
            }

            set
            {
                if (_selectedEvent == value)
                {
                    return;
                }

                var oldValue = _selectedEvent;
                _selectedEvent = value;
                RaisePropertyChanged(SelectedEventPropertyName, oldValue, value, true);
            }
        }

        #endregion SelectedEvent property
    }
}