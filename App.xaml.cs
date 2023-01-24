using CommunityToolkit.Mvvm.Messaging;
using MauiCalculator.Messages;

namespace MauiCalculator;

public partial class App : Application {

	public App() {
		InitializeComponent();

		MainPage = new AppShell();

		WeakReferenceMessenger.Default.Register<ThemeChangedMessage>(this, (rec, mHnd) => {
			LoadTheme(mHnd.Value);
		});

		var theme = Preferences.Get("theme", "System");

		LoadTheme(theme);
	}

	private void LoadTheme(string theme) {
		if (!MainThread.IsMainThread) {
			MainThread.BeginInvokeOnMainThread(() => LoadTheme(theme));
			return;
		}

		if (theme == "System") {
			theme = Current.PlatformAppTheme.ToString();
		}

		ResourceDictionary dictionary = theme switch {
			"Light" => new Resources.Styles.Light(),
			"Dark" => new Resources.Styles.Dark(),
			_ => null
		};

		if (dictionary is not null) {
			Resources.MergedDictionaries.Clear();
			Resources.MergedDictionaries.Add(dictionary);
		}
	}
}
