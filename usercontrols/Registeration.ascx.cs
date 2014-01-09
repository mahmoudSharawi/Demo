using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using umbraco.cms.businesslogic;
using umbraco.cms.businesslogic.member;

namespace mahmoud
{
    public partial class Registeration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void onclickbutton(object sender, EventArgs e)
        {


            if (Member.GetMemberFromEmail(name.Text) == null)
            {
                if (password.Text.Equals(repeat_password.Text))
                {
                    MemberType demoMemberType = MemberType.GetByAlias("SiteMembers");
                    Member newMember = Member.MakeNew(name.Text, demoMemberType, new umbraco.BusinessLogic.User(0));
                    newMember.Email = email.Text;
                    newMember.Password = password.Text;
                    newMember.LoginName = name.Text;
                    newMember.getProperty("gender").Value = RadioButtonList1.SelectedItem.Text;
                    newMember.getProperty("hobb").Value = CheckBoxList1.SelectedItem.ToString();
                    newMember.XmlGenerate(new System.Xml.XmlDocument());
                    newMember.Save();      
                    Response.Redirect("/");
                }
                else{
                   Label1.Text="Passwords doesnot match";
                }
            }
            else{
                Label1.Text="User name already exists";
            }

            
        }
    }
}