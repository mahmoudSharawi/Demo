using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbraco.cms.businesslogic.member;
using umbraco.cms.businesslogic;
namespace mahmoud
{
    public partial class Useroverview : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member m = Member.GetCurrentMember();
            Label1.Text = m.LoginName;
            Label2.Text = m.Email;
            Label3.Text = m.getProperty("gender").Value.ToString();
            Label4.Text = m.getProperty("hobb").Value.ToString();


        }
    }
}