<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="State_query.aspx.cs" Inherits="高校食堂自助配餐系统.seller.State_query" %>

<%@ Register Src="~/Control_seller/C_State_query.ascx" TagPrefix="uc1" TagName="C_State_query" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_State_query runat="server" ID="C_State_query" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>

