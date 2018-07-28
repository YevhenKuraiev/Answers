using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using Answers.Models;

namespace Answers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionsPage : ContentPage
	{
		public QuestionsPage ()
		{
            InitializeComponent();
        }

	    private void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
	    {
	        var items = ListView.ItemsSource as ObservableCollection<QuestionModel>;
	        var currentIdx = items?.IndexOf((QuestionModel) e.Item);
	        ImageArrow.IsVisible = currentIdx > 6;
	    }

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        var items = ListView.ItemsSource as ObservableCollection<QuestionModel>;
	        ListView.ScrollTo(items?.First(), ScrollToPosition.End, true);
	    }

	}
}