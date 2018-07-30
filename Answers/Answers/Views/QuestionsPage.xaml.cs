using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Threading.Tasks;
using Answers.Models;
using Answers.ViewModels;
using Answers.DbInitilizers;

namespace Answers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionsPage : ContentPage
	{
		public QuestionsPage ()
		{
            InitializeComponent();
            this.BindingContext = new QuestionsViewModel(new Initializer().GetInitizlizedList());
        }

	    protected override async void OnAppearing()
	    {
	        base.OnAppearing();
	        await Task.Delay(1500);
            FindEntry.Focus();
        }

	    private void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
	    {
	        var items = MainListView.ItemsSource as ObservableCollection<QuestionModel>;
	        var currentIdx = items?.IndexOf((QuestionModel) e.Item);
	        ImageArrow.IsVisible = currentIdx > 20;
	        if (currentIdx > 15)
	        {
	            FindEntry.Unfocus();
            }
        }

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        var items = MainListView.ItemsSource as ObservableCollection<QuestionModel>;
	        MainListView.ScrollTo(items?.First(), ScrollToPosition.End, true);
	    }

	    private void ImageTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
            FindEntry.Unfocus();
            FindEntry.Text = string.Empty;
            FindEntry.Focus();
	    }
	}
}