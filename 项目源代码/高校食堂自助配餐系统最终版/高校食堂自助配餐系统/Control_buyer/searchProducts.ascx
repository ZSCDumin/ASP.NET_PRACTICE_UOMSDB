<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Commodity_search.ascx.cs" Inherits="Commodity_search" %>

<style type="text/css">
    #nav {
        margin-left: 210px;
    }

    .auto-style1 {
        width: 114px;
        height: 53px;
    }
</style>

<div id="header" style="width: 800px">
</div>

<div id="section" style="width: 800px; height: 50px;">
    &nbsp;&nbsp;&nbsp;<img alt="" class="auto-style1" src="../images/shangpinsousuo0.jpg" /><asp:TextBox ID="TextBox1" runat="server" Height="46px" Width="405px"></asp:TextBox>
    &nbsp;<asp:ImageButton ID="ImageButton1" runat="server" Height="52px" ImageUrl="~/images/sousuo0.png" Width="97px" OnClick="ImageButton1_Click" />
</div>
<br />
<div id="shuju" style="width: 800px;">
    <asp:GridView ID="GridView1" runat="server" Style="margin-left: 100px;" CellPadding="4" ForeColor="#333333" GridLines="None" Width="555px">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
</div>
