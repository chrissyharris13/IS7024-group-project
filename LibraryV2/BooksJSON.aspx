<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksJSON.aspx.cs" Inherits="LibraryV2.BooksJSON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
<asp:Button ID="BooksJsonBtn" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:TextBox ID="BooksJSONTxTBox" runat="server" Height="461px" Width="902px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
