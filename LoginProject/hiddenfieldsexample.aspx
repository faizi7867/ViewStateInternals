<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hiddenfieldsexample.aspx.cs" Inherits="LoginProject.hiddenfieldsexample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="hidden" name="name" runat="server" id="tbtemp" value="" />
            <asp:TextBox runat="server" ID ="tbnum" /><br />
            <asp:Button Text="Add" ID ="btnadd" runat="server" OnClick="btnadd_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
