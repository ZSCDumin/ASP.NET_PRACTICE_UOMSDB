<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="高校食堂自助配餐系统.seller.Modify" %>

<%@ Register Src="~/Control_seller/C_Modify.ascx" TagPrefix="uc1" TagName="C_Modify" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>
<%@ Register Src="~/Control_seller/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Modify runat="server" ID="C_Modify" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
       <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
 
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>


