<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.Modify" %>
<%@ Register src="../control_buyer/C_LoginStatus.ascx" tagname="C_LoginStatus" tagprefix="uc1" %>
<%@ Register src="../control_buyer/C_NavStatus.ascx" tagname="C_NavStatus" tagprefix="uc2" %>
<%@ Register Src="~/Control_seller/C_Modify.ascx" TagPrefix="uc1" TagName="C_Modify" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

    <uc1:C_LoginStatus ID="C_LoginStatus1" runat="server" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <uc2:C_NavStatus ID="C_NavStatus1" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Modify runat="server" ID="C_Modify" />
</asp:Content>
