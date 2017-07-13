using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RallyRestApi.AuthenticatorUI
{
    public partial class frmAuthenticate : Form
    {
        private string sessionID;

        public string SessionID
        {
            get { return sessionID; }
            //set { sessionID = value; }
        }

        private string webUrl;

        public string WebURL
        {
            get { return webUrl; }
            set { webUrl = value; }
        }

        private string apiUrl;

        public string ApiURL
        {
            get { return apiUrl; }
            set { apiUrl = value; }
        }


        public frmAuthenticate()
        {
            InitializeComponent();
        }

        private void frmAuthenticate_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(this.webUrl);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = webBrowser1.Document;

            //if (doc.Body.InnerText != null && doc.Body.InnerText.IndexOf(RallyConstants.Rally_SessionID_Key) >-1)
            if (webBrowser1.DocumentText.Contains("cookie value:"))
            {
                string body = doc.Body.InnerText;
                sessionID = body.Substring(body.IndexOf("cookie value:")+ ("cookie value:").Length).Trim ();
                sessionID=sessionID.Replace("\n", "").Trim();
                sessionID = sessionID.Replace("\r", "").Trim();
                //webBrowser1.Document.Domain;
                //webBrowser1.Document.Url.AbsoluteUri;
                apiUrl=webBrowser1.Document.Url.Scheme + "://";
                apiUrl+=webBrowser1.Document.Url.Host;
                if (sessionID.Length > 0)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
