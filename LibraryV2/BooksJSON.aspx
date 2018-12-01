<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksJSON.aspx.cs" Inherits="LibraryV2.BooksJSON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="assets/lib/bootstrap/dist/css/bootstrap.css" />
    <link rel="stylesheet" href="assets/css/web.css" />
    <link rel="stylesheet" href="assets/css/mobile.css" media="screen and (max-device-width: 480px)" />
    <link rel="stylesheet" href="assets/css/print.css" media="print" />
</head>
<body>
<form id="form1" runat="server">
   <div class="Library Rankings">
    <h1> Search Our Inventory! </h1>
   </div>

        <p>
            <asp:TextBox ID="BooksJSONTxTBox" runat="server" Height="29px" Width="724px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BooksJsonBtn" runat="server" OnClick="Button1_Click" Text="Search" />
        </p>
    </form>
</body>
</html>
