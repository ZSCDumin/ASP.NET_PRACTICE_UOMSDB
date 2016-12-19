<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="registered.aspx.cs" Inherits="高校食堂自助配餐系统.seller.registered" %>

<%@ Register Src="~/Control_seller/C_registered.ascx" TagPrefix="uc1" TagName="C_registered" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_registered runat="server" ID="C_registered" />
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder3">
</asp:Content>



