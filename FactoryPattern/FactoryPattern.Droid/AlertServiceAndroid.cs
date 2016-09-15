using Android.App;

namespace FactoryPattern.Droid
{
    public class AlertServiceAndroid : AlertService
    {
        public override bool Show(string title, string message, string yesButton, string noButton)
        {
            bool result = false;

            new AlertDialog.Builder(Xamarin.Forms.Forms.Context as MainActivity)
                .SetTitle(title)
                .SetMessage(message)
                .SetPositiveButton(yesButton, delegate { result = true; })
                .SetNegativeButton(noButton, delegate { result = false; })
                .Show();

            return result;
        }
    }
}