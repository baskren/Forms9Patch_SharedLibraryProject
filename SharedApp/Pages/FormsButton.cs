using System;

using Xamarin.Forms;

namespace SharedApp
{
	public class FormsButton : ContentPage
	{
		public FormsButton ()
		{
			Content = new StackLayout { 
				Children = {
					new Button() {
						Text = "Pizza",
						Image = Forms9Patch.ImageSource.FromResource ("SharedApp.Resources.ArrowR"),
					}
				}
			};
		}
	}
}


