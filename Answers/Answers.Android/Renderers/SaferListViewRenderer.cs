using Android.Content;
using Android.Views.InputMethods;
using Android.Widget;
using Answers.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ListView), typeof(SaferListViewRenderer))]
namespace Answers.Droid.Renderers
{
    public class SaferListViewRenderer : ListViewRenderer
    {
        public SaferListViewRenderer(Context context) : base(context)
        {
                
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if (this.Control == null) return;
            this.Control.Recycler -= ClearViewFocus;
            this.Control.Recycler += ClearViewFocus;
        }

        private void ClearViewFocus(object sender, AbsListView.RecyclerEventArgs args)
        {
            if (!args.View.HasFocus) return;
            args.View.ClearFocus();
            var manager = (InputMethodManager)args.View.Context.GetSystemService(Context.InputMethodService);
            manager?.HideSoftInputFromWindow(args.View.WindowToken, 0);
        }
    }
}