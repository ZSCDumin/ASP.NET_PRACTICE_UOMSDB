﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Modify_goods.aspx.cs" Inherits="高校食堂自助配餐系统.seller.Modify_goods" %>

<%@ Register Src="~/Control_seller/C_Modify_goods.ascx" TagPrefix="uc1" TagName="C_Modify_goods" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>
<%@ Register Src="~/Control_seller/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Modify_goods runat="server" ID="C_Modify_goods" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
    
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>


