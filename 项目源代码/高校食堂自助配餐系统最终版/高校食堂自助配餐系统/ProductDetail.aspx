<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="高校食堂自助配餐系统.ProductDetail" %>

<%@ Register Src="~/C_ProductDetail.ascx" TagPrefix="uc1" TagName="C_ProductDetail" %>
<%@ Register Src="~/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_ProductDetail runat="server" ID="C_ProductDetail" />
</asp:Content>
