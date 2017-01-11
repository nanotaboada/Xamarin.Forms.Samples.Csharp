using Xamarin.Forms;

namespace Xamarin.Forms.Samples.Csharp
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			Content = new StackLayout()
			{
				Spacing = 20,
				Padding = 20,
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Image { Source = "codevel-512.png" },
					new Entry { Placeholder = "Enter your email" },
					new Entry { Placeholder = "Password", IsPassword = true },
					new Button { Text = "Login", TextColor = Color.White, BackgroundColor = Color.FromHex("#377EB8") }
				}
			};
		}
	}
}
