using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Instagify_App_Index : System.Web.UI.Page
{

    Page objPage = new Page();
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public static object GetLastActiveContest()
    {
        DataTable resp = new DataTable();
        clsContest objContest = new clsContest();
        //resp = objContest.mtContestGet((int?)null);
        resp = objContest.mtContestGetLast();
       
        objContest.mtDispose();

        var result = from p in resp.AsEnumerable()
                     select new clsContest
                     {
                         IdContest = (p["IdContest"] == null) ? (int?)null : Convert.ToInt32(p["IdContest"]),
                         Title = p["Title"] == null ? "" : p["Title"].ToString() ,
                         EndDay = p["EndDay"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime( p["EndDay"]),
                         WinnerId = p["WinnerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(p["WinnerId"]),
                         Active = p["Active"] == null ? (bool?)null : (bool)p["Active"],
                         SubTitle = p["SubTitle"] == null ? "": p["SubTitle"].ToString(),
                         Addres = p["Addres"] == null ? "" :p["Addres"].ToString(),
                         Phone = p["Phone"] == null ? "": p["Phone"].ToString(),
                         Photo = p["Photo"] == null ? "" : p["Photo"].ToString()
                     };
        
      
        return result;  
    }
    
    
    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    
    public static bool InsertCommentContest(clsComment obj)
    {
        var resp = false;
        clsComment objComment = new clsComment();
        clsContest objContest = new clsContest();
        DataTable dt = new DataTable();
        dt = objContest.mtContestGetLast();

        if(dt.Rows.Count > 0)
        {
            obj.IdContest = Convert.ToInt32(dt.Rows[0]["IdContest"]);

        }
        else
        {
            return false;
        }
        obj.IdComment = 0;
        obj.IdUser = Convert.ToInt32(HttpContext.Current.Session["IdUser"]);


        objComment.InsertComment(obj);

        objComment.mtDispose();

        return resp;
      
    }
}
