<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Instagify_App_SignUp" MasterPageFile="~/Instagify/App/MasterPage.master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


        <form class="form-signin col-md-4 col-md-offset-4">
            <h2 class="form-signin-heading">Please sign in</h2>


            <input id="m_txtName" placeholder="Name" class="form-control" />
            <input id="m_txtLastName" placeholder="LastName" class="form-control" />
            <input id="m_txtUserName" placeholder="UserName" class="form-control" />
            <label for="m_txtEmail" class="sr-only">Email address</label>
            <input type="email" id="m_txtEmail" class="form-control" placeholder="Email address" required="required" autofocus="autofocus" />
            <label for="m_txtPassword" class="sr-only">Password</label>
            <input type="password" id="m_txtPassword" class="form-control" placeholder="Password" required="required" />
            <div class="checkbox">
                <label>
                    <input type="checkbox" value="remember-me" />
                    Remember me
                </label>
            </div>
            <button class="btn btn-lg btn-primary btn-block" type="submit" id="m_btnSignUp">Sign Up</button>
        </form>


    
    <!-- /container -->

  
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <script src="../scripts/js/custom/SignUp.js"></script>
</asp:Content>