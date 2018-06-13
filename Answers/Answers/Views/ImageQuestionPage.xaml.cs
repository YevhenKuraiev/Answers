using Answers.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageQuestionPage : ContentPage
	{
		public ImageQuestionPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ImageQuestionViewModel();

        }
	}
}