<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Cruies.aspx.cs" Inherits="Cruies" %>

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
                    <asp:Label ID="Label1" runat="server" Text="VIEW-EDIT CRUISE" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
                </div>
                <div style="width:100%; height:500px">
                    <div style="width: 100px; height: 100%; float:left; line-height:30px">
                        <br />
                       Cruise Code:

                        <br />
                        Cruise Name:<br />
                        Cabines Number:<br />
                        Agent Company:<br />
                        Description:</div>
                    <div style="width:250px; height:100%; float:left; line-height:30px">

                        <br />
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="181px" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                        <br />
                        <asp:TextBox ID="TextBox2" runat="server" Width="181px" ReadOnly="True"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server" Width="181px" ReadOnly="True"></asp:TextBox>
                        <br />
                        <asp:TextBox ID="TextBox17" runat="server" Width="181px" ReadOnly="True"></asp:TextBox>

                        <br />
                        <asp:TextBox ID="TextBox16" runat="server" Height="76px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />

                    </div>
                    <div style="width:570px; height:150px; float:left; line-height:30px">
                        <div style="width:100%; height:30px; background-color:silver">
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                            <strong>
                            <asp:Label ID="Label2" runat="server" Text="Economic" CssClass="auto-style1"></asp:Label>
                            </strong>
                        </div>
                        <div style="width:150px; height:120px; line-height:30px;float:left">
                            
                            Cabines Number:<br />
                            Rate Multiple(1-3):<br />
                            Capacity(Persons):<br />
                            Description:</div>
                        <div style="width:420px; height:120px; line-height:30px;float:left">

                            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox7" runat="server" Width="400px" ReadOnly="True"></asp:TextBox>

                        </div>
                    </div>
                    <div style="width:570px; height:150px; float:left; line-height:30px">
                           <div style="width:100%; height:30px; background-color:silver">
                               <asp:CheckBox ID="CheckBox2" runat="server" />
                               <strong>
                               <asp:Label ID="Label3" runat="server" Text="Premium" CssClass="auto-style1"></asp:Label>
                               </strong>
                           </div>
                                                <div style="width:150px; height:120px; line-height:30px;float:left">
                            
                            Cabines Number:<br />
                            Rate Multiple(1-3):<br />
                            Capacity(Persons):<br />
                            Description:</div>
                        <div style="width:420px; height:120px; line-height:30px;float:left">

                            <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox10" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox11" runat="server" Width="400px" ReadOnly="True"></asp:TextBox>

                        </div>
                    </div>
                    <div style="width:570px; height:150px; float:left; line-height:30px">
                           <div style="width:100%; height:30px; background-color:silver">
                               <asp:CheckBox ID="CheckBox3" runat="server" />
                               <strong>
                               <asp:Label ID="Label4" runat="server" Text="Luxury" CssClass="auto-style1"></asp:Label>
                               </strong>
                            </div>
                                                <div style="width:150px; height:120px; line-height:30px;float:left">
                            
                            Cabines Number:<br />
                            Rate Multiple(1-3):<br />
                            Capacity(Persons):<br />
                            Description:</div>
                        <div style="width:420px; height:120px; line-height:30px;float:left">

                            <asp:TextBox ID="TextBox12" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True"></asp:TextBox>
                            <br />
                            <asp:TextBox ID="TextBox15" runat="server" Width="400px" ReadOnly="True"></asp:TextBox>

                        </div>
                    </div>

                    </div>
                </div>
                
            </div>
     
</asp:Content>

