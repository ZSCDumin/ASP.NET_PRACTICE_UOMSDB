<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Number_query.aspx.cs" Inherits="高校食堂自助配餐系统.seller.Number_query" %>

<%@ Register Src="~/Control_seller/C_Number_query.ascx" TagPrefix="uc1" TagName="C_Number_query" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>
<%@ Register Src="~/Control_seller/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Number_query runat="server" ID="C_Number_query" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
   <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
     
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>


