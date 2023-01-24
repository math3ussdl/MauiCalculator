namespace MauiCalculator;

public partial class App : Application {
	public App() {
		InitializeComponent();
		MainPage = new AppShell();

		ResourceDictionary = new();

		foreach (var dict in Application.Current.Resources.MergedDictionaries) {
			string key = dict.Source.OriginalString
				.Split(';')
				.First()
				.Split('/')
				.Last()
				.Split('.')
				.First();

			ResourceDictionary.Add(key, dict);
		}
	}

	public static Dictionary<string, ResourceDictionary> ResourceDictionary { get; private set; }
}
