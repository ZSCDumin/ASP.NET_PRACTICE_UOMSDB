<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_ShoppingCart.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.WebUserControl1" %>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />

    <h1 style="margin-left:45%;">购物车</h1><br />
    <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="b_account,p_Id" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" CssClass="table table-striped"  style="margin:0 auto;" OnSelectedIndexChanged="gv_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField>

                <HeaderTemplate>
                    <asp:CheckBox ID="chkAllProducts" runat="server" Text="全选" AutoPostBack="true" OnCheckedChanged="chkAllProducts_CheckedChanged" />
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:CheckBox ID="chkProducts" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="b_account" HeaderText="买家账号" ReadOnly="True" SortExpression="b_account" />
            <asp:BoundField DataField="s_account" HeaderText="卖家账号" SortExpression="s_account" />
            <asp:BoundField DataField="s_storeName" HeaderText="店铺名称" SortExpression="s_storeName" />
            <asp:BoundField DataField="p_Id" HeaderText="商品Id" ReadOnly="True" SortExpression="p_Id" />
            <asp:BoundField DataField="p_name" HeaderText="商品名称" SortExpression="p_name" />
            <asp:BoundField DataField="p_price" HeaderText="商品价格" SortExpression="p_price" />
            <asp:TemplateField HeaderText="商品数量" SortExpression="p_num">
                <ItemTemplate>
                    <asp:TextBox ID="txtNum" runat="server" Height="21px" Width="40px" Text='<%# Bind("p_num") %>' TextMode="Number" BorderStyle="None"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>

        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataAccess.UOMSDBDataContext" EntityTypeName="" TableName="cart_T" Where="b_account == @b_account" EnableDelete="True" OrderBy="s_account">
            <WhereParameters>
                <asp:SessionParameter Name="b_account" SessionField="UserAccount" Type="String" />
            </WhereParameters>
        </asp:LinqDataSource>

      
<div style="margin-top:10%;">
        <asp:Button ID="btnReCal" runat="server" OnClick="btnReCal_Click" Text="重新计算" CssClass="btn btn-primary" style="margin-left:10%;margin-right:10%;"/>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="清空购物车" CssClass="btn btn-primary" style="margin-right:10%;" />
        <asp:CheckBox ID="chkIsOnline" runat="server" Text="在线支付" />
        总价：<asp:Label ID="lblTotalPrice" runat="server" Text="0"></asp:Label>元
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click1" Text="提交订单" CssClass="btn btn-primary" style="margin-right:10%;margin-left:10%;" />
</div>
