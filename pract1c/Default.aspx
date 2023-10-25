<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pract1c" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title></title>
</head><body>
<form id="form1" runat="server">
<div>
<asp:Label ID="label1" runat="server">Enter First String</asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="textBox1" runat="server"></asp:TextBox><br />
<br />
select your operation :
<br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
>
<asp:ListItem >Fibonacci</asp:ListItem>
<asp:ListItem>prime</asp:ListItem>
<asp:ListItem>vowels</asp:ListItem>
<asp:ListItem> foreach loop</asp:ListItem>
<asp:ListItem>Reverse and Find sum of Digit</asp:ListItem>
</asp:DropDownList>
<br /><br />
<asp:Button ID="Submit" runat="server" Text="Submit" onclick="Submit_Click"
/>
<br /><br />
<asp:Label ID="result" runat="server"> </asp:Label>
</div>
</form></body>
</html>