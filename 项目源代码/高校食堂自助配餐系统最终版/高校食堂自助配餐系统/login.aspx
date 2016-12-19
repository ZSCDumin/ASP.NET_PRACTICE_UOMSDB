<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="高校食堂自助配餐系统.seller.login" %>

<%@ Register Src="~/Control_seller/C_login.ascx" TagPrefix="uc1" TagName="C_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_login runat="server" ID="C_login" />
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder3">
</asp:Content>


