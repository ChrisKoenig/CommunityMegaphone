//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.431
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name: CommunityMegaphone.cs
// Generation date: 3/17/2011 5:01:41 PM
namespace CommunityMegaphone.Models
{
    /// <summary>
    /// There are no comments for CMEventsEntities in the schema.
    /// </summary>
    public partial class CMEventsEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new CMEventsEntities object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public CMEventsEntities(global::System.Uri serviceRoot) :

            base(serviceRoot)
        {
            this.OnContextCreated();
        }

        partial void OnContextCreated();

        /// <summary>
        /// There are no comments for ApprovedEvents in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToApprovedEvents(ApprovedEvents approvedEvents)
        {
            base.AddObject("ApprovedEvents", approvedEvents);
        }
    }

    /// <summary>
    /// There are no comments for CMEventsModel.ApprovedEvents in the schema.
    /// </summary>
    /// <KeyProperties>
    /// audienceid
    /// id
    /// pubdate
    /// starttime
    /// timezoneid
    /// title
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("ApprovedEvents")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("audienceid", "id", "pubdate", "starttime", "timezoneid", "title")]
    public partial class ApprovedEvents : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ApprovedEvents object.
        /// </summary>
        /// <param name="audienceid">Initial value of audienceid.</param>
        /// <param name="ID">Initial value of id.</param>
        /// <param name="pubdate">Initial value of pubdate.</param>
        /// <param name="starttime">Initial value of starttime.</param>
        /// <param name="timezoneid">Initial value of timezoneid.</param>
        /// <param name="title">Initial value of title.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ApprovedEvents CreateApprovedEvents(string audienceid, int ID, global::System.DateTime pubdate, global::System.DateTime starttime, string timezoneid, string title)
        {
            ApprovedEvents approvedEvents = new ApprovedEvents();
            approvedEvents.audienceid = audienceid;
            approvedEvents.id = ID;
            approvedEvents.pubdate = pubdate;
            approvedEvents.starttime = starttime;
            approvedEvents.timezoneid = timezoneid;
            approvedEvents.title = title;
            return approvedEvents;
        }

        /// <summary>
        /// There are no comments for Property address in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string address
        {
            get
            {
                return this._address;
            }
            set
            {
                this.OnaddressChanging(value);
                this._address = value;
                this.OnaddressChanged();
                this.OnPropertyChanged("address");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _address;

        partial void OnaddressChanging(string value);

        partial void OnaddressChanged();

        /// <summary>
        /// There are no comments for Property audienceid in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string audienceid
        {
            get
            {
                return this._audienceid;
            }
            set
            {
                this.OnaudienceidChanging(value);
                this._audienceid = value;
                this.OnaudienceidChanged();
                this.OnPropertyChanged("audienceid");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _audienceid;

        partial void OnaudienceidChanging(string value);

        partial void OnaudienceidChanged();

        /// <summary>
        /// There are no comments for Property city in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                this.OncityChanging(value);
                this._city = value;
                this.OncityChanged();
                this.OnPropertyChanged("city");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _city;

        partial void OncityChanging(string value);

        partial void OncityChanged();

        /// <summary>
        /// There are no comments for Property description in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                this.OndescriptionChanging(value);
                this._description = value;
                this.OndescriptionChanged();
                this.OnPropertyChanged("description");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _description;

        partial void OndescriptionChanging(string value);

        partial void OndescriptionChanged();

        /// <summary>
        /// There are no comments for Property endtime in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<global::System.DateTime> endtime
        {
            get
            {
                return this._endtime;
            }
            set
            {
                this.OnendtimeChanging(value);
                this._endtime = value;
                this.OnendtimeChanged();
                this.OnPropertyChanged("endtime");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<global::System.DateTime> _endtime;

        partial void OnendtimeChanging(global::System.Nullable<global::System.DateTime> value);

        partial void OnendtimeChanged();

        /// <summary>
        /// There are no comments for Property eventtype in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string eventtype
        {
            get
            {
                return this._eventtype;
            }
            set
            {
                this.OneventtypeChanging(value);
                this._eventtype = value;
                this.OneventtypeChanged();
                this.OnPropertyChanged("eventtype");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _eventtype;

        partial void OneventtypeChanging(string value);

        partial void OneventtypeChanged();

        /// <summary>
        /// There are no comments for Property id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.OnidChanging(value);
                this._id = value;
                this.OnidChanged();
                this.OnPropertyChanged("id");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _id;

        partial void OnidChanging(int value);

        partial void OnidChanged();

        /// <summary>
        /// There are no comments for Property latlong in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string latlong
        {
            get
            {
                return this._latlong;
            }
            set
            {
                this.OnlatlongChanging(value);
                this._latlong = value;
                this.OnlatlongChanged();
                this.OnPropertyChanged("latlong");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _latlong;

        partial void OnlatlongChanging(string value);

        partial void OnlatlongChanged();

        /// <summary>
        /// There are no comments for Property pubdate in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime pubdate
        {
            get
            {
                return this._pubdate;
            }
            set
            {
                this.OnpubdateChanging(value);
                this._pubdate = value;
                this.OnpubdateChanged();
                this.OnPropertyChanged("pubdate");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _pubdate;

        partial void OnpubdateChanging(global::System.DateTime value);

        partial void OnpubdateChanged();

        /// <summary>
        /// There are no comments for Property starttime in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime starttime
        {
            get
            {
                return this._starttime;
            }
            set
            {
                this.OnstarttimeChanging(value);
                this._starttime = value;
                this.OnstarttimeChanged();
                this.OnPropertyChanged("starttime");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _starttime;

        partial void OnstarttimeChanging(global::System.DateTime value);

        partial void OnstarttimeChanged();

        /// <summary>
        /// There are no comments for Property state in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                this.OnstateChanging(value);
                this._state = value;
                this.OnstateChanged();
                this.OnPropertyChanged("state");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _state;

        partial void OnstateChanging(string value);

        partial void OnstateChanged();

        /// <summary>
        /// There are no comments for Property timezoneid in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string timezoneid
        {
            get
            {
                return this._timezoneid;
            }
            set
            {
                this.OntimezoneidChanging(value);
                this._timezoneid = value;
                this.OntimezoneidChanged();
                this.OnPropertyChanged("timezoneid");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _timezoneid;

        partial void OntimezoneidChanging(string value);

        partial void OntimezoneidChanged();

        /// <summary>
        /// There are no comments for Property title in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string title
        {
            get
            {
                return this._title;
            }
            set
            {
                this.OntitleChanging(value);
                this._title = value;
                this.OntitleChanged();
                this.OnPropertyChanged("title");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _title;

        partial void OntitleChanging(string value);

        partial void OntitleChanged();

        /// <summary>
        /// There are no comments for Property zip in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                this.OnzipChanging(value);
                this._zip = value;
                this.OnzipChanged();
                this.OnPropertyChanged("zip");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _zip;

        partial void OnzipChanging(string value);

        partial void OnzipChanged();

        /// <summary>
        /// There are no comments for Property eventUrl in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string eventUrl
        {
            get
            {
                return this._eventUrl;
            }
            set
            {
                this.OneventUrlChanging(value);
                this._eventUrl = value;
                this.OneventUrlChanged();
                this.OnPropertyChanged("eventUrl");
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _eventUrl;

        partial void OneventUrlChanging(string value);

        partial void OneventUrlChanged();

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}