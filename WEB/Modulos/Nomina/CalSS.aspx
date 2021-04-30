<%@ Page Title="" Language="C#" MasterPageFile="~/M.Master" AutoEventWireup="true" CodeBehind="CalSS.aspx.cs" Inherits="WEB.Modulos.Nomina.CalSS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="my-3 p-3 bg-body rounded shadow-sm">
        <h6 class="border-bottom pb-2 mb-0"><b>calculo de aporte a seguridad social</b></h6>
        <br />
        <div class="row g-3">
            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Numero documento"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_NDocumento" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Nombre 1"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_Nombre" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Nombres 2"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_nombre2" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Apellido 1"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_apellido" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Apellido 2"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_apellido2" Width="100%" runat="server"></asp:TextBox>

            </div>



            <div class="row">
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="&nbsp;"></asp:Label>
                    <br />
                    <asp:Label runat="server" CssClass="form-label" Text="Salud"></asp:Label>
                    <br />
                    <asp:Label runat="server" CssClass="form-label" Text="Pension"></asp:Label>

                </div>
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="Aporte"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="tb_aporte_sal" Width="100%" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="form-control" ID="tb_aporte_pen" Width="100%" runat="server"></asp:TextBox>

                </div>
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="% Empleador"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="tb_por_emplador_sal" Width="100%" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="form-control" ID="tb_por_emplador_pen" Width="100%" runat="server"></asp:TextBox>

                </div>
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="Valor $"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="tb_valor_sal" Width="100%" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="form-control" ID="tb_valor_pen" Width="100%" runat="server"></asp:TextBox>

                </div>
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="% Trabajador"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="tb_por_tra_sal" Width="100%" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="form-control" ID="tb_por_tra_pen" Width="100%" runat="server"></asp:TextBox>

                </div>
                <div class="col-sm-2">
                    <asp:Label runat="server" CssClass="form-label" Text="Valor"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="tb_val_tra_sal" Width="100%" runat="server"></asp:TextBox>
                    <asp:TextBox CssClass="form-control" ID="tb_val_tra_pen" Width="100%" runat="server"></asp:TextBox>

                </div>
            </div>

            <asp:Button ID="BT_Buscar" OnClick="BT_Buscar_Click" runat="server" Text="Calcular" />

        </div>
    </div>
                <asp:HiddenField ID="hf_Salario" runat="server" />

</asp:Content>
