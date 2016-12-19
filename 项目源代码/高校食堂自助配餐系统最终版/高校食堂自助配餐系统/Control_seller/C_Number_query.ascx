<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_Number_query.ascx.cs" Inherits="高校食堂自助配餐系统.Control_seller.Number_query" %>
<header>
    <style>
        .contain {
            width: 1003px;
            height: 560px;
        }

        .btn {
            padding: 0px 70px 0px 70px;
            background-color: #f7e8af;
            font-size: 17px;
            margin-top: 25px;
            margin-bottom:15px;
        }

        .text {
            height: 30px;
            width: 250px;
            margin-top: 20px;
        }

        .left {
            height: auto;
            width: auto;
            float: left;
            margin: 20px 0px 0px 27%;
            text-align: center;
        }

        .right {
            height: 560px;
            width: 503px;
            float: left;
            text-align: center;
        }

        .Radiobtn {
            font-size: 17px;
            font-family: SimHei;
        }

        label {
            font-size: 17px;
        }
    </style>

</header>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />



<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">编号查询</h3>
	</div>
	<div class="panel-body">
		<div class="contain">
    <div class="left">
            <h2>	
编号查询</h2>
        <table class="table table-hover">
            
            
             
            <tr>
                <td> <h5>请输入卖家账号：</h5>  </td>

                <td>    <asp:TextBox ID="txtSell_Id" runat="server" placeholder="用户名" CssClass="text"></asp:TextBox></td>
               <td>     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSell_Id" ErrorMessage="必须输入订单编号"></asp:RequiredFieldValidator></td>            
            </tr>


        </table>

  <asp:Button ID="btn_Search" runat="server" Text="查询" CssClass="btn btn-primary" OnClick="btn_Search_Click" />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="s_o_Id" HeaderText="订单编号" />
                <asp:BoundField DataField="b_account" HeaderText="买家账号" />
                <asp:BoundField DataField="s_o_state" HeaderText="订单状态" />
                <asp:BoundField DataField="s_o_totalprice" HeaderText="总价" />
                <asp:BoundField DataField="s_o_time" HeaderText="处理时间" />
                <asp:BoundField DataField="p_Id" HeaderText="商品编号" />
                <asp:BoundField DataField="p_price" HeaderText="价格" />
                <asp:BoundField DataField="p_num" HeaderText="商品数量" />
            </Columns>
        </asp:GridView>
    </div>
</div>

	</div>
</div>




