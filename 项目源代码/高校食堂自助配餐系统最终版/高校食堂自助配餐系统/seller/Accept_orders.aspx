<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Accept_orders.aspx.cs" Inherits="高校食堂自助配餐系统.seller.Accept_orders" %>

<%@ Register Src="~/Control_seller/C_Accept_orders.ascx" TagPrefix="uc1" TagName="C_Accept_orders" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Accept_orders runat="server" ID="C_Accept_orders" />
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>


