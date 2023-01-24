using MauiCalculator.Resources.Styles;

namespace MauiCalculator.Shared;

public partial class ThemeSwitcher : ContentView {

	public ThemeSwitcher() {
		InitializeComponent();

		lightBtn.Clicked += (object s, EventArgs e) => ToggleTheme("Light");
		darkBtn.Clicked += (object s, EventArgs e) => ToggleTheme("Dark");
	}

	private static void ToggleTheme(string theme) {
		var mergedDicts = Application.Current.Resources.MergedDictionaries;

		if (mergedDicts is not null) {
			mergedDicts.Clear();

			if (theme == "Light") {
				mergedDicts.Add(new Light());
			}
			else {
				mergedDicts.Add(new Dark());
			}
		}
	}
}
