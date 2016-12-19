<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="searchProductsByName.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.searchProductsByName" %>

<%@ Register Src="~/control_buyer/C_searchProductsByName.ascx" TagPrefix="uc1" TagName="C_searchProductsByName" %>

<%@ Register src="../control_buyer/C_NavStatus.ascx" tagname="C_NavStatus" tagprefix="uc2" %>
<%@ Register src="../control_buyer/C_LoginStatus.ascx" tagname="C_LoginStatus" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <uc3:C_LoginStatus ID="C_LoginStatus1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

  <uc2:C_NavStatus ID="C_NavStatus1" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <uc1:C_searchProductsByName runat="server" ID="C_searchProductsByName" />
</asp:Content>
