<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HijaAdmin.aspx.cs" Inherits="VIEW.HijaAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <!--Home page style-->
        <header id="home" class="home">
			<div class="overlay sections">
				<div class="container">
					
					<div class="row">
						<div class="wrapper">
							<div class="col-md-6 col-md-offset-3">
								
								<div class="home-details text-center" style="margin-top:-10px;">
									
                                    <div class="home-title">
										<h1><span>Airline</span></h1>
									</div>

									<div class="logo">
										<img src="assets/images/avion4.png" alt="Logo Image" />
									</div>
									
									<div class="scroll-down">
										<h5>Scroll down to see more</h5>
										<a href="#about"><i class="fa fa-angle-double-down"></i></a>
									</div>

								</div>
									
							</div>
						</div>
					</div>
				</div>
			</div>
        </header>

        <!-- Sections -->
        <section id="Airplane" class="about sections" style="padding-top: 170px;">
            <div class="container">

                <div class="row">
                    <div class="wrapper">
					
                    	<div class="col-md-6">
                    		<div class="about-photo">
								<img src="assets/images/avion3.png" alt="About Image" />
							</div>
                    	</div>
						
						<div class="col-md-6">
                    		<div class="heading about-content" style="text-align:center;">
								<h3>Register Airplane</h3>
							</div>
                            <div style="margin-top:-15px;">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtModelo" CssClass="form-control" placeholder="Model Airplane" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtCantidad" CssClass="form-control" placeholder="Number of Airplanes" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtCapacidadPasajeros" CssClass="form-control" placeholder="Number of Passengers" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtCapcidadCarga" CssClass="form-control" placeholder="Loading capacity" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtAutonomia" CssClass="form-control" placeholder="Flight hours" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4">
                                        <asp:Button ID="btnRegisterAirplane" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegisterAirplane_Click" />
                                    </div>
                                </div>
                            </div>
                    	</div>

                    </div>
                </div>
				
            </div> <!-- /container -->       
        </section>
		
		<!-- Sections -->
        <section id="Route" class="portfolio" style="padding-top: 70px;">
			<div class="overlay sections">
				<div class="container">

                     <div class="row">
                        <div class="wrapper">
					
                    	    <div class="col-md-6">
                    		    <div class="about-photo">
								    <img src="assets/images/avion2.png" alt="About Image" />
							    </div>
                    	    </div>
						
						    <div class="col-md-6">
                    		    <div class="heading about-content" style="text-align:center; color:white;">
								    <h3>Register Route</h3>
							    </div>
                                <div style="margin-top:-15px;">
                                    <div class="row">
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtCodigo" CssClass="form-control" placeholder="Code Route" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtOrigen" CssClass="form-control" placeholder="Origin" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtDestino" CssClass="form-control" placeholder="Destination" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtPrecio" CssClass="form-control" placeholder="Price" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtTiempo" CssClass="form-control" placeholder="Flight Time" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtMillas" CssClass="form-control" placeholder="Miles" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-4">
                                            <asp:Button ID="btnRegisterRoute" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegisterRoute_Click" />
                                        </div>
                                    </div>
                                </div>
                    	    </div>

                        </div>
                    </div>
					
				</div> <!-- /container -->
			</div>	
        </section>

        <!-- Sections -->
        <section id="pilot" class="about sections" style="padding-top: 170px; margin-bottom:auto;">
            <div class="container">

                <div class="row">
                    <div class="wrapper">
					
                    	<div class="col-md-6">
                    		<div class="about-photo">
								<img src="assets/images/pilot.png" alt="About Image" />
							</div>
                    	</div>
						
						<div class="col-md-6">
                    		<div class="heading about-content" style="text-align:center;">
								<h3>Register Pilot</h3>
							</div>
                            <div style="margin-top:-15px;">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtNombrePiloto" CssClass="form-control" placeholder="Full Name" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtIdentificacionPiloto" CssClass="form-control" placeholder="Identification" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4">
                                        <asp:Button ID="btnRegisterPilot" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegisterPilot_Click" />
                                    </div>
                                </div>
                            </div>
                    	</div>

                    </div>
                </div>
				
            </div> <!-- /container -->       
        </section>

        <!-- Section -->
        <section id="flight" class="traveled" style="margin-top:100px;">
			<div class="overlay sections">
				<div class="container">

                     <div class="row">
                        <div class="wrapper">
					
                    	    <div class="col-md-6">
                    		    <div class="about-photo">
								    <img src="assets/images/trav2.png" alt="About Image" />
							    </div>
                    	    </div>
						
						    <div class="col-md-6">
                    		    <div class="heading about-content" style="text-align:center; color:white;">
								    <h3>Register flight</h3>
							    </div>
                                <div style="margin-top:-15px;">
                                    <div class="row">
                                        <div class="col-lg-6">
                                            <asp:DropDownList ID="DdLTrayecto" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                                <asp:ListItem Value="" Text="Select Route" Selected="True"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:DropDownList ID="DdLAeronave" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                                <asp:ListItem Value="" Text="Select Airplane" Selected="True"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:DropDownList ID="DdLPilot" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                                <asp:ListItem Value="" Text="Select Pilot" Selected="True"></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtFechaSalida" CssClass="form-control" placeholder="Departure Date" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtHoraSalida" CssClass="form-control" placeholder="Departure Time" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtFechaRegreso" CssClass="form-control" placeholder="Return Date" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtHoraRegreso" CssClass="form-control" placeholder="Return Time" runat="server"></asp:TextBox>
                                        </div>
                                        <div class="col-lg-6">
                                            <asp:TextBox ID="txtNombreVuelo" CssClass="form-control" placeholder="Flight Name" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-lg-4">
                                            <asp:Button ID="btnRegisterVuelo" CssClass="btn btn-success" runat="server" Text="Register" OnClick="btnRegisterVuelo_Click" />
                                        </div>
                                    </div>
                                </div>
                    	    </div>

                        </div>
                    </div>
					
				</div> <!-- /container -->
			</div>	
        </section>
		
        <!-- Sections -->
		<section id="contact" class="contact sections">
			<div class="container">
				<div class="row">
					<div class="col-md-6 col-md-offset-3">
						<div class="contact-details text-center">

                            <div class="home-title">
								<h1 style="color:black;"><span>Contact</span></h1>
							</div>
						
							<div class="contact-category">
								<div class="mail">
									<h4>Mail :</h4>
									<h2>fmvilla1@misena.edu.co</h2>
								</div>
							</div>

							<div class="contact-category">
								<div class="social">
									<h4>Social Media :</h4>
									<a href="#"><i class="fa fa-facebook"></i></a>
									<a href="#"><i class="fa fa-twitter"></i></a>
									<a href="#"><i class="fa fa-instagram"></i></a>
								</div>
							</div>
							
						</div>
					</div>
				</div>
			</div>
		</section>

</asp:Content>
