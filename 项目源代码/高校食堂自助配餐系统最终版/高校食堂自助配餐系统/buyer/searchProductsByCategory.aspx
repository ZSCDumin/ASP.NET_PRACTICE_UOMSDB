<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="searchProductsByCategory.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.searchProductsByCategory" %>
<%@ Register src="../control_buyer/C_searchProductsByCategory.ascx" tagname="C_searchProductsByCategory" tagprefix="uc1" %>
<%@ Register src="../control_buyer/C_NavStatus.ascx" tagname="C_NavStatus" tagprefix="uc2" %>
<%@ Register src="../control_buyer/C_LoginStatus.ascx" tagname="C_LoginStatus" tagprefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <uc3:C_LoginStatus ID="C_LoginStatus1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<uc2:C_NavStatus ID="C_NavStatus1" runat="server" />
    <uc1:C_searchProductsByCategory ID="C_searchProductsByCategory1" runat="server" />


</asp:Content>
