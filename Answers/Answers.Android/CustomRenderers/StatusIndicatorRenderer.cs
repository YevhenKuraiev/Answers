using System.ComponentModel;
using Android.Content;
using Answers.CustomControls;
using Answers.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly: ExportRenderer(typeof(StatusIndicator), typeof(StatusIndicatorRenderer))]
namespace Answers.Droid.CustomRenderers
{
    public class StatusIndicatorRenderer : ViewRenderer<StatusIndicator, View>
    {
        public StatusIndicatorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (sender is StatusIndicator element)
            {
                element.Text = element.IsOpened ? "▲" : "▼";
            }
            Invalidate();
        }
    }
}