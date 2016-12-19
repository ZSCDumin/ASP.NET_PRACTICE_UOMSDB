<%@ Page Title="" Language="C#" MasterPageFile="~/ModifyUser.Master" AutoEventWireup="true" CodeBehind="showInformationOfBuyer.aspx.cs" Inherits="高校食堂自助配餐系统.buyer.showInformationOfBuyer" %>

<%@ Register Src="~/control_buyer/C_showInformationOfBuyer.ascx" TagPrefix="uc1" TagName="C_showInformationOfBuyer" %>
<%@ Register Src="~/control_buyer/C_NavStatus.ascx" TagPrefix="uc1" TagName="C_NavStatus" %>
<%@ Register Src="~/control_buyer/C_LoginStatus.ascx" TagPrefix="uc1" TagName="C_LoginStatus" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <uc1:C_LoginStatus runat="server" ID="C_LoginStatus" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc1:C_NavStatus runat="server" ID="C_NavStatus" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:C_showInformationOfBuyer runat="server" ID="C_showInformationOfBuyer" />
</asp:Content>
