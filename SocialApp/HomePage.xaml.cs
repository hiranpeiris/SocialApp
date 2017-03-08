using System;
using Xamarin.Forms;

namespace SocialApp
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void OnShare(object sender, EventArgs e)
		{
			string shareLink = "http://hiranpeiris.com";
			DependencyService.Get<IShareService>().SharePageLink(shareLink);
		}
	}
}
