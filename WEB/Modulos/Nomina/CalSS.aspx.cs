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
    public partial class CalSS : System.Web.UI.Page
    {
        contratoslaborales ConL = new contratoslaborales();



        protected void Page_Load(object sender, EventArgs e)
        {

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
                    //TB_TDocumento.Text = dr["idtipodocumento"].ToString();
                    //TB_Contrato.Text = dr["idcontrato"].ToString();
                    //TB_Cargo.Text = dr["Cargo"].ToString();
                    //TB_ARL.Text = dr["valor"].ToString();
                    //TB_FIC.Text = dr["fechainicio"].ToString();
                    //TB_FFC.Text = dr["fechafin"].ToString();
                    hf_Salario.Value = dr["salario"].ToString();



                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(Page, GetType(), Guid.NewGuid().ToString(), "alert('La persona que busca no existe.'); ", true);

                }

                dr.Close();
                conn.Close();

            }
        }

        protected void BT_Buscar_Click(object sender, EventArgs e)
        {
            ConL.numerodocumento = Convert.ToDecimal(TB_NDocumento.Text);
            ConsultaPersona(ConL);
            double por_tra_sal;
            double por_tra_pen;
            double por_emp_sal;
            double por_emp_pen;
            double val_tra_sal;
            double val_tra_pen;
            double val_emp_sal;
            double val_emp_pen;

            double sal = Convert.ToDouble(hf_Salario.Value);


            tb_por_emplador_pen.Text = "16.0%";
            tb_por_emplador_sal.Text = "12.5%";

            tb_por_tra_pen.Text = "4.0%";
            tb_por_tra_sal.Text = "4.0%";

            double por_pen_tra = 4;
            double por_sal_tra = 4;
            double por_pen_emp = 16;
            double por_sal_emp = 12.5;

            tb_valor_pen.Text = ((sal * por_pen_emp) / 100).ToString();
            tb_valor_sal.Text = ((sal * por_sal_emp)/100).ToString();


            tb_val_tra_sal.Text = ((sal * por_sal_tra) / 100).ToString();
            tb_val_tra_pen.Text = ((sal * por_pen_tra) / 100).ToString();







        }
    }
}