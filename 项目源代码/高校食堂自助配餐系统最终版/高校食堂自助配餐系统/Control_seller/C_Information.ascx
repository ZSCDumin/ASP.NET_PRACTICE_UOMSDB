<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Information.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.C_Information" %>

<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />




<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">卖家信息</h3>
	</div>
	<div class="panel-body">
		<h3 style="margin-left:50%;">卖家信息</h3>

<table class="table table-hover">
    <tr>
        
        <td>
           <h4> 卖家账号：<asp:Label ID="lbl_s_account" runat="server" Text="Label" ></asp:Label></h4>
        </td>
    </tr>

    <tr>
         
        <td>
            
            <h4>卖家名字：<asp:Label ID="lbl_s_name" runat="server" Text="Label"></asp:Label></h4>
        </td>
    </tr>

    <tr>
        
        <td>
            <h4>卖家店名：<asp:Label ID="lbl_s_storename" runat="server" Text="Label"></asp:Label></h4>

        </td>
    </tr>


    <tr>
         
        <td>
            <h4>卖家盈利：<asp:Label ID="lbl_s_profit" runat="server" Text="Label"></asp:Label></h4>

        </td>
    </tr>


    <tr>
         
        <td>
            <h4>卖家电话：<asp:Label ID="lbl_s_tel" runat="server" Text="Label"></asp:Label></h4>

        </td>
    </tr>


    <tr>
        
        <td>
            <h4>卖家状态：<asp:Label ID="lbl_s_state" runat="server" Text="Label"></asp:Label></h4>
        </td>
    </tr>
</table>

	</div>
</div>





