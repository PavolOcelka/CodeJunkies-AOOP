using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace UniversityManagmentApp.Models;

public class Student : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<int> EnrolledSubjects { get; set; }
}