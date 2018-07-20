using Answers.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestPage : ContentPage
	{
		public TestPage ()
		{
			InitializeComponent ();
		    this.BindingContext = new TestViewModel();
		}
	}
}