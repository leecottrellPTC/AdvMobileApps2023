using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MvvmSourceGeneratorPractice.Models
{
    public partial class UserName : ObservableObject
    {
        [ObservableProperty]
        string firstName;

        [ObservableProperty]
        string lastName;

        [ObservableProperty]
        [NotifyPropertyChangedFor("Password")]
        string loginName;

        public string Password => "Your Secure Password";

        [RelayCommand]
        void buildUserName()
        {
            App.Current.MainPage.DisplayAlert("Build User Name", "Method fires", "Awesome");
            LoginName = FirstName.Substring(0, 1) + LastName;
        }
    }
}
