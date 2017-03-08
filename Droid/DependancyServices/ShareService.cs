using Android.App;
using Android.Content;
using Xamarin.Forms;
using SocialApp.Droid;

[assembly: Dependency(typeof(ShareService))]
namespace SocialApp.Droid
{
	public class ShareService : IShareService
	{
		public void SharePageLink(string url)
		{
			var context = Forms.Context;
			Activity activity = context as Activity;

			Intent share = new Intent(Intent.ActionSend);
			share.SetType("text/plain");
			share.AddFlags(ActivityFlags.ClearWhenTaskReset);
			share.PutExtra(Intent.ExtraSubject, "Brusselslife");
			share.PutExtra(Intent.ExtraText, url);

			activity.StartActivity(Intent.CreateChooser(share, "Share link!"));
		}
	}
}
