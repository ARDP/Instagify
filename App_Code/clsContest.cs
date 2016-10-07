using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsContest
/// </summary>
public class clsContest
{
    public int? IdContest { get; set; }
    public string Title { get; set; }
    public DateTime? EndDay { get; set; }
    public int? WinnerId { get; set; }
    public bool? Active { get; set; }
    public string SubTitle { get; set; }
    public string Addres { get; set; }
    public string Phone { get; set; }
    public string Photo { get; set; }


    clsDatos objDatos;
    DataTable dt;
    public clsContest()
    {
        objDatos = new clsDatos();
        objDatos.OpenConection();
    }

    public DataTable mtContestGet(int? IdContest)
    {
        try
        {
            dt = new DataTable();
            objDatos.ClearParameter();
            objDatos.AddParameter("@IdContest", IdContest);
            dt = objDatos.getDataTable("spcContestsGet2", CommandType.StoredProcedure);

            return dt;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public DataTable mtContestGetLast()
    {
        try
        {
            dt = new DataTable();
            objDatos.ClearParameter();
            dt = objDatos.getDataTable("spcContestsGet3", CommandType.StoredProcedure);

            return dt;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void mtDispose()
    {
        if(objDatos != null)
        {
            objDatos.CloseConection();
            objDatos = null;
        }
    }
}