<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="C_ProductDetail.ascx.cs" Inherits="高校食堂自助配餐系统.control_buyer.ProductDetail" %>

 <link href="bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" media="all" />


<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">商品详情</h3>
    </div>
    <div class="panel-body" style="margin-left:30%;">
      <asp:DataList ID="DataList1" runat="server" DataKeyField="p_Id" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
    <ItemTemplate>
        <table class="table">
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Bind("p_photo") %>' />
                </td>
                
            </tr>
            <tr>
            <td >
                    菜名：<asp:Label ID="Label1" runat="server" Text='<%# Bind("p_name") %>'></asp:Label>
            </td>
             </tr>
            <tr>
                <td>
                   价格： <asp:Label ID="Label2" runat="server" Text='<%# Bind("p_price") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                   数量： <asp:TextBox ID="TextBox1" runat="server" TextMode="Number">1</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="加入购物车" CssClass="btn btn-primary" />
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
<asp:Repeater ID="Repeater1" runat="server" DataSourceID="LinqDataSource1">
    <ItemTemplate>
         <table class="auto-style1">
            <tr>
                <td>用户点评：<%#Eval("p_evaluate") %></td>
            </tr>
        </table>
    </ItemTemplate>
</asp:Repeater>


<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="DataAccess.UOMSDBDataContext" EntityTypeName="" Select="new (p_Id, p_evaluate)" TableName="b_evaluate_T">
</asp:LinqDataSource>



    </div>
</div>

