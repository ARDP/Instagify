using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Data;

public partial class Instagify_App_SignUp : System.Web.UI.Page
{

    


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public static bool Save(clsUser obj)
    {
        try
        {
            bool resp = false;

            clsUser objUser = new clsUser();
            resp = objUser.mtInsertUser(0, obj.Name, obj.LastName, 2, obj.Email, obj.UserName, String.Empty, obj.PassW, true);
            objUser.mtDispose();

            return resp;
        }
        catch 
        {
            return false;


        }

    }

}