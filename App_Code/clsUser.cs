using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for clsUser
/// </summary>


public class clsUser
{


    public string Name { get; set; }
    public string LastName { get; set; }
    public int? UserType { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public bool? Active { get; set; }
    public string PassW { get; set; }
  

    clsDatos objDatos;

    public clsUser()
    {
        objDatos = new clsDatos();
        objDatos.OpenConection();

    }

    public bool mtInsertUser(int IdUser , string Name, string LastName, int? UserType, string Email, string UserName, string Friends, string PassW, bool Active,string ProfilePic)
    {
        var resp = false;
        try
        {
            objDatos.ClearParameter();
            objDatos.AddParameter("@IdUser", IdUser);
            objDatos.AddParameter("@Name", Name);
            objDatos.AddParameter("@LastName", LastName);
            objDatos.AddParameter("@UserType", UserType);
            objDatos.AddParameter("@Email", Email);
            objDatos.AddParameter("@UserName", UserName);
            objDatos.AddParameter("@Active", Active);
            objDatos.AddParameter("@PassW", PassW);
            objDatos.AddParameter("@ProfilePic", ProfilePic);

            resp =   objDatos.ExecuteNonQuery("spcUsersPut", System.Data.CommandType.StoredProcedure);

            return resp;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public  DataTable mttUserGet(string UserName, string PassW)
    {
        DataTable dtReturn = new DataTable();
        try
        {
            objDatos.ClearParameter();
            objDatos.AddParameter("@UserName", UserName);
            objDatos.AddParameter("@PassW", PassW);

            dtReturn = objDatos.getDataTable("spcUserGet", CommandType.StoredProcedure);

            return dtReturn;
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

