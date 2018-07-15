using Answers.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageQuestionsPage : ContentPage
	{
		public ImageQuestionsPage ()
		{
			InitializeComponent();
            this.BindingContext = new ImageQuestionsViewModel();

        }
	}
}