using System;
using Xamarin.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.IO;
using Syncfusion.Drawing;
using System.Threading.Tasks;

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

            //GetInputValues
            string Clientnumber = clientnumber.Text;
            string phoneNumber = phonenumber.Text;
            string Company = company.Text;
            string Cvrnumber = cvrnumber.Text;
            string Deliveryaddress = deliveryaddress.Text;
            string Order = order.Text;

            // Create a new PDF document
            PdfDocument document = new PdfDocument();

            //Add page settings


            //Add a page to the document
            PdfPage page = document.Pages.Add();

            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;


            //Set the standard font
            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

            //Draw the text
            graphics.DrawString(string.Format(" {0}" + Environment.NewLine + "{1}" + Environment.NewLine + "{2}" + Environment.NewLine + "{3}" + Environment.NewLine + "{4}" + Environment.NewLine + "{5}", Clientnumber, phoneNumber, Company, Cvrnumber, Deliveryaddress, Order), font, PdfBrushes.Black, new PointF(0, 0));

            //Save the document to the stream
            MemoryStream stream = new MemoryStream();
            document.Save(stream);

            //Close the document
            document.Close(true);

            //Save the stream as a file in the device and invoke it for viewing
            Task generatingDoc = Xamarin.Forms.DependencyService.Get<ISave>().SaveAndView("Output.pdf", "application/pdf", stream);

            while (generatingDoc.Status != TaskStatus.RanToCompletion)
            {
                //
            }

            string g = "";

            //DisplayAlert("Warnning", "Your order has been sent to Hymatik", "Ok");
        }

        //protected class InputedValues
        //{
        //    private long? _clientNumber;
        //    private long? _phoneNumber;
        //    private string _company;
        //    private string _cvrnumber;



        //}
    }
}
