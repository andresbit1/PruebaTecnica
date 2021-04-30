<%@ Page Title="" Language="C#" MasterPageFile="~/M.Master" AutoEventWireup="true" CodeBehind="CalNomina.aspx.cs" Inherits="WEB.Modulos.Nomina.CalNomina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="my-3 p-3 bg-body rounded shadow-sm">
        <h6 class="border-bottom pb-2 mb-0"><b>Calculo nomina a pagar</b></h6>
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

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Numero de contrato"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_Contrato" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Cargo"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_Cargo" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Riesgo laboral ARL"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_ARL" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Fecha de inicio de contrato"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_FIC" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Fecha Final de contrato"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_FFC" Width="100%" runat="server"></asp:TextBox>

            </div>

            <div class="col-sm-6">
                <asp:Label runat="server" CssClass="form-label" Text="Salario"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="TB_Salario" Width="100%" runat="server"></asp:TextBox>

            </div>

            <asp:Button ID="BT_Calcular" OnClick="BT_Calcular_Click" runat="server" Text="Calcular" />

        </div>
    </div>
</asp:Content>
