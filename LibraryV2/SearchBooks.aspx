<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBooks.aspx.cs" Inherits="LibraryV2.SearchBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblSearchInstruct" runat="server" Text="Search for a book"></asp:Label>
            <asp:TextBox ID="TxtBxInput1" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSearch" runat="server" Text="Search" />
        </div>
    </form>
</body>
</html>
