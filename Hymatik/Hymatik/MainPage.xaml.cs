using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hymatik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ////Input XAML file location
            //string fileName = "MainPage.xaml";
            ////Convert XAML file to XPS file
            //Stream xpsFile = GetXPSDocument(fileName);
            //if (xpsFile != null)
            //{
            //    xpsFile.Position = 0;
            //    //Initialize XPSToPdfConverter
            //    Syncfusion.XPS.XPSToPdfConverter converter = new Syncfusion.XPS.XPSToPdfConverter();
            //    //Convert XPS document into PDF document
            //    PdfDocument document = converter.Convert(xpsFile);
            //    //Save the Pdf document
            //    document.Save("XAMLToPDF.pdf");
            //    //Close the Pdf document
            //    document.Close(true);
            //    //This will open the PDF file so, the result will be seen in default PDF viewer 
            //    System.Diagnostics.Process.Start("XAMLToPDF.pdf");
            //}
            DisplayAlert("Warnning", "Your order has been sent to Hymatik", "Ok");
        }
    }
}
