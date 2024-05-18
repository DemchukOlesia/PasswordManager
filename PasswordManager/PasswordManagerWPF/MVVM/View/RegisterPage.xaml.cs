using System.Windows.Controls;
using PasswordManagerWPF.MVVM.ViewModel;

namespace PasswordManagerWPF.MVVM.View;

public partial class RegisterPage : Page
{
    public RegisterPage()
    {
        InitializeComponent();
        DataContext = new LoginRegistrationViewModel();
    }
}