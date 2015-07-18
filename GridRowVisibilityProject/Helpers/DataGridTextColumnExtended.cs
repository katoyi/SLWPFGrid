using System.Windows;
using System.Windows.Controls;

namespace GridRowVisibilityProject.Helpers
{
    public class DataGridTextColumnExtended : DataGridTextColumn
    {
        public static readonly DependencyProperty VisibiltyBindingProperty = DependencyProperty.Register(
            "VisibiltyBinding", typeof(Visibility), typeof(DataGridTextColumnExtended),
            new PropertyMetadata(OnVisibilityChanged));

        private static void OnVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((DataGridTextColumnExtended)d).Visibility = (Visibility)e.NewValue;
        }

        public Visibility VisibiltyBinding
        {
            get { return (Visibility)GetValue(VisibiltyBindingProperty); }
            set { SetValue(VisibiltyBindingProperty, value); }
        }
    }
}
