using MauiCalculator.Resources.Styles;

namespace MauiCalculator;

public partial class App : Application {

	public App() {
		InitializeComponent();

		Current.Resources.MergedDictionaries.Clear();
		Current.Resources.MergedDictionaries.Add(new Light());

		MainPage = new AppShell();
	}
}
