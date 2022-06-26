using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Xaml;

namespace SigningApp.PopupPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PINPopup : Popup
    {
        public PINPopup()
        {
            InitializeComponent();
        }

        private void Close_Button(object sender, EventArgs e)
        {
            if (pinEntry.Text == null)
            {
                Close("UNSET");
            }

            Close(pinEntry.Text);
        }

    }
}