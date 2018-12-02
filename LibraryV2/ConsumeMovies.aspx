<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumeMovies.aspx.cs" Inherits="LibraryV2.ConsumeMovies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Number of Movies</h1>
    <form id="form1" runat="server">
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
