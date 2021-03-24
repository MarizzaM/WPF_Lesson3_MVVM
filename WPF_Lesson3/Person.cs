using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lesson3
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string m_name;

        private int m_age;
        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
                NotifyPropertyChanged("Age");
            }
        }

        // Add Age property + PropertyChanged

        // add function that is doing :
        // NotifyPropertyChanged(string property_name)
        // if (PropertyChanged != null)
        // {
        //PropertyChanged(this, new PropertyChangedEventArgs("Name"));
        //}
        // call this function from Age + Name set property

        public void NotifyPropertyChanged(string property_name) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property_name));
            }
        }
        public override string ToString()
        {
            return $"Person {Name} {Age}";
        }
    }

}
