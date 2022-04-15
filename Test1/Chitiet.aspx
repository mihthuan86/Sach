<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Chitiet.aspx.cs" Inherits="Test1.Chitiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .center{
            padding-top:20px;
        }
        .hinhanh{
            width:auto;
            height:auto;
            float:left;
        }
        .hinh{
            width:100px;
            height:150px;
            text-align:center;
        }
        .data2{
            padding-left:10px;
            width:auto;
            height:auto;
            float:right;
        }
        .tensp{
            font-size:20px;
            font-weight:bold;
        }
        .mota,.nxb{
            font-size:18px;
        }
        .gia{
            color:red;
            cursor:pointer;
        }
        #Button1{
            float:left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Chi tiết sản phẩm
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="5">
        <ItemTemplate>
            <div class="center">
                <div class="hinhanh">
                    <asp:Image CssClass="hinh" ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' />
                </div>
                <div class="data2">
                    <asp:Label CssClass="tensp" ID="Label1" runat="server" Text='<%# Eval("TenSach") %>'></asp:Label>
                    <br />
                    <asp:Label CssClass="nxb" ID="Label4" runat="server" Text='<%# Eval("NhaXB") %>'></asp:Label>
                    <br />
                    <asp:Label CssClass="mota" ID="Label3" runat="server" Text='<%#Eval("MoTa")%>'></asp:Label>
                    <br />
                    <asp:Label CssClass="gia" ID="Label2" runat="server" Text='<%#Eval("DonGia","{0:0,0}") + " VND" %>'></asp:Label>
                    <br />                  
                    <asp:Button ID="Button1" runat="server" Text="Mua" OnClick="Button1_Click"/>                                         
                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
