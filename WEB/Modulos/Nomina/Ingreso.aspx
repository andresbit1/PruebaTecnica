<%@ Page Title="" Language="C#" MasterPageFile="~/M.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="WEB.Modulos.Nomina.Ingreso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="my-3 p-3 bg-body rounded shadow-sm">
        <h6 class="border-bottom pb-2 mb-0"><b>Novedades</b></h6>
        <br />


        <div class="row g-3">
            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Tipo de documento"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_TDocumento" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Numero documento"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_NDocumento" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Periodo laborado"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_Nombre" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Horas totales laboradas"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_nombre2" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Horas extra"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_apellido" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-3">
                <asp:Label runat="server" CssClass="form-label" Text="Descuentos de nomina"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_apellido2" Width="100%" runat="server"></asp:TextBox>

            </div>

            <asp:Button ID="TB_Agregar" OnClick="TB_Agregar_Click" runat="server" Text="Agregar" />


            <asp:HiddenField ID="Id" runat="server" />


        </div>
</asp:Content>
