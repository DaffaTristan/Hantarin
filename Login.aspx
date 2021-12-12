<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Hantarin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hantarin - Log In</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="additional-file/css/global.css" rel="stylesheet" />
</head>
<body>
    <div class="container-fluid bg">
        <div class="row">
            <div class="col"></div>
            <div class="col-5 align-self-center">
                <form class="container-form text-white border border-white" runat="server">
                    <div class="row">
                        <div class="col align-self-center">
                            <img src="additional-file/img/fd1.jpg" class="rounded img-fluid "/>
                        </div>
                        <div class="col align-self-center" >
                            <h2 class="text-center text-black">User Login</h2>
                            <div class="top-buffer form-group">
                                <asp:TextBox ID="TxtEmail"  CssClass="form-control form-rounded" placeholder="Enter Email Address..." runat="server"></asp:TextBox>
                            </div>
                            <div class="top-buffer form-group">
                                <asp:TextBox ID="TxtPassword" TextMode="Password" CssClass="form-control form-rounded" placeholder="Password" runat="server"></asp:TextBox>
                            </div >
                                <asp:Button ID="BtnLogin" OnClick="BtnLogin_Click" CssClass="top-buffer btn btn-primary col-12 mt-4 form-control form-rounded" runat="server" Text="Login" />
                            <div class="row">
                                <div>
                                    <asp:Button ID="BtnResetPass" OnClick="BtnResetPass_Click" CssClass="btn btn-link col-12 mt-4" runat="server" Text="Forgot Password?"/>
                                </div>
                                <div>
                                    <asp:Button ID="BtnHubungi" OnClick="BtnHubungi_Click" CssClass="btn btn-link col-12" runat="server" Text="Hubungi Kami"/>
                                </div>
                                <div>
                                    <asp:Button ID="BtnSignup" OnClick="BtnSignup_Click" CssClass="btn btn-link col-12" runat="server" Text="Create an Account!"/>
                                </div>
                            </div>
                                <asp:Label ID="LblWarning" CssClass="text-black fw-bold" Visible="false" runat="server" Text="--"></asp:Label>
                            </div>
                    </div>
                </form>
            </div>
            <div class="col"></div>
            
        </div>
    </div>

    <script src="bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
