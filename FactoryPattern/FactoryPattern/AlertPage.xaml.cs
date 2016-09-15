using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FactoryPattern
{
	public partial class AlertPage : ContentPage
	{
		public AlertPage ()
		{
			InitializeComponent ();
		}

        void btnShowMessage_Clicked(object sender, EventArgs e)
        {
            var alertService = AlertService.Create();
            bool result = alertService.Show("Titulo", "Mensaje", "si", "no");
        }
	}
}
