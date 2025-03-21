using System.Collections.Generic;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia;
using Avalonia.Interactivity; 
using UniversityManagmentApp.Views;
using UniversityManagmentApp.Models;

namespace UniversityManagmentApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private UserControl _currentView;
    [ObservableProperty]
    private bool isPaneOpen = false;

    public MainWindowViewModel()
    {
        CurrentView = _loginView;
    }

    private LoginView _loginView = new LoginView{DataContext=new LoginViewModel()};
    private StudentView _studentView = new StudentView{DataContext=new StudentViewModel()};
    private TeacherView _teacherView = new TeacherView{DataContext=new TeacherViewModel()};

    private Teacher _teacher = new Teacher(1, "John Doe", "teacher", "teacher", new List<int> {1, 2, 3});

    [RelayCommand]
    public void NavigateToLoginView()
    {
        CurrentView = _loginView;
    }

    [RelayCommand]
    public void NavigateToStudentView()
    {
        CurrentView = _studentView;


    }
    [RelayCommand]
    public void NavigateToTeacherView()
    {
        CurrentView = _teacherView;
        IsPaneOpen = false;
    }

//
    [RelayCommand]
    public void Login()
    {
    
        if (CurrentView == _loginView)
        
        {
            NavigateToStudentView();
            /*
            if (Username == _teacher.Username && Password == _teacher.Password)
            {
                NavigateToTeacherView();
            }
            else if (Username == _student.Username && Password == _student.Password)
            {
                NavigateToStudentView();
            } */
            
        }
    }
    
}