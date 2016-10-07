using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Instagify_App_MasterPage : System.Web.UI.MasterPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["IdUser"] != null)
        {
            m_lblName.InnerText = Session["Name"].ToString();
            m_lblLastName.InnerText = Session["LastName"].ToString();
            m_btnCloseSession.Visible = true;
            m_liIn.Visible = false;

            if (Session["UserType"].ToString() == "0")
                m_liAdmin.Visible = true;
            else
                m_liAdmin.Visible = false;


        }
        else
        {
            m_liIn.Visible = true;
            m_liAdmin.Visible = false;
            m_btnCloseSession.Visible = false;
            //  Response.Redirect("Login.aspx", false);
        }

    }
    protected void closeSession(object sender, EventArgs e)
    {

    }



    //protected void Login_Click(object sender, EventArgs e)
    //{

    //    try
    //    {
    //        clsUser objUser = new clsUser();

    //        DataTable dt = new DataTable();
    //        dt = objUser.mttUserGet(m_txtUserName.Text, m_txtPassWord.Text);
    //        objUser.mtDispose();

    //        bool ExistUser = false;

    //        //Existe el usuario 

    //        if (dt.Rows.Count > 00)
    //        {
    //            ExistUser = true;
    //            if (dt.Rows[0]["Active"].ToString() == "0")
    //            {
    //                return;
    //            }

    //            Session["IdUser"] = dt.Rows[0]["IdUser"].ToString();
               
    //            Session["Name"] = dt.Rows[0]["Name"].ToString();
    //            Session["LastName"] = dt.Rows[0]["LastName"].ToString();
    //            Session["UserType"] = dt.Rows[0]["UserType"].ToString();
             
    //            if (ExistUser == false)
    //            {
    //                return;
    //            }
    //            else
    //            {
                   
    //            }

    //        }
    //    }
    //    catch
    //    {
    //        throw;
    //    }
    //}

    protected void closeSession_Click(object sender, EventArgs e)
    {

        Session["IdUser"] = null;

        Session["Name"] = null;
        Session["LastName"] = null;
        Session["UserType"] = null;
        m_lblName.InnerText = String.Empty;
        m_lblLastName.InnerText = String.Empty;
        m_btnCloseSession.Visible = false;
        m_liIn.Visible = true;
        m_liAdmin.Visible = false;
    }
}
