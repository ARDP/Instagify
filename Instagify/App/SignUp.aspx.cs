using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Data;
using System.Configuration;
using System.IO;

public partial class Instagify_App_SignUp : System.Web.UI.Page
{


    private const string imagePerfilDefault = @"imagenes/silueta.png";
    private readonly string pathSaveImg = @ConfigurationManager.AppSettings["PicUsers"];

    private string fileNamePerfil;
    public string FileNamePerfil
    {
        get { return fileNamePerfil; }
        set { fileNamePerfil = value; }
    }

    private bool isValidImage = false;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //[WebMethod]
    //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    //public static string Save(clsUser obj)
    //{
    //    try
    //    {
    //        string resp = "";
    //        clsUser objUser = new clsUser();
    //        resp = Convert.ToString(objUser.mtInsertUser(0, obj.Name, obj.LastName, 2, obj.Email, obj.UserName, String.Empty, obj.PassW, true));
    //        objUser.mtDispose();
    //        return resp;
    //    }
    //    catch (Exception e)
    //    {
    //        return e.Message;
    //    }
    //}


    protected void m_btnSignUp_Click(object sender, EventArgs e)
    {
        string nombreFile2 = String.Empty;
        //SubirImagen();
        if (SubirImagen() == false)
            return;
        nombreFile2 = ViewState["pic"].ToString();
        bool resp;
        clsUser objUser = new clsUser();
        objUser.Name = m_txtName.Text;
        objUser.LastName = m_txtLastName.Text;
        objUser.Email = m_txtEmail.Text;
        objUser.UserName = m_txtUserName.Text;
        objUser.PassW = m_txtPassword.Text;



        resp = objUser.mtInsertUser(0, objUser.Name, objUser.LastName, 2, objUser.Email, objUser.UserName, String.Empty, objUser.PassW, true, nombreFile2);
        objUser.mtDispose();


        if (resp == true)
        {
            try
            {
                objUser = new clsUser();

                DataTable dt = new DataTable();
                dt = objUser.mttUserGet(m_txtUserName.Text, m_txtPassword.Text);
                objUser.mtDispose();

                bool ExistUser = false;

                //Existe el usuario 

                if (dt.Rows.Count > 0)
                {
                    ExistUser = true;
                    if (dt.Rows[0]["Active"].ToString() == "0")
                    {
                        return;
                    }

                    Session["IdUser"] = dt.Rows[0]["IdUser"].ToString();
                    Session["Name"] = dt.Rows[0]["Name"].ToString();
                    Session["LastName"] = dt.Rows[0]["LastName"].ToString();
                    Session["UserType"] = dt.Rows[0]["UserType"].ToString();

                    if (ExistUser == false)
                    {
                        return;
                    }
                    else
                    {
                        Response.Redirect("Index.aspx");
                    }

                }
            }
            catch
            {
                throw;
            }
        }
    }
    private bool SubirImagen(  )
    {
        //var onlyValidate = false;
        //if (onlyValidate)
        //{
        //    if (String.Compare(ImagenPerfil.ImageUrl, imagePerfilDefault) == -1 && !FileUploadASP.HasFile)
        //    {
        //        isValidImage = true;
        //        return;
        //    }
        //}

        HttpPostedFile mifichero = FileUploadASP.PostedFile;
        var fileNameUpload = FileUploadASP.FileName;
        string nombreFile = String.IsNullOrEmpty(FileUploadASP.FileName) ? ImagenPerfil.ImageUrl : FileUploadASP.FileName;
        string nombreFile2 = !String.IsNullOrEmpty(fileNameUpload) ?
            Path.GetFileNameWithoutExtension(fileNameUpload) + "_" + DateTime.Now.ToString("ddMMyyyymmss") + Path.GetExtension(fileNameUpload) :
            Path.GetFileNameWithoutExtension(ImagenPerfil.ImageUrl) + Path.GetExtension(ImagenPerfil.ImageUrl);
        //string nombreFile2 = Path.GetFileNameWithoutExtension(fileNameUpload) + "_" + DateTime.Now.ToString("ddMMyyyymmss") + Path.GetExtension(String.IsNullOrEmpty(fileNameUpload) ? ImagenPerfil.ImageUrl : FileUploadASP.FileName);
        string extension = Path.GetExtension(nombreFile);
        string nomb = Path.GetFileNameWithoutExtension(String.IsNullOrEmpty(FileUploadASP.FileName) ? ImagenPerfil.ImageUrl : FileUploadASP.FileName);

        //if (onlyValidate)
        //{
        //    double Kb = mifichero.ContentLength / 1024;
        //    if (Kb > 2048)
        //    {
        //        //mtvAddMessageModal("No se puede subir el documento, excede el tamaño permitido de 2 mb.", MessageType.warning);
        //        return;
        //    }

        //    if (!extension.ToUpper().Equals(".JPG") && !extension.ToUpper().Equals(".PNG"))
        //    {
        //        //mtvAddMessageModal("La imagen de perfil tiene un formato incorrecto. Favor, volver intentar.", MessageType.error);
        //        return;
        //    }
        //}
        //else
        //{
            try
            {
            double Kb = mifichero.ContentLength / 1024;
            if (Kb > 2048)
            {
                //mtvAddMessageModal("No se puede subir el documento, excede el tamaño permitido de 2 mb.", MessageType.warning);
                return false;
            }

            if (!extension.ToUpper().Equals(".JPG") && !extension.ToUpper().Equals(".PNG"))
            {
                //mtvAddMessageModal("La imagen de perfil tiene un formato incorrecto. Favor, volver intentar.", MessageType.error);
                return false;
            }
            // Condiciona ruta no mayor a 200 -tamaño de campo en DB-
            var fullPath = String.Concat(pathSaveImg, nombreFile2);
                var fixedPath = (fullPath.Length > 200) ? fullPath.Substring(0, 195) + extension : fullPath.Substring(0, fullPath.Length);
                FileNamePerfil = Path.GetFileName(fixedPath);

                // Verifica que exista para eliminarlo antes
                if (!File.Exists(fixedPath))
                    FileUploadASP.SaveAs(@fixedPath);
                //File.Delete(fixedPath);

                // Guarda el archivo subido en la carpeta del AppSettings

            }
            catch (DirectoryNotFoundException ex)
            {
            //mtvAddMessageModal("No se encuentra el directorio\n" + ex.Message, MessageType.error);
            throw ex;
            }
            catch (Exception ex)
            {
            throw ex;
                //mtvAddMessageModal("Ha ocurrido un error guardado la imagen de perfil\n" + ex.Message, MessageType.error);
            }
        isValidImage = true;
        ViewState["pic"] = nombreFile2;

        return isValidImage;
    }
       
    }







