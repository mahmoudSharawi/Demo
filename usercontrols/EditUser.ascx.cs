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
    public partial class EditUser : System.Web.UI.UserControl
    {

        Member m = Member.GetCurrentMember();
        protected void Page_Load(object sender, EventArgs e)
        {
            name.Text = m.LoginName;
            email.Text = m.Email;
            RadioButtonList1.SelectedValue = m.getProperty("gender").Value.ToString();
            foreach(string s in m.getProperty("hobb").Value.ToString().Split(','))
            {}
            
        }
        protected void onclickbutton(object sender, EventArgs e)
        {


            if (Member.GetMemberFromEmail(name.Text) == null)
            {
               
                    
                    m.Email = email.Text;
                    m.Password = password.Text;
                    m.LoginName = name.Text;
                    m.getProperty("gender").Value = RadioButtonList1.SelectedItem.Text;
                    m.getProperty("hobb").Value = CheckBoxList1.SelectedItem.ToString();
                    m.Save();
                    Response.Redirect("/");
               
               
            }
            else
            {
                Label1.Text = "User name already exists";
            }


        }
    }
}