<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Using the Stock Service</h3>
            <br /><br />
            <asp:Lable ID="lblmessage" runat="server"></asp:Lable>
            <br /><br />
            <asp:Button ID="btnpostback" runat="server" onclick="Button1_Click" Text="Post Back" Style="width:132px"/>
            <asp:Lable ID="btnservice" runat="server" onclick="Button1_Click" Text="Get Stock" Style="width:99px"/>


        </div>
    </form>
</body>
</html>
