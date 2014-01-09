<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditUser.ascx.cs" Inherits="mahmoud.EditUser" %>
   <h1>Edit ME</h1>
      <div>Name: 
    <asp:TextBox ID="name" runat="server" ></asp:TextBox>
      </div>
      <div>Email: <asp:TextBox ID="email" runat="server" /></div>
      <div>Password: <asp:TextBox ID="password"  TextMode=Password runat="server" /></div>
      <div>Repeat Password: <asp:TextBox ID="repeat_password" TextMode=Password  runat="server" />
       </div>
       <div>
          <asp:Label ID="Label1" text="Gender" runat="server" ></asp:Label>
          <asp:RadioButtonList ID="RadioButtonList1" runat="server">
              <asp:ListItem>MAle</asp:ListItem>
              <asp:ListItem>Female</asp:ListItem>
          </asp:RadioButtonList>
      </div>
      <asp:Label ID="Label2" text="hobbies" runat="server" ></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" >
        <asp:ListItem>Football</asp:ListItem>
        <asp:ListItem>Drawin</asp:ListItem>
        <asp:ListItem>Computer</asp:ListItem>
        
    </asp:CheckBoxList>
      <asp:Button ID="Button2" runat="server" Text="save" onclick="onclickbutton" ></asp:Button>

<asp:Label ID="Label3" runat="server" Text=""></asp:Label>