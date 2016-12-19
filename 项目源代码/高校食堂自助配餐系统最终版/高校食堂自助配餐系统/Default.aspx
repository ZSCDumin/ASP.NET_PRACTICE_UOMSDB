<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>
<%@ Register Src="~/control_buyer/ProductShow.ascx" TagPrefix="uc1" TagName="ProductShow" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <uc1:ProductShow runat="server" ID="ProductShow" />
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder2">
</asp:Content>

<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="ContentPlaceHolder3">
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>




