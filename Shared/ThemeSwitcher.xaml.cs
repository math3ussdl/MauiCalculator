namespace MauiCalculator.Shared;

public partial class ThemeSwitcher : ContentView {

	public ContentPage Page;

	public string Theme = "Light";

	public ThemeSwitcher() {
		InitializeComponent();

		lightBtn.BackgroundColor = Color.FromRgba(255, 255, 255, 0.5);

		lightBtn.Clicked += (object s, EventArgs e) => ToggleTheme("Light");
		darkBtn.Clicked += (object s, EventArgs e) => ToggleTheme("Dark");
	}

	private void ToggleTheme(string theme) {
		Theme = theme;

		if (theme == "Light") {
			Page.BackgroundColor = (Color)App.ResourceDictionary["Colors"]["Background"];
			themeSwitcher.BackgroundColor = (Color)App.ResourceDictionary["Colors"]["ThemeSwitcherColor"];

			lightBtn.BackgroundColor = Color.FromRgba(255, 255, 255, 0.5);
			darkBtn.BackgroundColor = Colors.Transparent;
		} else {
			Page.BackgroundColor = (Color)App.ResourceDictionary["Colors"]["BackgroundDark"];
			themeSwitcher.BackgroundColor = (Color)App.ResourceDictionary["Colors"]["ThemeSwitcherColorDark"];

			darkBtn.BackgroundColor = Color.FromRgba(255, 255, 255, 0.5);
			lightBtn.BackgroundColor = Colors.Transparent;
		}
	}
}