<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.register" %>
<%@ Register src="control_buyer/C_Register.ascx" tagname="C_Register" tagprefix="uc1" %>
<%@ Register src="Control_seller/C_LoginStatus.ascx" tagname="C_LoginStatus" tagprefix="uc2" %>
<%@ Register src="control_buyer/C_NavStatus.ascx" tagname="C_NavStatus" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
  
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_Register ID="C_Register1" runat="server" />
</asp:Content>

