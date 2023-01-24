using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiCalculator.Messages;

class ThemeChangedMessage : ValueChangedMessage<string> {
	public ThemeChangedMessage(string value) : base(value) {}
}
