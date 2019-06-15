<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
                    <asp:Label ID="Label1" runat="server" Text="REGISTARTION" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
          </div>
             <div style="width:100%; height:500px">
                                <div style="width:150px;height:100%; float:left; line-height:30px">
                                    <br />
                                    User Name:<br />
                                    Password:<br />
                                    Re-Password:<br />
                                    First Name:<br />
                                    Last Name:<br />
                                    Email:<br />
                                    Contact Number:

                                </div>
                  <div style="width:250px;height:100%; float:left; line-height:30px">
                      <br />
                      <asp:TextBox ID="TextBox3" runat="server" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox6" runat="server" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox7" runat="server" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox8" runat="server" Width="180px"></asp:TextBox>
                      <br />
                      <asp:TextBox ID="TextBox9" runat="server" Width="180px"></asp:TextBox>
                      <br />
                      <br />
                      <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                      <br />
                      <br />
                      <asp:Button ID="Button3" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button3_Click" Text="Submit" Width="100px" />
&nbsp;
                      <asp:Button ID="Button4" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Text="Clear" Width="100px" />
                  </div>
              </div>
        </div>

        </div>
</asp:Content>

