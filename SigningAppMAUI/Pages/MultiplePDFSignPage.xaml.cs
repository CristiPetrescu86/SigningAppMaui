using SigningApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui;
using Microsoft.Maui.Controls.Xaml;

namespace SigningApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplePDFSignPage : ContentPage
    {
        public MultiplePDFSignPage()
        {
            InitializeComponent();

            var vm = MultiplePDFSignPageViewModel.Instance;
            this.BindingContext = vm;
            vm.DisplayKeyNotSelected += () => DisplayAlert("Eroare", "Key Not Selected", "Close");
            vm.DisplayXCoordNotSet += () => DisplayAlert("Eroare", "X nu are valoare", "Close");
            vm.DisplayYCoordNotSet += () => DisplayAlert("Eroare", "Y nu are valoare", "Close");
            vm.DisplayWidthNotSet += () => DisplayAlert("Eroare", "Latimea chenarului nu are valoare", "Close");
            vm.DisplayHeightNotSet += () => DisplayAlert("Eroare", "Lungimea chenarului nu are valoare", "Close");
            vm.DisplayFileNotUploaded += () => DisplayAlert("Eroare", "Fisierul nu a fost incarcat", "Close");
            vm.DisplayVisibilityNotSet += () => DisplayAlert("Eroare", "Vizibilitate chenar nu a fost setata", "Close");
            vm.DisplayPageNotSelected += () => DisplayAlert("Eroare", "Amplasamentul pe pagina nu a fost setat", "Close");
            vm.DisplayCoordError += () => DisplayAlert("Eroare", "Toate coordonatele trebuie sa fie numere intregi", "Close");
            vm.DisplayPINandOTPnotSet += () => DisplayAlert("Eroare", "PIN sau OTP nu este setat", "Close");
            vm.DisplayPINnotSet += () => DisplayAlert("Eroare", "PIN nu este setat", "Close");
            vm.DisplayOTPnotSet += () => DisplayAlert("Eroare", "OTP nu este setat", "Close");
            vm.DisplayCredAuthNotOK += () => DisplayAlert("Eroare", "Autorizarea cheii nu a putut fi realizata", "Close");
            vm.DisplaySignMethNotOK += () => DisplayAlert("Eroare", "Eroare la semnarea hash-ului", "Close");
            vm.DisplayTipSemnaturaNotChecked += () => DisplayAlert("Eroare", "Tip semnatura nu a fost bifat", "Close");
            vm.DisplayTimestampNotChecked += () => DisplayAlert("Eroare", "Timestamp nu a fost bifat", "Close");
            vm.DisplayAlgoNotSelected += () => DisplayAlert("Eroare", "Algoritmul nu a fost selectat", "Close");
            vm.DisplaySignNameNotSet += () => DisplayAlert("Eroare", "Numele semnaturii nu a fost introdus", "Close");
        }

        private void LoadAlgos(object sender, EventArgs e)
        {
            var vm = MultiplePDFSignPageViewModel.Instance;
            vm.LoadSignAlgos();
        }

        protected override bool OnBackButtonPressed()
        {
            var vm = MultiplePDFSignPageViewModel.Instance;
            vm.deleteInstance();

            return false;
        }

    }
}