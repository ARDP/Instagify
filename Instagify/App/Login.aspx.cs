using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Instagify_App_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {

        try
        {
            clsUser objUser = new clsUser();

            DataTable dt = new DataTable();
            dt = objUser.mttUserGet(m_txtUserName.Text, m_txtPassWord.Text);
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
              
                Session["Name"] = dt.Rows[0]["Name"].ToString().ToUpper();
                Session["LastName"] = dt.Rows[0]["LastName"].ToString().ToUpper();
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