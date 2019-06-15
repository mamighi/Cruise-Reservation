<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="main">
    <div id="site_content">		

      <div class="slideshow">  

          <li><img width="900" height="250" src="Image/Cruise-travel-agents.jpg" /></li>
         
        
      </div><!--close slideshow-->		
	  
	  <div class="ourwork" style="height:150px">
	    <h3>Check Cruise</h3>
		<p>You can chek all about available trip here chose your trip date, and reserve a cruise.</p>
          <p>
              <asp:Button ID="Button3" runat="server" BorderStyle="None" Text="GO-&gt;" Width="100px" OnClick="Button3_Click" />
          </p>
		  <!--close more-->      
	  </div><!--close ourwork-->
	  <div class="testimonials" style="height:150px">
	    <h3>Check Reservation</h3>
		<p>You can check you reservation with all details and cancel them here.</p>
          <p>&nbsp;</p>
          <p>
              <asp:Button ID="Button6" runat="server" BorderStyle="None" Text="GO-&gt;" Width="100px" OnClick="Button6_Click" />
          </p>
          <p>&nbsp;</p>
	  </div><!--close testimonials-->	  
	  <div class="projects" style="height:150px">
	    <h3>About Us</h3>
		<p>Princess Cruises and its British-based counterpart, the Cunard Line, are two of the largest cruise operators in the world.</p>
          <p>
              <asp:Button ID="Button7" runat="server" BorderStyle="None" Text="GO-&gt;" Width="100px" OnClick="Button7_Click" />
          </p>	  
		  <!--close more-->        
	  </div><!--close projects-->		 
	 
	  <div id="content">
        <div class="content_item">
		  <h1>&nbsp;</h1> 
          <p>&nbsp;</p>   				  
		</div><!--close content_item-->
      </div><!--close content-->   
	
	</div><!--close site_content--> 
    
	<div id="content_grey">
	    <!--close content_grey_container_box-->
        <!--close content_grey_container_box-->
        <!--close content_grey_container_box1-->      
	  <br style="clear:both"/>
    </div><!--close content_grey-->
        </div> 
</asp:Content>

