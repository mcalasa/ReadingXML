<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReadingXML.Webform.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </div>
            <div>
                <asp:TextBox ID="TextBox1" runat="server" Height="98px" TextMode="MultiLine" Width="280px"></asp:TextBox>
            </div>
            <div>
                <ul>
                    <li>
                        <asp:Button ID="btnReadXml" runat="server" Text="Read XML" OnClick="btnReadXml_Click" /></li>
                    <li>
                        <asp:Button ID="btnReadSchema" runat="server" Text="Read Schema" OnClick="btnReadSchema_Click" /></li>
                </ul>
            </div>
        </div>

    </form>
</body>
</html>
