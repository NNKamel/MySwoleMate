<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="ViewWorkout.aspx.cs" Inherits="MySwoleMate.ViewWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h1>
                        <asp:Label ID="MainTitle" runat="server"></asp:Label>
                    </h1>
                </div>
            </div>
            <div class="row">
                <div class="col0-lg-12 text-center">
                    <asp:Label ID="Exercise1" runat="server"></asp:Label>

                </div>
            </div>
            <div class="row">
                <div class="col0-lg-12 text-center">
                    <asp:Label ID="Exercise2" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col0-lg-12 text-center">
                    <asp:Label ID="Exercise3" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col0-lg-12 text-center">
                    <asp:Label ID="Exercise4" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col0-lg-12 text-center">
                    <asp:Label ID="Exercise5" runat="server"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:LinkButton ID="AssignWorkout" OnClick="Button_OnClickAssignWorkout" runat="server" ControlStyle-CssClass="btn btn-success" ItemStyle-CssClass="text-center">Assign Workout</asp:LinkButton>
                    <asp:LinkButton ID="Back" PostBackUrl="~/Trainees.aspx" runat="server" CssClass="btn btn-default" ItemStyle-CssClass="text-center">Back</asp:LinkButton>

                </div>
            </div>
        </div>
    </section>
</asp:Content>
