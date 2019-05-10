<%@ Page Title="" Language="C#" MasterPageFile="~/kullanici.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="emlakcim._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <!-- Insert to your webpage before the </head> -->
    <script src="sliderengine/jquery.js"></script>
    <script src="sliderengine/amazingslider.js"></script>
    <link rel="stylesheet" type="text/css" href="sliderengine/amazingslider-1.css">
    <script src="sliderengine/initslider-1.js"></script>
    <!-- End of head section HTML codes -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:700px;float:left;height:auto">
        <div style="width:680px; margin:0 auto;float:left">
             <!-- Insert to your webpage where you want to display the slider -->
    <div id="amazingslider-wrapper-1" style="display:block;position:relative;max-width:600px;margin:0px auto 6px;">
        <div id="amazingslider-1" style="display:block;position:relative;margin:0 auto;">
            <ul class="amazingslider-slides" style="display:none;">
                
                <asp:DataList ID="dl_slider" runat="server">
                    <ItemTemplate>
<li><img src="<%#Eval("ilanVitResim") %>"" alt="<%#Eval("ilanBaslik") %>""  title="ev" data-description="<%#Eval("ilanFiyat") %>"" />
                </li>
                    </ItemTemplate>
                </asp:DataList>
            </ul>
            <ul class="amazingslider-thumbnails" style="display:none;">
                <li><img src="vresim/ev-tn.jpg" alt="ev" title="ev" /></li>
                <li><img src="vresim/ev%20%283%29-tn.jpg" alt="ev (3)" title="ev (3)" /></li>
                <li><img src="vresim/ev%20%284%29-tn.jpg" alt="ev (4)" title="ev (4)" /></li>
                <li><img src="vresim/ev%20%285%29-tn.jpg" alt="ev (5)" title="ev (5)" /></li>
                <li><img src="vresim/ev%20%282%29-tn.jpg" alt="ev (2)" title="ev (2)" /></li>
            </ul>
        <div class="amazingslider-engine"><a href="http://amazingslider.com" title="jQuery Slideshow">jQuery Slideshow</a></div>
        </div>
    </div>
    <!-- End of body section HTML codes -->
    

        </div>
    </div>
</asp:Content>
