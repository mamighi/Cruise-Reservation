<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Trip.aspx.cs" Inherits="Trip" %>

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
                    <asp:Label ID="Label1" runat="server" Text="VIEW-EDIT TRIP" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
                </div>
             <div style="width:100%; height:500px">
                 <div style="width:150px;height:100%; float:left; line-height:30px">

                     <br />
                     Trip ID:<br />
                     Cruise Name:<br />
                     Capacity(Cabin):<br />
                     Departure Location:<br />
                     Departure Date:<br />
                     Departure Time:<br />
                     Arrival Location:<br />
                     Arrival Date:<br />
                     Arrivarl Time:<br />
                     Base Price:<br />
                     Description:<br />

                 </div>
                 <div style="width:250px;height:100%; float:left; line-height:30px">
                     <br />
                     <asp:DropDownList ID="DropDownList1" runat="server" Width="124px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                     </asp:DropDownList>
                     <br />
                     <asp:Label ID="Label2" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label3" runat="server"></asp:Label>
                     <br />
                     <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox3" runat="server" Width="53px" ReadOnly="True"></asp:TextBox>
&nbsp;:
                     <asp:TextBox ID="TextBox4" runat="server" Width="53px" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox7" runat="server" Width="53px" ReadOnly="True"></asp:TextBox>
&nbsp;:
                     <asp:TextBox ID="TextBox8" runat="server" Width="53px" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox9" runat="server" ReadOnly="True"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style4" Height="70px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                     <br />
                     <br />
                     &nbsp;<br />
                 </div>
                 <div style="width:420px;height:100%; float:left; line-height:30px">
                     <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" Visible="False">
                         <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                         <DayStyle Width="14%" />
                         <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                         <OtherMonthDayStyle ForeColor="#999999" />
                         <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                         <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                         <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                         <TodayDayStyle BackColor="#CCCC99" />
                     </asp:Calendar>
                     <br />
                     <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" Visible="False">
                         <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                         <DayStyle Width="14%" />
                         <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                         <OtherMonthDayStyle ForeColor="#999999" />
                         <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                         <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                         <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                         <TodayDayStyle BackColor="#CCCC99" />
                     </asp:Calendar>
                 </div>
             </div>
            
            </div>
          </div>
</asp:Content>

