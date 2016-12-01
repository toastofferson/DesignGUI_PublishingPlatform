﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Consumer._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="Content/carousel.css" />
    <link rel="stylesheet" href="Content/Site.css" />
    <link rel="stylesheet" href="fonts/style.css" />
    <script src="carousel.js"></script>

 <style>
     .btn-transparent {
         background: transparent;
         border: 3px solid #fff;
         padding: 15px 30px;
         font-size: 14px;
         border-radius: 0;
         color: #fff;
         font-weight: 700;
         letter-spacing: 0.05em;
         text-transform: uppercase;
     }

    .btnDownloadDefault {
        -webkit-appearance: none;
        -moz-appearance: none;
        outline: none;
        border: 0;
        background: transparent;
    }

	</style>

<section style="margin-bottom:50px">
    <div class="containerSpecial">
        <div id="titleHome">
            <h2><span>ADE </span>1.0</h2>
            <h3>Antenna Design Explorer</h3>
            <hr class="light-sep">
        </div>
       <table style="width:100%;border-collapse: collapse;border-spacing: 0;margin-bottom:20px">
           <tr>
                <td style="width:800px;vertical-align:top">
                    <div>
                        <h4 style="text-align:left;">About ADE 1.0</h4>
                        <p style="text-align:justify;font-size:12.5px">Developed by the <a href="~/">CADES Research Centre</a>, the Antenna Design Explorer (ADE) 1.0 is a Graphics 
                                    User Interface (GUI)-based optimisation tool that runs in the MATLAB environment. The aim 
                                    of ADE 1.0 is to optimize antenna geometrical design parameters so as to satisfy the design
                                    specifications and optimize the selected performance(s) in an EFFICIENT manner. At present, 
                                    local optimization and global optimization methods are included in many existing antenna design 
                                    explorers or optimizers (e.g. CST optimizer, MATLAB optimization or global optimization toolbox
                                    and ADS optimization tool). Local optimization methods require a good initial design, which is 
                                    often not available; global optimization methods can often obtain a good design, but they cost
                                    very long or prohibitive time. ADE 1.0 is proposed to address this challenge. 
                                    </p>
                                    <p style="text-align:justify;font-size:12.5px">
                                        To run the ADE 1.0, the user-defined inputs include the antenna simulation model or evaluation file, 
                                        antenna design variables and their design ranges, optimization goal(s) and constraints. Currently, 
                                        three optimisation algorithms are carefully selected in the ADE 1.0: the surrogate assisted 
                                        differential evolution algorithm (SADEA), the differential evolution (DE) algorithm and the 
                                        multi objective evolutionary algorithm based on decomposition (MOEA/D). ADE 1.0 also allows users
                                        to adopt customized algorithms or evaluation functions depending on what is most suitable for
                                        the antenna problem. The output of the ADE 1.0 is an antenna profile with optimal geometrical design
                                        parameters.
                                    </p>
                                <br>
		        </div><%--ABOUT--%>
                    <div style="margin-top:10px;">
                            <h4 style="text-align:left;">Key Features</h4>
                            <p style="text-align:justify;font-size:12.5px">Some of the key features of the ADE 1.0 include, but are not limited to:</p>
                            <ul class="listkey" style="text-align:left;color:#1879ba;">
                                <li><b>Selection and integration of state-of-the-art antenna design exploration approaches and methods
                                    to tackle EFFICIENT antenna optimization over a very broad scope of antenna problems.</b></li>
                                <li><b>Enhanced usability developed by addressing Human-computer Interaction (HCI) issues peculiar
                                    to antenna design engineers who are not familiar with design automation and optimization.</b></li>
                                <li><b>Conjunctive operations with an existing parallel simulation and optimization tool through
                                    a seamless link: CST Microwave Studio.</b></li>
                            </ul>
                            <br>
                            <p style="text-align:left;color:red">
                                Please, click <a href="~/">‘ADE 1.0 Users’ Guide’</a> to download and view the full features of the ADE 1.0
                            </p>
		            </div><%--KeyFeature--%>
                </td>
               <td style="width:50px"></td>
               <td style="width:400px;vertical-align:top">
            <div class="carousel slide" id="myCarousel" style="text-align:center">
            <!--Indicator-->
              <ol class="carousel-indicators">
                  <li class="active" data-target="#myCarousel" data-slide-to="0"></li>
                  <li data-target="#myCarousel" data-slide-to="1"></li>
                  <li data-target="#myCarousel" data-slide-to="2"></li>
              </ol>
            <!--Wrapper for slides-->
            <div class="carousel-inner">
                <div class="item active" id="slide1">
                        <div class="carousel-caption">
                            <h1><span>ADE </span>1.0</h1>
                            <h3>Antenna Design Explorer</h3>
                            <br />
                            <a class="btn btn-transparent" href="/Software">Download</a>
                        </div>
                </div>
                <div class="item" id="slide2">
                        <div class="carousel-caption">
                            <h1><span>ADE </span>1.0</h1>
                            <h3>Antenna Design Explorer</h3>
                            <br />
                            <a class="btn btn-transparent" href="/Tutorials">Tutorials</a>
                        </div>
                </div>
                <div class="item" id="slide3">
                        <div class="carousel-caption">>
                            <h1><span>ADE </span>1.0</h1>
                            <h3>Antenna Design Explorer</h3>
                            <br />
                            <a class="btn btn-transparent" href="/Contact">Contact us</a>
                        </div>
                </div>
            </div>
            <!--Control-->
            <a class="left carousel-control" data-slide="prev" href="#myCarousel"><span class="icon-prev"></span></a>
            <a class="right carousel-control" data-slide="next" href="#myCarousel"><span class="icon-next"></span></a>
        </div><!-- END CAROUSEL-->
                    <div id="videoYtb">
                        <iframe runat="server" id="ifYt" class='tutovideo' width='560' height='315' ClientIDMode="static"></iframe>
                    </div>
               </td>
            </tr>
        </table>
    </div>
</section>






</asp:Content>

