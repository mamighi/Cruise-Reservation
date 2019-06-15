<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="NewTrip.aspx.cs" Inherits="NewTrip" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            margin-bottom: 38;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div id="main">
 
            <div id="site_content">	
            <div style="width:100%+20px; height:50px; background-color:gray;margin-left:-20px;align-content:center" class="auto-style3">
                    <strong>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="ADD NEW TRIP" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
                </div>
             <div style="width:100%; height:500px">
                 <div style="width:150px;height:100%; float:left; line-height:30px">

                     <br />
                     Cruise Code:<br />
                     Cruise Name:<br />
                     Capacity(Person):<br />
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
                     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                     <br />
                     <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                     <br />
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                     <asp:Button ID="Button1" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="20px" Text="..." OnClick="Button1_Click" />
                     <br />
                     <asp:TextBox ID="TextBox3" runat="server" Width="53px"></asp:TextBox>
&nbsp;:
                     <asp:TextBox ID="TextBox4" runat="server" Width="53px"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                     <asp:Button ID="Button2" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="20px" Text="..." OnClick="Button2_Click" />
                     <br />
                     <asp:TextBox ID="TextBox7" runat="server" Width="53px"></asp:TextBox>
&nbsp;:
                     <asp:TextBox ID="TextBox8" runat="server" Width="53px"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                     <br />
                     <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style4" Height="70px" TextMode="MultiLine"></asp:TextBox>
                     <br />
                     <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Error" Visible="False"></asp:Label>
                     <br />
                     <asp:Button ID="Button3" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="20px" Text="Submit" Width="100px" OnClick="Button3_Click" />
                     &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#999966" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="20px" Text="Clear" Width="100px" />
                 </div>
                 <div style="width:420px;height:100%; float:left; line-height:30px">
                     <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False">
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
                     <asp:Calendar ID="Calendar2" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False">
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

