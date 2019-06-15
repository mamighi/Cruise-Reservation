<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="CheckReservation.aspx.cs" Inherits="CheckReservation" %>

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
                    <asp:Label ID="Label1" runat="server" Text="CHECK RESERVATION" CssClass="auto-style4" style="color: #FFFFFF; font-size: x-large" ></asp:Label>
                    </strong>
          </div>
             <div style="width:100%; height:500px">
                 <div style="width:150px;height:100%; float:left; line-height:30px">
                     <br />
                     Reservation ID:<br />
                     Departure Location:<br />
                     Departure Date:<br />
                     Departure Time:<br />
                     Destnation:<br />
                     Arrival Date:<br />
                     Arrival Time:<br />
                     Person:<br />
                     Cabin Type:<br />
                     Cabin Number:<br />
                     </div>
                 <div style="width:250px;height:100%; float:left; line-height:30px">
                     <br />
                     <asp:DropDownList ID="DropDownList1" runat="server" Width="150px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="height: 20px" AutoPostBack="True">
                     </asp:DropDownList>
&nbsp;
                     <br />
                     <asp:Label ID="Label3" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label4" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label5" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label6" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label7" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label8" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label9" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label10" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label11" runat="server"></asp:Label>
                     <br />
                 </div>
                 <div style="width:150px;height:100%; float:left; line-height:30px">
                     <br />
                     Total Amount:<br />
                     Status:</div>
                 <div style="width:250px;height:100%; float:left; line-height:30px">
                     <br />
                     <asp:Label ID="Label15" runat="server"></asp:Label>
                     <br />
                     <asp:Label ID="Label16" runat="server"></asp:Label>
                     <br />
                     <br />
                 </div>
              </div>
        </div>
         </div>

</asp:Content>

