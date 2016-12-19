<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="Status_query.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.Status_query" %>

<%@ Register Src="~/control_buyer/C_search_state.ascx" TagPrefix="uc1" TagName="search_state" %>

<%@ Register src="../control_buyer/C_NavStatus.ascx" tagname="C_NavStatus" tagprefix="uc2" %>
<%@ Register src="../control_buyer/C_LoginStatus.ascx" tagname="C_LoginStatus" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <uc3:C_LoginStatus ID="C_LoginStatus1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <uc2:C_NavStatus ID="C_NavStatus1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <uc1:search_state runat="server" ID="search_state" />
</asp:Content>
