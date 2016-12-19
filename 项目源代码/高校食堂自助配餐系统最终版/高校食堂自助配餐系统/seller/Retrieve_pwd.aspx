<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Retrieve_pwd.aspx.cs" Inherits="高校食堂自助配餐系统.seller.Retrieve_pwd" %>

<%@ Register Src="~/Control_seller/C_Retrieve_pwd.ascx" TagPrefix="uc1" TagName="C_Retrieve_pwd" %>
<%@ Register Src="~/Control_seller/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Retrieve_pwd runat="server" ID="C_Retrieve_pwd" />
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">

</asp:Content>

<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder3">
    <uc1:C_Retrieve_pwd runat="server" ID="C_Retrieve_pwd1" />
</asp:Content>


