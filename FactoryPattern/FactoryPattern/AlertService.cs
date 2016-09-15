using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class AlertService
    {
        public static Func<AlertService> Create { get; set; }

        public abstract bool Show(string title, string message, string yesButton, string noButton);
    }
}
