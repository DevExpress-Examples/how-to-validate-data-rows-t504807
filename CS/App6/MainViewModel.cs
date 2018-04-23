using DevExpress.Mvvm;
using System;
using System.Collections.Generic;

namespace App6
{
    public class MainViewModel
    {
        protected List<Task> _Tasks;

        public List<Task> Tasks
        {
            get
            {
                if (this._Tasks == null)
                {
                    this._Tasks = new List<Task>();
                    Random r = new Random();
                    int i = 0;
                    while (++i < 10)
                    {
                        this._Tasks.Add(new Task() {
                            TaskName = "Task #" + i,
                            StartDate = DateTime.Today.AddDays(r.Next(4)), 
                            EndDate = DateTime.Today.AddDays(r.Next(10) + 4)
                        });
                    }
                }
                return _Tasks;
            }
        }
       
    }
    public class Task : BindableBase
    {

        protected string _TaskName;
        public string TaskName
        {
            get { return this._TaskName; }
            set { this.SetProperty(ref this._TaskName, value, "TaskName"); }
        }


        protected DateTime _StartDate;
        public DateTime StartDate
        {
            get { return this._StartDate; }
            set { this.SetProperty(ref this._StartDate, value, "StartDate"); }
        }


        protected DateTime _EndDate;
        public DateTime EndDate
        {
            get { return this._EndDate; }
            set { this.SetProperty(ref this._EndDate, value, "EndDate"); }
        }
    }

}
