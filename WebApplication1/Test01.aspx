﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test01.aspx.cs" Inherits="WebApplication1.Test01" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Salut Simon<br />

    <asp:Button ID="DataBaseButton" runat="server" Text="Go Server" 
            onclick="DataBaseButton_Click" />
    <br />
    <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
