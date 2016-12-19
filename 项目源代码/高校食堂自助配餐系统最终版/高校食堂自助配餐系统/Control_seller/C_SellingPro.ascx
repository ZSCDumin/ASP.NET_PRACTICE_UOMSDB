<%@ Control Language="C#"  AutoEventWireup="true"  CodeBehind="C_SellingPro.ascx.cs"  Inherits="高校食堂自助配餐系统.control_buyer.WebUserControl2" %>
<link href="../bootstrap/css/bootstrap.css" rel="stylesheet" type="text/css" />
<div class="panel panel-primary">
    <div class="panel-heading">
        <h3 class="panel-title">在售商品</h3>
    </div>
    <div class="panel-body">
        <asp:DataList ID="DataList1" runat="server" Width="100%" RepeatColumns="1" DataKeyField="p_Id" OnItemCommand="DataList1_ItemCommand">
            <HeaderTemplate>
                <table class="table table-hover">
                    <tr>
                        <td >商品图片</td>
                        <td>商品名称</td>
                        <td >商品价格</td>
                        <td >商品分类</td>
                        <td >销量</td>
                        <td >库存</td>
                        <td  >     </td>
                        <td  >   </td>
                        <td>   </td>
                         <td>   </td>
                    </tr>
                </table>
            </HeaderTemplate>

            <ItemTemplate>
                <table class="table table-hover">
                    <tr>
                        <td style="width:17%;">
                          <%--  <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%#Eval("p_id") %>' CssClass="img-circle" Height="29px" ImageUrl='<%# Bind("p_photo") %>' OnClick="ImageButton1_Click" Width="48px" />--%>
                            <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%#Eval("p_id") %>' CssClass="img-circle" Height="29px" ImageUrl='<%# Bind("p_photo") %>' Width="48px" />
                        </td>
                        <td style="width:16%;">
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("p_name") %>'></asp:Label>
                        </td>
                        <td style="width:15%;">
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("p_price") %>'></asp:Label>
                        </td>
                        <td style="width:18%;">
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("p_category") %>'></asp:Label>
                        </td>
                        <td style="width:10%;">
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("p_saleNum") %>'></asp:Label>
                        </td>
                        <td style="width:11%;">
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("p_cNum") %>'></asp:Label>
                        </td>
                        <td style="width:5%;">
                            <asp:Button ID="Button1" runat="server" Text="修改" CssClass="btn btn-primary" CommandArgument='<%#Eval("p_id") %>' OnClick="Button1_Click" />
                        <%--    <asp:Label ID="Label5" runat="server" Text='<%# Bind("p_cNum") %>'></asp:Label>--%>
                        </td>
                        <td>
                          <%--  <asp:Button ID="Button2" runat="server" Text="删除" CssClass="btn btn-primary" OnClick="Button1_Click" />--%>
                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" CommandArgument='<%#Eval("p_id") %>' OnClick="Button2_Click1" Text="删除" />
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>

        <h4> 当前页<asp:Label ID="lbCurrent" runat="server" style="margin-left:2%;"></asp:Label>
            总页数:<asp:Label ID="lbTotalPage" runat="server" style="margin-left:2%;"></asp:Label></h4>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="上一页"  CssClass="btn btn-primary" style="margin-left:2%;" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="下一页"  CssClass="btn btn-primary" style="margin-left:2%;" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="首页"  CssClass="btn btn-primary" style="margin-left:2%;"/>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="尾页"  CssClass="btn btn-primary" style="margin-left:2%;"/>

        <br />

    </div>
</div>








