<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="Report" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
 
            <div id="site_content">	
            <div style="width:100%+20px; height:50px; background-color:gray;margin-left:-20px;align-content:center" class="auto-style3">
                    <strong>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="REPORT" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
                </div>
             <div style="width:100%+20px; height:50px; background-color:silver;margin-left:-20px;align-content:center" class="auto-style4">

                 <br />
                 <strong>&nbsp;&nbsp;&nbsp;
                 <asp:RadioButton ID="RadioButton1" runat="server" CssClass="auto-style1" Text="ALL" Checked="True" GroupName="a" AutoPostBack="True" OnCheckedChanged="RadioButton1_CheckedChanged" />
                 </strong>&nbsp;<strong><asp:RadioButton ID="RadioButton2" runat="server" CssClass="auto-style1" Text="AVAILABLE" GroupName="a" AutoPostBack="True" OnCheckedChanged="RadioButton2_CheckedChanged" />
                 </strong>&nbsp;<strong><asp:RadioButton ID="RadioButton3" runat="server" CssClass="auto-style1" Text="SOLD OUT" GroupName="a" AutoPostBack="True" OnCheckedChanged="RadioButton3_CheckedChanged" />
                 </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
                 <asp:RadioButton ID="RadioButton4" runat="server" CssClass="auto-style1" Text="ALL" Checked="True" GroupName="b" AutoPostBack="True" OnCheckedChanged="RadioButton4_CheckedChanged" />
                 </strong>&nbsp;<strong><asp:RadioButton ID="RadioButton5" runat="server" CssClass="auto-style1" Text="PERIVIOUS" GroupName="b" AutoPostBack="True" OnCheckedChanged="RadioButton5_CheckedChanged" />
                 </strong>&nbsp;<strong><asp:RadioButton ID="RadioButton6" runat="server" CssClass="auto-style1" Text="NEXT" GroupName="b" AutoPostBack="True" OnCheckedChanged="RadioButton6_CheckedChanged" />
                 </strong>

             </div>
             <div style="width:100%; height:500px">


                 <asp:Table ID="Table1" runat="server" Width="100%">
                     <asp:TableRow runat="server" BackColor="Black" Height="30px">
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Trip Code</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Departure</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Dep Time</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Arr Time</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Base Price</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Av. Economic</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Av. Premium</asp:TableCell>
                         <asp:TableCell runat="server" Font-Bold="True" ForeColor="White" HorizontalAlign="Center">Av. Luxury</asp:TableCell>
                     </asp:TableRow>
                 </asp:Table>


             </div>
       </div>
    </div>
</asp:Content>

