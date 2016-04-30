using System.ComponentModel;

namespace Engine
{
    public class PlayerQuest : INotifyPropertyChanged
    {
        private Quest _details;
        private bool _isCompleted;

        public Quest Details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }

        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged("IsCompleted");
                OnPropertyChanged("Name");
            }
        }

        public string Name
        {
            get { return Details.Name; }
        }

        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
