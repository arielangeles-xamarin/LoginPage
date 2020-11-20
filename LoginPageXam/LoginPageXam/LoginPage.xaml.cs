using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPageXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : TabbedPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async private void SignInButtonClicked(object sender, EventArgs e)
        {
            if (password.Text == confirmPassword.Text || !string.IsNullOrEmpty(username.Text))
            {
                await Navigation.PushModalAsync(new IndexPage(username.Text));
            }
            else
            {
                if (string.IsNullOrEmpty(username.Text))
                {
                    await DisplayAlert("Invalid username", "Insert a valid username, please", "Ok");
                }
                else
                {
                    await DisplayAlert("Invalid password", "Passwords are not the same", "Ok");
                }

            }

        }
    }
}