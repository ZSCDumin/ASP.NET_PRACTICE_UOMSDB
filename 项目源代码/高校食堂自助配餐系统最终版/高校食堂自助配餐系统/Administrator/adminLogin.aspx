<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="高校食堂自助配餐系统.Administrator.adminLogin" %>

<%@ Register Src="~/Control_admin/administrator_uc.ascx" TagPrefix="uc1" TagName="administrator_uc" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:administrator_uc runat="server" id="administrator_uc" />
    </div>
    </form>
</body>
</html>
