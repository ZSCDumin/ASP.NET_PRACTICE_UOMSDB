<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.ShoppingCart" %>

<%@ Register Src="~/control_buyer/C_ShoppingCart.ascx" TagPrefix="uc1" TagName="C_ShoppingCart" %>
<%@ Register Src="~/control_buyer/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_ShoppingCart runat="server" ID="C_ShoppingCart" />
</asp:Content>
