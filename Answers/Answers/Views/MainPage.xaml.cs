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
            tabPage.Children.Add(GetPage(new FundamentalSoftEngineeringInitializer(), "Основы ПО"));
            tabPage.Children.Add(GetPage(new DataBasesSubjectInitializer(), "БД"));
            tabPage.Children.Add(GetPage(new ArchitectureAndSoftDesignInitializer(), "Архитектура ПО"));
        }


        private Page GetPage(IInitizlizer initizlizer, string pageName)
        {
            var page = new QuestionsPage { Title = pageName };
            var viewModel = new QuestionsViewModel(initizlizer.GetInitizlizedList());
            page.BindingContext = viewModel;
            return page;
        }
    }
}