using System.Diagnostics;

namespace mauiWebView
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void GoButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                string url = urlInput.Text;
                webView.Source = new UrlWebViewSource()
                {
                    Url = url
                };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }

}
