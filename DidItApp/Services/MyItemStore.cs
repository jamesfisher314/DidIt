using DidItApp.Interfaces;
using DidItApp.Model;
using DidItApp.Services.Standard;
using Xamarin.Forms;

[assembly: Dependency(typeof(MyItemStore))]
namespace DidItApp.Services.Standard
{
    public class MyItemStore : BaseStore<MyItem>, IMyItemStore
    {
        public override string Identifier => "MyItem";
    }
}
