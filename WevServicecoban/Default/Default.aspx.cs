using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

//using localhost;
using webdemo;

namespace Default
{
    public partial class Default : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 lblmessage.Text = "First Loading Time: " + DateTime.Now.ToLongTimeString();
            }
            else
            {
                lblmessage.Text="PostBack at: "+ DateTime.Now.ToLongTimeString();

            }
        }
        protected void btnservice_Click(object sender, EventArgs e)
        {
            StockService proxy = new StockService();
            lblmessage.Text=String.Format("Current SATYAM Price:{0}", proxy.GetPrice("SATYAM").ToString());

        }
    }
}