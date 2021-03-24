using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lesson3
{
    public class MainWindowViewModel
    {
        public Person MyPerson { get; set; }

        public MainWindowViewModel()
        {
            MyPerson = new Person { Name = "Danny", Age = 44 };
        }

        public void ChangePersonNameAndAge(string newName, int newAge)
        {
            MyPerson.Name = newName;
            MyPerson.Age = newAge;
            // also age = age + 1
        }
    }

}
