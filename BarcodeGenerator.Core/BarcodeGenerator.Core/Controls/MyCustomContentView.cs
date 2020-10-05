using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace BarcodeGenerator.Core.Controls
{
	public class MyCustomContentView : ContentView
	{
		public static readonly BindableProperty NowNameProperty = 
			BindableProperty.Create(nameof(NowName),
				typeof(string),
				typeof(MyCustomContentView),
				string.Empty,
				// ReSharper disable once IdentifierTypo
				propertyChanged:(bindable, value, newValue) =>
				{
					((MyCustomContentView) bindable).NowName = newValue;
				},
				defaultBindingMode:BindingMode.TwoWay);

		public object NowName
		{
			get => GetValue(NowNameProperty);
			set => SetValue(NowNameProperty, value);
		}
	}
}