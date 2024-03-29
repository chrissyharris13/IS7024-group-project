﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumeMovies.aspx.cs" Inherits="LibraryV2.ConsumeMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Movies</title>
    <link rel="stylesheet" href="assets/web.css" />
    <link rel="stylesheet" href="assets/mobile.css" media="screen and (max-device-width: 480px)" />
    <link rel="stylesheet" href="assets/print.css" media="print" />
</head>
<body>
    <h1>Number of Movies</h1>
    <form id="form1" runat="server">
			<asp:Label ID="LblSearchInstruct" runat="server" Text="Search For A Movie:   "></asp:Label>
            <asp:TextBox ID="TxtBxInput1" runat="server"></asp:TextBox>
            <asp:Button ID="BtnSearch" runat="server" Text="Search" />
		<div>
            <asp:ListBox ID="ListBox1" runat="server" Width="300px" DataSourceID="MovieDataSource" DataTextField="Title" DataValueField="Id"></asp:ListBox>
            <asp:ObjectDataSource ID="MovieDataSource" runat="server" SelectMethod="GetMovies1" TypeName="LibraryV2.ShowMovies"></asp:ObjectDataSource>
        </div>
        <br />
        <div>
            <asp:Button ID="BtnReadJSON" runat="server" OnClick="BtnReadJSON_Click" Text="Count Movies" Width="98px" />
             <asp:Label ID="LblJSONCount" runat="server" Text="Movie Count"></asp:Label>
        </div>
    </form>
</body>
</html>
