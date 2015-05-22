using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using KentekenRegistratie.Objects;

namespace KentekenRegistratie
{
    public partial class ucHome : System.Web.UI.UserControl
    {
        private static Gebruiker gebruiker;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["loggedin"] != 1 || (string)Session["gebruikersNaam"] == null || (string)Session["gebruikersNaam"] == "")
            {
                Response.Redirect("rdwlogin.aspx");
            }

            if (!IsPostBack)
            {

            }

            // Passed login checks, so continue.
            if(gebruiker == null)
            {
                SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["rdwDBConnectionString"].ConnectionString);
                SqlCommand sqlComm = new SqlCommand("spGetUser", sqlConn);

                sqlComm.Parameters.Add(new SqlParameter("@GEBRUIKERSNAAM", System.Data.SqlDbType.VarChar, 50, "GEBRUIKERSNAAM") { Value = (string)Session["gebruikersNaam"] });

                sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    sqlConn.Open();
                    SqlDataReader sqlReader = sqlComm.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        // Retrieve info from the sqsl reader and insert it into a class instance
                        // load logged in users name into page top right
                        gebruiker = new Gebruiker((int)sqlReader["BSN"], (string)sqlReader["GEBRUIKERSNAAM"], (int)sqlReader["TYPE"]);
                    }
                }
                catch (Exception ex)
                {
                    // REPORT ERROR

                }
                finally
                {
                    sqlConn.Close();
                }

                if(gebruiker != null)
                {
                    
                    if(gebruiker.SoortGebruiker == 0)
                    {
                        // Politie

                        // User control voor de politie inladen
                        // - Kenteken invoeren en gegevens ervan inzien

                    }
                    else if(gebruiker.SoortGebruiker == 1)
                    {
                        // RDW

                        // User control voor de RDW inladen
                        // - Rechtspersoon registreren
                        // - Nieuw Kenteken genereren op aanvraag van rechtspersoon
                        // - Bestaand Kenteken overzetten op naam van nieuwe eigenaar
                        // - Bestaande gegevens met betrekking tot Kentekens en Rechtspersonen inzien
                    }


                }
                else
                {
                    // REPORT ERROR
                }

            }
        }

        protected void btnRechtspersoonRegistreren_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}