using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormViewModel : INotifyPropertyChanged
    {
        private ContactsInfo contactsInfo;
        public ContactsInfo ContactsInfo
        {
            get { return this.contactsInfo; }
            set { 
                this.contactsInfo = value;
                RaiseOnPropertyChanged("ContactsInfo");
            }
        }
        public DataFormViewModel()
        {
            this.contactsInfo = new ContactsInfo();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Invoke method when property changed.
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
