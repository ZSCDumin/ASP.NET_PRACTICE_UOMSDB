<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_search_state.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.search_state" %>

<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />



<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">订单状态查询</h3>
    </div>
    <div class="panel-body">
        <div style="margin-left: 25%; margin-top: 20px;">

            <div style="margin-left: 15%;">
                <i class="auto-style5" style="font-size: 30px; color: skyblue;">订单状态查询</i><i style="color: gray; font-size: 10px;">Order Status Inquiry</i><br />
                订单状态:     
                      
                <asp:DropDownList ID="ddlState" runat="server">
                    <asp:ListItem>已付款</asp:ListItem>
                    <asp:ListItem>未支付</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询" CssClass="btn btn-primary" />
            </div>


            <div id="zhuangtai" style="margin-top: 20px;">
                <strong>查询结果</strong><br />

                <asp:GridView ID="GridView1" runat="server" Width="595px" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-hover" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="b_o_Id" HeaderText="订单编号" />
                        <asp:BoundField DataField="b_account" HeaderText="买家账号" />
                        <asp:BoundField DataField="s_account" HeaderText="卖家账号" />
                        <asp:BoundField DataField="s_storeName" HeaderText="店铺名称" />
                        <asp:BoundField DataField="b_orderState" HeaderText="订单状态" />
                        <asp:BoundField DataField="b_o_totalPrice" HeaderText="订单总价" />
                        <asp:BoundField DataField="b_o_time" HeaderText="订单时间" />
                    </Columns>
                </asp:GridView>
            </div>


        </div>

    </div>
</div>


