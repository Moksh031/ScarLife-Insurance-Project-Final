<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewproduct.aspx.cs" Inherits="WebApplication7.viewproduct" %>

<!DOCTYPE html>

 

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
   
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />

<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>

<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />

<meta name="viewport" content="width=device-width, initial-scale=1" />

  
    <style type="text/css">
        <style type="text/css">
         @media (min-width: 992px) {
  .navbar {
    width: 87%;
    height: 100vh;
   
  }
  form input {
    margin-bottom: 0.7em;
  }
}
        
        .auto-style1 {
            margin-top: 0px;
        }
        #img{
            background-image:url(img4f.jpg);
            height:400px;
            background-repeat:no-repeat;
            background-position:center;
            width:100%;
            
        }
        body{
           
          
            margin-bottom:0px;
            margin-left:0px;
            margin-right:0px;
            margin-top:0px;
        }
        #Label1{
            font-size:70px;
        }
        #nav{
            background-color:royalblue;
            height:140px;
               

        }
       #one{
           background-color:gray;
           height:180px;
           
           
           
       }
       
     

.material-symbols-outlined {
  font-variation-settings:
  'FILL' 0,
  'wght' 400,
  'GRAD' 0,
  'opsz' 48
}

        .auto-style2 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 40%;
            height: 600px;
            left: 46px;
            top: 21px;
            padding-left: 15px;
            padding-right: 15px;
        }
        #side{border:4px solid;
            border-radius:40px;
            border-color:dodgerblue;
        }
        #data{
            border:6px solid;
            border-color:dodgerblue;
            border-radius:40px;
        }

        .auto-style3 {
            margin-right: -15px;
            margin-left: -15px;
            height: 956px;
            width: 100%;
            margin-bottom: 218px;
        }
        
        .auto-style5 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 51%;
            height: 738px;
            left: -2px;
            top: -3px;
            padding-left: 15px;
            padding-right: 15px;
        }
        #main{
            height:100vh;
        }
        .auto-style6 {
            height: 1417px;
        }
        </style>  </head>
<body>
    <form id="form1" runat="server" class="auto-style6">
        <div id="main">
       <div id="nav">
            
           
                <p>
&nbsp;
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style1" Height="91px" Width="96px" ImageUrl="~/logo1.png" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server"  ForeColor="White" Text="Scar Life Insurance" Font-Bold="False"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:LinkButton ID="LinkButton1" runat="server" Font-Size="XX-Large" Font-Underline="False" ForeColor="White" OnClick="LinkButton1_Click"  >Home</asp:LinkButton>
&nbsp;&nbsp;
&nbsp;
                    <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="XX-Large" Font-Underline="False" ForeColor="White" OnClick="LinkButton2_Click">Why Insurance</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
                    <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="XX-Large" ForeColor="White" Font-Underline="False" OnClick="LinkButton3_Click" >Logout</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
                    &nbsp;
                    </p>
            
        </div>
        <div class="auto-style3" style="width:100%;height:812px">
              <br /><br />
            <div class="auto-style2"><br /><nav class="navbar navbar-expand-lg navbar-light" id="side" style="background-color:dodgerblue; height: 740px; left: -5px; top: -42px; width: 476px;">
                &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label11" runat="server"  ForeColor="Black" Text="Admin Panel" Font-Size="XX-Large"></asp:Label>
                <br />
                <br />
                <br /> &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button13" runat="server"  Text="Add Product" BackColor="DodgerBlue" BorderStyle="Solid" BorderWidth="3px" Height="88px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" OnClick="Button13_Click"   />
           <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
                
           
            

            
    
          
            <asp:Button ID="Button2" runat="server" Text="View Product" BackColor="DodgerBlue" BorderStyle="Solid" BorderWidth="3px" Height="88px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" Font-Underline="True" />
       
           
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Button ID="Button14" runat="server"  Text="Add SubProduct" BorderStyle="Solid" BorderWidth="3px" Height="88px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" BackColor="DodgerBlue" Font-Underline="False" OnClick="Button14_Click"  />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;

  
           
                <asp:Button ID="Button5" runat="server" BackColor="DodgerBlue" Text="View SubProduct" BorderStyle="Solid" BorderWidth="3px" Height="88px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" OnClick="Button5_Click"    />
          
                <br />
          
                &nbsp;&nbsp;&nbsp;&nbsp;
 

  
           
                <asp:Button ID="Button10" runat="server" BackColor="DodgerBlue" Text="View Agents" BorderStyle="Solid" BorderWidth="3px" Height="87px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" Font-Underline="False" OnClick="Button10_Click"  />
          
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
 

  
           
                <asp:Button ID="Button11" runat="server" BackColor="DodgerBlue" Text="View Feedbacks" BorderStyle="Solid" BorderWidth="3px" Height="87px" Width="407px" BorderColor="Black" Font-Size="XX-Large" ForeColor="White" OnClick="Button11_Click"   />
          
               </nav></div>
               <div class="auto-style5" id="data">


                   <br />


<asp:GridView ID="GridView1" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDataBound="GridView1_RowDataBound1" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing1" OnRowUpdating="GridView1_RowUpdating1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" Height="504px" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" Width="767px" >
<AlternatingRowStyle BackColor="White" />
  <Columns>

<asp:TemplateField HeaderText="Image">
<ItemTemplate>
<asp:Image ID="Image1" runat="server" height="50px"  Width="50px"/>
</ItemTemplate>
    <ControlStyle Height="120px" Width="120px" />
</asp:TemplateField>
</Columns>
<EditRowStyle BackColor="#7C6F57" />
<FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
<HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
<PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
<RowStyle BackColor="#E3EAEB" />
<SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
<SortedAscendingCellStyle BackColor="#F8FAFA" />
<SortedAscendingHeaderStyle BackColor="#246B61" />
<SortedDescendingCellStyle BackColor="#D4DFE1" />
<SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView></div></div>
  
        
   
   
    <!--Footer-->
      
        <div id="one">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="fa fa-envelope-o" aria-hidden="true"style='font-size:28px;'></i>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">Email:</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="LinkButton11" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4" >inquiry@scarlife.com</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i class="fa fa-phone" aria-hidden="true"style='font-size:28px;'></i>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">Call:</asp:LinkButton>
            &nbsp;&nbsp;<asp:LinkButton ID="LinkButton12" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">9999-999-999</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton6" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">About Us</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton9" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">Terms Of Services</asp:LinkButton>
            
           

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton10" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">Follow us On:-</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp 
          <a href="https://facebook.com"> <i class="fa fa-facebook-square" aria-hidden="true" style='font-size:40px;'></i></a> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="https://instagram.com">    <i class="fa fa-instagram" aria-hidden="true" style='font-size:40px;'></i></a>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <a href="https://LinkedIn.com">   <i class="fa fa-linkedin-square" aria-hidden="true" style='font-size:40px;'></i></a>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <a href="https://Twitter.com">    <i class="fa fa-twitter" aria-hidden="true" style='font-size:40px;'></i></a>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton7" runat="server" Font-Size="X-Large" Font-Underline="False" ForeColor="#F4F4F4">Faqs</asp:LinkButton>
            <br />

          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

          <br />    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="X-Large" Text="© Scar Life Insurance, Inc. All rights reserved." ForeColor="White"></asp:Label>
        
            
        </div></div> </form>
</body>
</html>