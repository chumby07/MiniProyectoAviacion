<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="HijaCliente.aspx.cs" Inherits="VIEW.HijaCliente" %>
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
										<a href="#Vuelos"><i class="fa fa-angle-double-down"></i></a>
									</div>

								</div>
									
							</div>
						</div>
					</div>
				</div>
			</div>
        </header>

        <!-- Sections -->
        <section id="Vuelos" class="about sections" style="margin-bottom:-100px;">
            <div class="container">

                <!-- Example row of columns -->
                <div class="row">
                    <div class="wrapper">
					
                    	<div class="col-md-6">
                    		<div class="about-photo">
								<img src="assets/images/ticket2.png" alt="About Image" />
							</div>
                    	</div>
						
						<div class="col-md-6">
                    		<div class="heading about-content" style="text-align:center;">
								<h3>Reserve Flight</h3>
							</div>
                            <div style="margin-top:-15px;">
                                <div class="row">
                                    <div class="col-lg-6">
                                        <asp:DropDownList ID="DdLVuelo" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                            <asp:ListItem Value="" Selected="True" Text="Select Flight"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtIdentificacionPasajero" runat="server" CssClass="form-control" placeholder="Identification Passenger"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6">
                                        <asp:TextBox ID="txtPesoEquipaje" runat="server" CssClass="form-control" placeholder="Luggage Weight"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-lg-4">
                                        <asp:Button ID="btnReserveFlight" CssClass="btn btn-success" runat="server" Text="Reserve" OnClick="btnReserveFlight_Click"/>
                                    </div>
                                </div>
                            </div>
                    	</div>

                    </div>
                </div>
				
            </div> <!-- /container -->       
        </section>

</asp:Content>
