using System.Windows;

namespace GridRowVisibilityProject.Helpers
{
    public class DataContextProxy : DependencyObject
    {

        public static readonly DependencyProperty DataSoureceProperty =
                DependencyProperty.Register(
                "DataSource", typeof(object), typeof(DataContextProxy),
                new PropertyMetadata(new PropertyMetadata(null)));
        public object DataSource
        {
            get { return this.GetValue(DataSoureceProperty); }
            set { this.SetValue(DataSoureceProperty, value); }
        }

    }
}
