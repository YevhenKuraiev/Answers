using Answers.ViewModels;
using Xamarin.Forms;

namespace Answers.Views
{
	public partial class TextQuestionsPage : ContentPage
	{
		public TextQuestionsPage()
		{
			InitializeComponent();
		    this.BindingContext = new TextQuestionsViewModel();
		}
    }
}
