<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="main">
    <div id="site_content">		
         <div style="width:100%+20px; height:50px; background-color:gray;margin-left:-20px;align-content:center" class="auto-style3">
                    <strong>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="LOGIN" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
          </div>
             <div style="width:100%; height:500px" class="auto-style3">
                 <br />
                 <span class="auto-style4">Wrong User Name or Password<br />
                 <br />
                 </span>UserName:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                 <br />
                 Password:
                 <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Button ID="Button4" runat="server" BackColor="#999966" BorderColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button4_Click" Text="Login" Width="100px" />
&nbsp;<asp:Button ID="Button5" runat="server" BackColor="#999966" BorderColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button5_Click" Text="Register" Width="100px" />
                 <br />
                 </div>
        </div>
         </div>
</asp:Content>

