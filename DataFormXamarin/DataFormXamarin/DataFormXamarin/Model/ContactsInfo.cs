using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Syncfusion.XForms.DataForm;

namespace DataFormXamarin
{
    public class ContactsInfo : INotifyPropertyChanged
    {
        private string lastName;
        private string firstName;
        private string city;
        public ContactsInfo()
        {

        }
        public String FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
                RaiseOnPropertyChanged("FirstName");
            }
        }
        public String LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
                RaiseOnPropertyChanged("LastName");
            }
        }
        public string City
        {
            get { return this.city; }
            set
            {
                this.city = value;
                RaiseOnPropertyChanged("City");
            }
        }
        /// <summary>
        /// Occurs when property changed.
        /// </summary>
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
