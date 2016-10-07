<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="Instagify_App_SignUp" MasterPageFile="~/Instagify/App/MasterPage.master" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>
        function btoUpload()
        {
            document.getElementById('<% = FileUploadASP.ClientID %>').click();
        }

        function ShowImagePreview(input)
        {
            if (input.files && input.files[0])
            {
                var reader = new FileReader();
                reader.onload = function (e)
                {
                    $('#<% = ImagenPerfil.ClientID %>').prop('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
        }
    }
    </script>
    <div class="container">
        <div class="form-signin col-md-4 col-md-offset-4">
            <div id="m_divRegistrate" class="AllwaysInMyHeart"><p>Registrate</p></div>
            <asp:TextBox ID="m_txtName" placeholder="Nombre" class="form-control inputCustom" runat="server"></asp:TextBox>
            <asp:TextBox ID="m_txtLastName" placeholder="Apellido" class="form-control inputCustom" runat="server"></asp:TextBox>
            <asp:TextBox ID="m_txtUserName" placeholder="Nombre de Usuario" class="form-control inputCustom" runat="server"></asp:TextBox>

            <label for="m_txtEmail" class="sr-only">Email address</label>
            <asp:TextBox runat="server" type="email" ID="m_txtEmail" class="form-control inputCustom" placeholder="Correo" required="required" autofocus="autofocus"></asp:TextBox>


            <label for="m_txtPassword" class="sr-only">Password</label>
            <asp:TextBox runat="server" ID="m_txtPassword" class="form-control inputCustom" placeholder="Contraseña" required="required"></asp:TextBox>


            <div id="contPerfil">
                <div class="form-group " style="text-align: center;">
                    
                        <div >
                            <asp:Image ID="ImagenPerfil" ImageUrl="../imagenes/silueta.svg" runat="server" Width="300px" />
                        </div>
                    
                  
                    <button id="btnPerfil" type="button" class="btn-fotoperfil btn btn-primary btn-lg btn-block inputButton2" tabindex="1013" onclick="btoUpload()">Subir foto de perfil</button>
                        <asp:FileUpload ID="FileUploadASP" ClientIDMode="Static" onchange="ShowImagePreview(this)" runat="server" CssClass="hidden" accept="image/*" />
                </div>

            </div>
           
            <asp:Button ID="m_btnSignUp"  CssClass="btn btn-primary btn-lg  inputButton"  runat="server" OnClick="m_btnSignUp_Click" Text="Ingresar" />
           
          
            
            <%--  <asp:RegularExpressionValidator ID="validatePassWord"
                runat="server" ErrorMessage="Contraseña muy larga."
                ControlToValidate="m_txtPassword"
                ValidationExpression="(?=^.{8,20}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$" />

            <asp:RegularExpressionValidator ID="validateUserName"
                runat="server" ErrorMessage="Usuario invalido."
                ControlToValidate="m_txtUserName"
                ValidationExpression="/^[a-z\d_]{4,15}$/i" />

            <asp:RegularExpressionValidator ID="validateEmail"
                runat="server" ErrorMessage="Correo invalido."
                ControlToValidate="m_txtEmail"
                ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" />--%>
        </div>
    </div>


    <!-- /container -->

    <link rel="stylesheet" type="text/css" href="../styles/main-content.css" />
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="../scripts/js/custom/SignUp.js"></script>
</asp:Content>
