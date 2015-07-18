using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using GridRowVisibilityProject.Model;

namespace GridRowVisibilityProject.ViewModels
{
    public class AppSampleViewModel : INotifyPropertyChanged
    {
        #region Fields

        private List<Person> _dataList;
        private List<Person> _dataListModified;

        #endregion

        #region Properties

        public List<Person> DataList
        {
            get { return _dataList; }
            set
            {
                _dataList = value;
                OnPropertyChanged("DataList");
            }
        }


        public List<Person> DataListModified
        {
            get { return _dataListModified; }
            set
            {
                _dataListModified = value;
                OnPropertyChanged("DataListModified");
            }
        }

        #endregion

        #region Methods
        public AppSampleViewModel()
        {
            this.Fill();
            this.FillModified();
        }

        private IEnumerable<Person> FillAllRow(bool hoobiesEmpty = false)
        {
            var names = new[]
            {
                "Casus Kleen","Roger Federer","Cristiano Ronaldo","Leonel Messi",
                "Diego Armando","Pape Diouf","Ancelonetin Real","Drogba Didier",
                "Sheyi Adebayor","Usain Bolt"
            };
            var hobbies = new[]
            {
                "Runing,Cycling","Cooking,Drying","Travelling,Tasting"
            };
            var professions = new[]
            {
                "Boxer","Tenisman","Footballer","Footballer","Coach","Coach","Coach",
                "Footballer","FootBaller","Sprinter"
            };
            var phones = new[]
            {
                "0123456789",
                "0678909873"
            };
            for (int i = 0; i < 10; i++)
            {
                yield return new Person()
                {
                    Name = names[i],
                    Id = i + 1,
                    Profession = professions[i],
                    Hobbies = hoobiesEmpty ? null : hobbies[i % 3],
                    Phone = i % 2 == 0 ? phones[i % 2] : null
                };
            }
        }

        private void Fill()
        {
            this.DataList = FillAllRow().ToList();
        }

        private void FillModified()
        {
            this.DataListModified = FillAllRow(true).ToList();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}