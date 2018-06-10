using Xamarin.Forms;

namespace Answers.CustomControls
{
    public class StatusIndicator : View
    {
        public static readonly BindableProperty IsOpenedProperty =
            BindableProperty.Create("IsOpened", typeof(bool), typeof(StatusIndicator), false, BindingMode.TwoWay);

        public bool IsOpened
        {
            get => (bool)GetValue(IsOpenedProperty);
            set => SetValue(IsOpenedProperty, value);
        }


        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(StatusIndicator), string.Empty, BindingMode.TwoWay);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

    }
}
