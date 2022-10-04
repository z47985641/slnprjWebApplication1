﻿using prjWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjWebApplication1.ViewModel
{
    public class CActivityViewModel
    {
        private Activity _activity;
        public Activity activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
        public CActivityViewModel()
        {
            _activity = new Activity();
        }
        public int ActivityId
        {
            get { return _activity.ActivityId; }
            set { _activity.ActivityId = value; }
        }
        public string ActivityName
        {
            get { return _activity.ActivityName; }
            set { _activity.ActivityName = value; }
        }
        public DateTime? ActivityDate
        {
            get { return _activity.ActivityDate; }
            set { _activity.ActivityDate = value; }
        }
        public int? ActivityCapacity
        {
            get { return _activity.ActivityCapacity; }
            set { _activity.ActivityCapacity = value; }
        }
        public string ActivityStatus
        {
            get { return _activity.ActivityStatus; }
            set { _activity.ActivityStatus = value; }
        }
        public string ActivityInfo
        {
            get { return _activity.ActivityInfo; }
            set { _activity.ActivityInfo = value; }
        }        
    }
}
