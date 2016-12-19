<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_evaluationOfProduct.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.evaluationOfProduct" %>

<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
<div class="panel panel-primary">
	<div class="panel-heading">
		<h3 class="panel-title">买家订单</h3>
	</div>
	<div class="panel-body">
		
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="118px" BackColor="#ffffff" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  CssClass="table table-hover" style="margin-top:20px;">
    <AlternatingRowStyle BackColor="#f7e8af" />
    <Columns>
        <asp:BoundField HeaderText="订单编号" DataField="b_o_Id" />
        <asp:BoundField HeaderText="商品编号" DataField="p_Id" />
        <asp:BoundField HeaderText="商品名称" DataField="p_name" />
        <asp:BoundField HeaderText="商品数量" DataField="p_num" />
        <asp:BoundField HeaderText="订单总价" DataField="b_o_totalPrice" />
        <asp:BoundField HeaderText="订单状态" DataField="b_orderState" />
        <asp:BoundField HeaderText="处理时间" DataField="b_o_time" />
        <asp:CommandField SelectText="订单评价" ShowSelectButton="True" />
    </Columns>
  
</asp:GridView>

	</div>
</div>







