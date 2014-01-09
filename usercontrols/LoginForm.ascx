<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.ascx.cs" Inherits="mahmoud.LoginForm" %>
<div>Email: <asp:TextBox ID="email" runat="server" /></div>
 <div>Password: <asp:TextBox ID="password"  TextMode=Password runat="server" /></div>
 <asp:Button ID="Button2" runat="server" Text="Login" onclick="onclickbutton" ></asp:Button>