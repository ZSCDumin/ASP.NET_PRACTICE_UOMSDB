<%@ Page Title="" Language="C#"   MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="SellingPro.aspx.cs" Inherits="高校食堂自助配餐系统.seller.SellingPro" %>

<%@ Register Src="~/Control_seller/C_SellingPro.ascx" TagPrefix="uc1" TagName="C_SellingPro" %>
<%@ Register Src="~/Control_seller/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_SellingPro runat="server" ID="C_SellingPro" />
</asp:Content>
