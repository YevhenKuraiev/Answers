using Answers.ViewModels;
using Xamarin.Forms;

namespace Answers.Views
{
	public partial class TextQuestionPage : ContentPage
	{
		public TextQuestionPage()
		{
			InitializeComponent();
		    this.BindingContext = new TextQuestionPageViewModel();
		}
    }
}
