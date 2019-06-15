<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="AdminHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
         <div id="main">
 
            <div id="site_content">	
    <div class="slideshow">  
		<ul class="slideshow">
          <li><img width="900" height="250" src="Image/Cruise-travel-agents.jpg"  /></li>

        </ul> 
      </div><!--close slideshow-->		
	  
	  <div class="ourwork" style="height:150px">
	    <h3>New Cruise</h3>
          <p>You can add new cruise with all information and three type of cabin which are economic, premium and luxury here.</p>
          <p>
              <asp:Button ID="Button1" runat="server" BorderStyle="None" OnClick="Button1_Click" Text="GO -&gt;" Width="80px" />
          </p>
          <p>&nbsp;</p>
		  <!--close more-->      
	  </div><!--close ourwork-->
	  <div class="testimonials" style="height:150px">
	    <h3>New Trip</h3>
          <p>You can add new trip by choosing the cruise departure and destination details and rates here.</p>
          <asp:Button ID="Button2" runat="server" BorderStyle="None" OnClick="Button2_Click" Text="GO -&gt;" Width="80px" />
		  <!--close more-->        
	  </div><!--close testimonials-->	  
	  <div class="projects" style="height:150px">
	    <h3>Report</h3>
          <p>You can generate all kind of report about all kind of trip here with all details.</p>
          <p>&nbsp;</p>
          <p>
              <asp:Button ID="Button3" runat="server" BorderStyle="None" OnClick="Button3_Click" Text="GO -&gt;" Width="80px" />
          </p>
          <p>&nbsp;</p>
		  <!--close more-->        
	  </div><!--close projects-->	
                </div>
             </div>	 
</asp:Content>

