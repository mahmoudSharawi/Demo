using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbraco.cms.businesslogic;
using umbraco.cms.businesslogic.member;
using System.Collections.ArrayList;

namespace mahmoud
{
    public partial class LoginForm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void onclickbutton(object sender, EventArgs e)
        {
            var mem = Member.GetMemberFromLoginNameAndPassword(email.Text,password.Text);
            if (mem != null) {
                Member.AddMemberToCache(mem);
                Response.Redirect("/Products");
                var members= Member.GetAll;
           
                List<var> x= new List<var>();
            }
        }
    }
}