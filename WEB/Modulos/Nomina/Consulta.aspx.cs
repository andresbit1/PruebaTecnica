using Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Modulos.Nomina
{
    public partial class Consulta : System.Web.UI.Page
    {
        contratoslaborales ConL = new contratoslaborales();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BT_Buscar_Click(object sender, EventArgs e)
        {

            ConL.numerodocumento = Convert.ToDecimal(TB_NDocumento.Text);
            ConsultaPersona(ConL);
        }

        public void ConsultaPersona(contratoslaborales CL)
        {
            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345678;Database = pruebatecnica"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT idcontrato, idestado, idtipodocumento, numerodocumento, primerapellido, segundoapellido, " +
                    "primernombre, segundonombre, fechainicio, fechafin, salario , nombre as Cargo, valor " +
                    "FROM public.contratoslaborales " +
                    "inner join public.cargos on public.cargos.idcargo = public.contratoslaborales.idcargo " +
                    "inner join public.arl on public.arl.idarl = public.contratoslaborales.idarl " +
                    "" +
                    "" +
                    " where numerodocumento = " + CL.numerodocumento + "; ", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TB_Nombre.Text = dr["segundonombre"].ToString();
                    TB_nombre2.Text = dr["segundonombre"].ToString();
                    TB_apellido.Text = dr["primerapellido"].ToString();
                    TB_apellido2.Text = dr["segundoapellido"].ToString();
                    TB_TDocumento.Text = dr["idtipodocumento"].ToString();
                    TB_Contrato.Text = dr["idcontrato"].ToString();
                    TB_Cargo.Text = dr["Cargo"].ToString();
                    TB_ARL.Text = dr["valor"].ToString();
                    TB_FIC.Text = dr["fechainicio"].ToString();
                    TB_FFC.Text = dr["fechafin"].ToString();
                    TB_Salario.Text = dr["salario"].ToString();



                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, GetType(), Guid.NewGuid().ToString(), "alert('La persona que busca no existe.'); ", true);

                }

                dr.Close();
                conn.Close();

            }
        }

    }
}