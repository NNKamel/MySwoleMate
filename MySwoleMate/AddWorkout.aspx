<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MySwoleMate.Master" AutoEventWireup="true" CodeBehind="AddWorkout.aspx.cs" Inherits="MySwoleMate.AddWorkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Add Workout</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="Exercise1Label" runat="server" Text="Exercise1" AssociatedControlID="Exercise1" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise1" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise1Required" runat="server" ErrorMessage="Required" ControlToValidate="Exercise1" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise1RepsLabel" runat="server" Text="Exercise1Reps" AssociatedControlID="Exercise1Reps" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise1Reps" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise1RepsRequired" runat="server" ErrorMessage="Exercise1Reps Required" ControlToValidate="Exercise1Reps" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise1SetsLabel" runat="server" Text="Exercise1Sets" AssociatedControlID="Exercise1Sets" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise1Sets" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise1SetsRequired" runat="server" ErrorMessage="Exercise1Sets Required" ControlToValidate="Exercise1Sets" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <%--  --%>
                <div class="form-group">
                    <asp:Label ID="Exercise2Label" runat="server" Text="Exercise2" AssociatedControlID="Exercise2" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise2" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise2Required" runat="server" ErrorMessage="Required" ControlToValidate="Exercise2" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise2RepsLabel" runat="server" Text="Exercise2Reps" AssociatedControlID="Exercise2Reps" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise2Reps" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise2RepsRequired" runat="server" ErrorMessage="Exercise2Reps Required" ControlToValidate="Exercise2Reps" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise2SetsLabel" runat="server" Text="Exercise2Sets" AssociatedControlID="Exercise2Sets" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise2Sets" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise2SetsRequired" runat="server" ErrorMessage="Exercise2Sets Required" ControlToValidate="Exercise2Sets" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator4" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
<%--  --%>
                
                <div class="form-group">
                    <asp:Label ID="Exercise3Label" runat="server" Text="Exercise3" AssociatedControlID="Exercise3" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise3" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise3Required" runat="server" ErrorMessage="Required" ControlToValidate="Exercise3" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise3RepsLabel" runat="server" Text="Exercise3Reps" AssociatedControlID="Exercise3Reps" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise3Reps" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise3RepsRequired" runat="server" ErrorMessage="Exercise3Reps Required" ControlToValidate="Exercise3Reps" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator5" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise3SetsLabel" runat="server" Text="Exercise3Sets" AssociatedControlID="Exercise3Sets" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise3Sets" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise3SetsRequired" runat="server" ErrorMessage="Exercise3Sets Required" ControlToValidate="Exercise3Sets" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator6" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
<%--  --%>
                
                <div class="form-group">
                    <asp:Label ID="Exercise4Label" runat="server" Text="Exercise4" AssociatedControlID="Exercise4" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise4" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise4Required" runat="server" ErrorMessage="Required" ControlToValidate="Exercise4" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise4RepsLabel" runat="server" Text="Exercise4Reps" AssociatedControlID="Exercise4Reps" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise4Reps" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise4RepsRequired" runat="server" ErrorMessage="Exercise4Reps Required" ControlToValidate="Exercise4Reps" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator7" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise4SetsLabel" runat="server" Text="Exercise4Sets" AssociatedControlID="Exercise4Sets" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise4Sets" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise4SetsRequired" runat="server" ErrorMessage="Exercise4Sets Required" ControlToValidate="Exercise4Sets" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator8" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
<%--  --%>
                
                <div class="form-group">
                    <asp:Label ID="Exercise5Label" runat="server" Text="Exercise5" AssociatedControlID="Exercise5" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise5" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise5Required" runat="server" ErrorMessage="Required" ControlToValidate="Exercise5" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise5RepsLabel" runat="server" Text="Exercise5Reps" AssociatedControlID="Exercise5Reps" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise5Reps" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise5RepsRequired" runat="server" ErrorMessage="Exercise5Reps Required" ControlToValidate="Exercise5Reps" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator9" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Exercise5SetsLabel" runat="server" Text="Exercise5Sets" AssociatedControlID="Exercise5Sets" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Exercise5Sets" runat="server" CssClass="form-control" TextMode="SingleLine" MaxLength="30"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="Exercise5SetsRequired" runat="server" ErrorMessage="Exercise5Sets Required" ControlToValidate="Exercise5Sets" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="RangeValidator10" runat="server" ErrorMessage="please enter a value between 0 and 999" MinimumValue="1" MaximumValue="999" Type="Integer" ControlToValidate="Exercise1Reps" ValidationGroup="AllValidators" Display="Dynamic"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="WorkoutAddButton" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="WorkoutAddButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Workout.aspx" runat="server" Text="Back">HyperLink</asp:HyperLink>
                    </div>
                </div>
            </div>
        </div>  
    </section>
</asp:Content>
