<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="l33tPass.Site._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div> 
        <asp:TextBox ID="textBox1" runat="server"></asp:TextBox>
        <br />
            <asp:LinkButton ID="btnGenerate" runat="server" onclick="LinkButton1_Click">Generate</asp:LinkButton>
        </div>   
        <div>
        <textarea id="richTextBox1" cols="20" name="S1" rows="2" runat="server"></textarea></div>
        </div>

        
           

    </form>
</body>
</html>
