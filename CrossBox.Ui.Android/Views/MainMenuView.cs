using Android.App;
using Cirrious.MvvmCross.Binding.Android.Views;
using CrossBox.Core.ViewModels;

namespace CrossBox.Ui.Android.Views
{
    [Activity]
    public class MainMenuView : MvxBindingActivityView<MainMenuViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_MainMenuView);
        }
    }
}