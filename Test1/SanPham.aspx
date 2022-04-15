<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="Test1.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .data{
            width:130px;
            height:150px;
            display:inline-block;
            float:left;
        }
        #hinh {
            max-width: 100px;
            max-height: 150px;
        }
        .lb_ChiTiet{
            margin-top:10px;
            color:blueviolet;
            cursor:pointer;
            text-decoration:none;
            color:black;
        }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Danh mục sản phẩm bạn đã chọn<asp:DataList ID="DataList1" runat="server" RepeatColumns="5">
        <ItemTemplate> 
            <div class="data">
                <a href="Chitiet.aspx?id=+<%# Eval("MaSach") %>">
                    <asp:Image ID="hinh" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
                    </br>
                    <asp:Label ID="Label1" CssClass="lb_ChiTiet" runat="server" Text='<%# Eval("DonGia","{0:0,0}") + " VND" %>'></asp:Label>
                    </br>                    
                    <asp:Label ID="Label2" CssClass="lb_ChiTiet" runat="server" Text='<%# Eval("TenSach")%>'></asp:Label>
                </a>
            </div>
        </ItemTemplate>
    </asp:DataList>
&nbsp;
</asp:Content>
