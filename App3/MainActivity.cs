using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace App3
{
    [Activity(Label = "App3", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainActivity);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            EditText textbox1 = FindViewById<EditText>(Resource.Id.autoCompleteTextView1);


            button1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SubActivity));
                intent.PutExtra("string", textbox1.Text);

                this.StartActivity(intent);
            };
        }
    }
}

