using Answers.ViewModels;
using Xamarin.Forms;

namespace Answers.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    this.BindingContext = new MainViewModel();

		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var element = e.SelectedItem;
        }
    }
}
