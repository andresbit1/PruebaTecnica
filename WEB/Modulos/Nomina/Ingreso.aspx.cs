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
    public partial class Ingreso : System.Web.UI.Page
    {

        contratoslaborales ConL = new contratoslaborales();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TB_Agregar_Click(object sender, EventArgs e)
        {

        }

        public void Agregar(novedadesnomina NN)
        {
            ConL.numerodocumento = Convert.ToDecimal(TB_TDocumento.Text);
            ConsultaPersona(ConL);

            using (var conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345678;Database = pruebatecnica"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO " +
                    "public.novedadesnomina(	idcontrato, periodolaborado, " +
                    "horaslaboradas, horaextradiurna, horaextranocturna, " +
                    "horaextradominical, horaextrafestiva, descuentos, " +
                    "usuariocreacion, fechacreacion) VALUES (" +
                    ""+ Id.Value + ","+ NN.periodolaborado +", " +
                    ""+ NN.horaslaboradas +", "+ NN.horaextradiurna +", "+ NN.horaextranocturna +", " +
                    ""+ NN.horaextradominical +", "+NN.horaextrafestiva+", "+ NN.descuentos +", " +
                    ""+NN.usuariocreacion+", "+ NN.fechacreacion +"); "
                    , conn);

                int ret = cmd.ExecuteNonQuery();
                if (ret == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(Page, GetType(), Guid.NewGuid().ToString(), "alert('Informacion almacenada correctamente.'); ", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, GetType(), Guid.NewGuid().ToString(), "alert('No fue posible almacenar la informacion.'); ", true);
                }

            }

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
                    Id.Value = dr["idcontrato"].ToString();
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