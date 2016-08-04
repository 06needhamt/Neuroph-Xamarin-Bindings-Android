using Android.App;
using Android.Widget;
using Android.OS;

namespace TestApp
{
	[Activity(Label = "TestApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.Main);

			Button button = FindViewById<Button>(Resource.Id.myButton);

			TextView tv = FindViewById<TextView>(Resource.Id.txtResult);

			button.Click += delegate {
				tv.SetText("Training Network...",TextView.BufferType.Normal);
				ExampleNetwork network = new ExampleNetwork(BaseContext.Assets,BaseContext.FilesDir);
				network.TrainNetwork();
				tv.SetText("Loading Network...", TextView.BufferType.Normal);
				network.LoadNetwork();
				tv.SetText("Testing Network...", TextView.BufferType.Normal);
				network.TestNetwork();
				tv.SetText(network.Results, TextView.BufferType.Normal);
			};



		}
	}
}


