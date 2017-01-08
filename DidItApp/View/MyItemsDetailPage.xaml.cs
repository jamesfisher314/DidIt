using DidItApp.Model;
using DidItApp.ViewModel;

using Xamarin.Forms;

namespace DidItApp.View
{
    public partial class MyItemsDetailPage : ContentPage
    {
        MyItemsDetailViewModel viewModel;
        public MyItemsDetailPage(MyItemsDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;

            this.viewModel.OnFinished += OnFinished;
        }

        async void OnFinished(Item item)
        {
            viewModel.OnFinished -= OnFinished;
            await Navigation.PopAsync();
        }
    }
}
