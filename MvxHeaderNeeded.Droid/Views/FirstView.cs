using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Views;

namespace MvxHeaderNeeded.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var list = FindViewById<MvxListView>(global::Android.Resource.Id.List);

            // TODO Here We Add header that contains non-item info such a our avatar and summ of all accounts
            //var header = this.BindingInflate(Resource.Layout.list_header, null);
            //list.AddHeaderView(header);

            list.Adapter = new MvxAdapter(this, (IMvxAndroidBindingContext)BindingContext);
        }
    }
}