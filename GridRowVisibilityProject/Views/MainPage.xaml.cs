using System.Windows.Controls;
using GridRowVisibilityProject.ViewModels;

namespace GridRowVisibilityProject.Views
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new AppSampleViewModel();
        }
    }
}
