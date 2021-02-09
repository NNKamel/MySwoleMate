<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AssignWorkout.aspx.cs" Inherits="MySwoleMate.AssignWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Assign Workout</h1>
                </div>
            </div>
        </div>
    </section>
    <h2>Choose a Workout</h2>
    <asp:DropDownList ID="WorkoutDropdownList" runat="server"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" OnClick="AssignWorkout_OnClick" Text="Assign" />

</asp:Content>
