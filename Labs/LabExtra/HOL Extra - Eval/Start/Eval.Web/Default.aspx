<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Eval.Web.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Addskills Course Eval</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Addskills Course Eval</h1>
    <h3>Please rate your course</h3>
    <table>
    <tr>
    <td>Your name:</td>
    <td>
        <asp:TextBox ID="txtName" runat="server" Width="487px"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td>Select Course:</td>
    <td><asp:DropDownList runat="server" Height="22px" Width="491px" ID="dlCourse">
        <asp:ListItem Selected="True" Value="A372">A372 - Developing Integration Solutions using Microsoft BizTalk Server 2010</asp:ListItem>
        <asp:ListItem Value="A313">A313 - Skapa webbapplikationer med Silverlight</asp:ListItem>
        <asp:ListItem Value="M10266">M10266 - Programming with C# using Microsoft .NET Framework 4</asp:ListItem>
        <asp:ListItem Value="M50466">M50466 - Windows Azure Solutions with Microsoft Visual Studio 2010</asp:ListItem>
        <asp:ListItem Value="M10263">M10263 - Developing Windows Communication Foundation Solutions with Microsoft Visual Studio 2010</asp:ListItem>
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
    <td>Your Rating:</td>
    <td><asp:DropDownList runat="server" Height="22px" Width="491px" ID="dlRating">
        <asp:ListItem Value="1" Selected="True">I've lost my will to live</asp:ListItem>
        <asp:ListItem Value="2">WhatEva!</asp:ListItem>
        <asp:ListItem Value="3">At least it was an handsome trainer...</asp:ListItem>
        <asp:ListItem Value="4">I guess it was good, but I was asleep most of the time...</asp:ListItem>
        <asp:ListItem Value="5">Best course EVER!</asp:ListItem>
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
    <td>Press Ok to submit your eval.</td>
    <td>
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" Text="Ok" 
            Width="137px" />
        </td>
    </tr>
    </table>
    <asp:Label ID="txtResponseText" Width="500px" runat="server" Font-Bold="True" 
            Font-Size="Large"></asp:Label>
    </div>
    </form>
</body>
</html>
