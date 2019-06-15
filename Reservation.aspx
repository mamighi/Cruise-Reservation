<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
    <div id="site_content">		
         <div style="width:100%+20px; height:50px; background-color:gray;margin-left:-20px;align-content:center" class="auto-style3">
                    <strong>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="RESERVATION" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
          </div>
             <div style="width:100%; height:500px">
                 <div style="width:150px;height:100%; float:left; line-height:30px">
                     <br />
                     Departure Location:<br />
                     Distenation:<br />
                     Departure Date:<br />
                     <br />
                     <br />
                     Persons:<br />
                     Cabint Type:<br />
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                 </div>
                 <div style="width:250px;height:100%; float:left; line-height:30px">
                     <br />
                     <asp:DropDownList ID="DropDownList1" runat="server" Width="180px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                     </asp:DropDownList>
                     <br />
                     <asp:DropDownList ID="DropDownList2" runat="server" Width="180px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                     </asp:DropDownList>
                     <br />
                     <asp:ListBox ID="ListBox1" runat="server" Height="90px" Width="180px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                     <br />
                     <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" Width="180px"></asp:TextBox>
                     <br />
                     <asp:RadioButton ID="RadioButton1" runat="server" GroupName="a" Text="Economic" OnCheckedChanged="RadioButton1_CheckedChanged" />
                     <br />
                     <asp:RadioButton ID="RadioButton2" runat="server" GroupName="a" Text="Premium" OnCheckedChanged="RadioButton2_CheckedChanged" />
                     <br />
                     <asp:RadioButton ID="RadioButton3" runat="server" GroupName="a" Text="Luxury" OnCheckedChanged="RadioButton3_CheckedChanged" />
                     <br />
                     <br />
                     <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                     <br />
                     <asp:Button ID="Button3" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Submit" Width="100px" OnClick="Button3_Click" />
&nbsp;
                     <asp:Button ID="Button4" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Clear" Width="100px" />
                 </div>
                 <div id="resdiv" runat="server" style="width:520px; height:250px; float:left; line-height:30px">
                        <div style="width:100%; height:30px; background-color:silver" class="auto-style3">
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Economic" CssClass="auto-style1"></asp:Label>
                            </strong>
                        </div>
                        <div style="width:130px; height:220px; line-height:30px;float:left">
                            
                            Arrival Date:<br />
                            Arrival Time:<br />
                            
                            Cabines Number:<br />
                            Price Per Cabin:<br />
                            Capacity(Persons):<br />
                            Description:<br />
                            Total Amount:</div>
                        <div style="width:390px; height:220px; line-height:30px;float:left">

                            <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />

                            <asp:Label ID="Label10" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />

                            <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="#003366" Text="Label"></asp:Label>
                            <br />

                        </div>
                    </div>
                 <div style="width:520px; height:200px; float:left; line-height:30px">

                     <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                     <br />
                     <asp:Button ID="Button5" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Reserve" Width="100px" OnClick="Button5_Click" Visible="False" />

             </div>

    </div>
    </div>
    </div>
</asp:Content>

