<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VIEW.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="assets/css/estilos.css" rel="stylesheet" />
    <link href="assets/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="assets/css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
    	<div class="row">
			<div class="col-md-6 col-md-offset-3">
				<div class="panel panel-login">
					<div class="panel-heading">
						<div class="row">
							<div class="col-xs-6">
                                <a href="#" class="active" id="login-form-link">Login</a>
							</div>
							<div class="col-xs-6">
                                <a href="#" id="register-form-link">Register</a>
							</div>
						</div>
						<hr>
					</div>
					<div class="panel-body">
						<div class="row">
							<div class="col-lg-12">
                                <div ID="login-form" style="display: block;">
                                    <div class="form-group">
                                        <asp:TextBox ID="username" tabindex="1" CssClass="form-control" placeholder="Username" runat="server"></asp:TextBox>
									</div>
									<div class="form-group">
                                        <asp:TextBox type="password" ID="password" tabindex="1" CssClass="form-control" placeholder="Password" runat="server"></asp:TextBox>
									</div>
									<div class="form-group text-center">
                                        <asp:CheckBox ID="remember" tabindex="3" runat="server" />
                                        <asp:Label runat="server" for="remember" Text="Remember Me"></asp:Label>
									</div>
									<div class="form-group">
										<div class="row">
											<div class="col-sm-6 col-sm-offset-3">
                                                <asp:Button ID="login" CssClass="form-control btn btn-login" runat="server" Text="Log In" OnClick="login_Click1" />
											</div>
										</div>
									</div>
									<div class="form-group">
										<div class="row">
											<div class="col-lg-12">
												<div class="text-center">
                                                    <asp:HyperLink href="https://phpoll.com/recover" tabindex="5" CssClass="forgot-password" ID="HyperLink1" runat="server">Forgot Password?</asp:HyperLink>
												</div>
											</div>
										</div>
									</div>
                                </div>
                                <div ID="register-form" style="display: none;">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtName" tabindex="1" CssClass="form-control" placeholder="Name" runat="server"></asp:TextBox>
									</div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtIdentificacion" tabindex="1" CssClass="form-control" placeholder="Identification" runat="server"></asp:TextBox>
									</div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtUserName" tabindex="1" CssClass="form-control" placeholder="Username" runat="server"></asp:TextBox>
									</div>
									<div class="form-group">
                                        <asp:TextBox type="password" ID="txtPassword" tabindex="2" CssClass="form-control" placeholder="Password" runat="server"></asp:TextBox>
									</div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="txtRol" tabindex="2" CssClass="form-control" runat="server"> 
                                            <asp:ListItem Value="" Text="Seleccione un rol" Selected="True"></asp:ListItem> 
                                            <asp:ListItem Value="2" Text="Cliente"></asp:ListItem> 
                                        </asp:DropDownList> 
									</div>
									<div class="form-group">
										<div class="row">
											<div class="col-sm-6 col-sm-offset-3">
                                                <asp:Button ID="register"  class="form-control btn btn-register" runat="server" Text="Register Now" OnClick="register_Click"/>
											</div>
										</div>
									</div>
                                    <br />
                                    <div class="row">
										<div class="col-sm-6 col-sm-offset-3">
                                            <asp:Label ID="lblError" runat="server" Text="Label" style="display:none; color:red;"></asp:Label>
										</div>
									</div>
                                </div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
    </form>
    <script src="assets/js/js/sb-admin-2.js"></script>
    <script src="assets/js/bootstrap.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/chart.js"></script>
    <script src="assets/js/jquery-3.2.1.js"></script>
    <script src="assets/js/npm.js"></script>
    <script src="assets/js/Script.js"></script>
</body>
</html>
