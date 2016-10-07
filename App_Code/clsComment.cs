using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsComment
/// </summary>
public class clsComment
{
    public int? IdComment { get; set; }
    public int? IdUser { get; set; }
    public int? IdContest { get; set; }
    public string Descrip { get; set; }
    public DateTime? CreatedOn { get; set; }
    
    clsDatos objDatos;
    DataTable dt;
    public clsComment()
    {
        objDatos = new clsDatos();
        objDatos.OpenConection();
    }


    public bool InsertComment(clsComment comment)
    {
        bool resp = false;
        try
        {
            objDatos.ClearParameter();
            objDatos.AddParameter("IdComment", comment.IdComment);
            objDatos.AddParameter("IdUser", comment.IdUser);
            objDatos.AddParameter("IdContest", comment.IdContest);
            objDatos.AddParameter("Descrip", comment.Descrip);
            objDatos.AddParameter("CreatedOn", comment.CreatedOn);

            resp = objDatos.ExecuteNonQuery("spcCommentsInsert", CommandType.StoredProcedure);

            return resp;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void mtDispose()
    {
        if (objDatos != null)
        {
            objDatos.CloseConection();
            objDatos = null;
        }
    }

}