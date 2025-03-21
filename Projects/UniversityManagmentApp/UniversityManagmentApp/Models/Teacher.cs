using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UniversityManagmentApp.Models
{
    public class Teacher : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _id { get; set; }
        private string _name { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }
        private List<int> _subjects { get; set; }

        public Teacher(int id, string name, string username, string password, List<int> subjects)
        {
            _id = id;
            _name = name;
            _username = username;
            _password = password;
            _subjects = subjects;
        }





    }
}