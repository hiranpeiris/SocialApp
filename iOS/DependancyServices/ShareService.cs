using Foundation;
using UIKit;
using Xamarin.Forms;
using SocialApp.iOS;

[assembly: Dependency(typeof(ShareService))]
namespace SocialApp.iOS
{
	public class ShareService : IShareService
	{
		public void SharePageLink(string url)
		{
			var window = UIApplication.SharedApplication.KeyWindow;
			var rootViewController = window.RootViewController;

			var activityViewController = new UIActivityViewController(new NSString[] { new NSString(url) }, null);
			activityViewController.ExcludedActivityTypes = new NSString[] {
				UIActivityType.AirDrop,
				UIActivityType.Print,
				UIActivityType.Message,
				UIActivityType.AssignToContact,
				UIActivityType.SaveToCameraRoll,
				UIActivityType.AddToReadingList,
				UIActivityType.PostToFlickr,
				UIActivityType.PostToVimeo,
				UIActivityType.PostToTencentWeibo,
				UIActivityType.PostToWeibo
			};

			rootViewController.PresentViewController(activityViewController, true, null);
		}
	}
}
