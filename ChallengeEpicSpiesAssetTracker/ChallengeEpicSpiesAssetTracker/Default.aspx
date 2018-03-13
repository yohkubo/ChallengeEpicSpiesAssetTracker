<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 122px;
            height: 150px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
            <h2><span class="auto-style2"><strong>Asset Performance Tracker</strong></span><br />
            </h2>
            Asset Name: <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Elections Rigged: <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsSubterfugeTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
