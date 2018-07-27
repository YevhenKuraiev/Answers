using Answers.DbInitilizers;
using Answers.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Answers.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            var tabPage = this.FindByName<MainPage>("MainTabPage");
            var initializer = new Initializer();
            tabPage.Children.Add(GetPage(initializer, "Основы ПО", Initializer.SubjectTypes.FundamentalSE));
            //tabPage.Children.Add(GetPage(initializer, "БД", Initializer.SubjectTypes.DataBases));
            tabPage.Children.Add(GetPage(initializer, "Архитектура ПО", Initializer.SubjectTypes.ArchitectureSE));
        }


        private Page GetPage(Initializer initizlizer, string pageName, Initializer.SubjectTypes subjectType)
        {
            var page = new QuestionsPage { Title = pageName };
            var viewModel = new QuestionsViewModel(initizlizer.GetInitizlizedList(subjectType));
            page.BindingContext = viewModel;
            return page;
        }
    }
}