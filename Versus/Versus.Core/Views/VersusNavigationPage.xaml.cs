using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Versus.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VersusNavigationPage : NavigationPage
    {
        public VersusNavigationPage()
        {
            InitializeComponent();
        }

        public VersusNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}