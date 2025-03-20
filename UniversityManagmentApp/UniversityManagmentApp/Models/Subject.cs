using System.Collections.ObjectModel;
using System.ComponentModel;

namespace UniversityManagmentApp.Models;


public class Subject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int TeacherID { get; set; }
    public ObservableCollection<int> studentsEnrolled { get; set; }
}