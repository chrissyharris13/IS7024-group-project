﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBooks.aspx.cs" Inherits="LibraryV2.SearchBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search for Books</title>
    <link rel="stylesheet" href="assets/web.css" />
    <link rel="stylesheet" href="assets/mobile.css" media="screen and (max-device-width: 480px)" />
    <link rel="stylesheet" href="assets/print.css" media="print" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblSearchInstruct" runat="server" Text="Search For A Book:   "></asp:Label>
            <asp:TextBox ID="TxtBxInput1" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSearch" runat="server" Text="Search" />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Width="225px" DataSourceID="BookResource" DataTextField="Title" DataValueField="Id"></asp:ListBox>
        <asp:ObjectDataSource ID="BookResource" runat="server" SelectMethod="GetLibraryRankings1" TypeName="LibraryV2.ShowBooks"></asp:ObjectDataSource>
		<div>
            <asp:Button ID="BtnReadJSON" runat="server" OnClick="BtnReadJSON_Click" Text="Count Books" Width="98px" />
             <asp:Label ID="LblJSONCount" runat="server" Text="Book Count"></asp:Label>
        </div>
    </form>
</body>
</html>
