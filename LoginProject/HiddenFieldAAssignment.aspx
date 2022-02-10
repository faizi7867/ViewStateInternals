<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFieldAAssignment.aspx.cs" Inherits="LoginProject.HiddenFieldAAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Name<asp:TextBox runat="server"  ID="tbname"/><br />
            Age<asp:TextBox runat="server" ID="tbage"/><br />
            bg<asp:DropDownList runat="server" ID= "ddlbg">
            </asp:DropDownList><br />
            <asp:Button Text="Get Details" ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" />
            <input type="hidden" runat="server" id="hdnName" name="name" value="" />
            <input type="hidden" runat="server" id="hdnAge" name="name" value="" />
            <input type="hidden" runat="server" id="hdnBG" name="name" value="" />
        </div>
    </form>
</body>
</html>
