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
    public partial class IndexPage : MasterDetailPage
    {
        public IndexPage(string username)
        {
            InitializeComponent();

            textLabel.Text = $"Welcome, {username}";
        }

        async private void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}