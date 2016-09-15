using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace FactoryPattern.UWP
{
    public class AlertServiceUWP : AlertService
    {
        public override bool Show(string title, string message, string yesButton, string noButton)
        {
            return Task.Run(() => ShowAsync(title, message, yesButton, noButton)).Result;
        }

        private async Task<bool> ShowAsync(string title, string message, string yesButton, string noButton)
        {
            var md = new MessageDialog(message, title);
            md.Commands.Add(new UICommand(yesButton));
            md.Commands.Add(new UICommand(noButton));

            var result = await md.ShowAsync();
            return (result.Label == yesButton);
        }
    }
}
