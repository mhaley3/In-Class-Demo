﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageSpecialEvents.aspx.cs" Inherits="Admin_ManageSpecialEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-glass"></span>
        </h1>
    

    <!-- ObjectDataSource control to do the underlying communication with my BLL and my ListView control -->

        <asp:ObjectDataSource ID="SpecialEventsDataSource" runat="server" TypeName="eRestaraunt.Framework.BLL.RestaurantAdminController"
            SelectMethod="ListAllSpecialEvents" DataObjectTypeName="eRestaraunt.Framework.Entities.SpecialEvent" OldValuesParameterFormatString="original_{0}" UpdateMethod="UpdateSpecialEvent" DeleteMethod="DeleteSpecialEvent" InsertMethod="AddSpecialEvent" OnDeleted="ProcessExceptions" OnInserted="ProcessExceptions" OnUpdated="ProcessExceptions" ></asp:ObjectDataSource>
        <asp:Label ID="MessageLabel" runat="server" />

    <%--<asp:GridView ID="SpecialEventsGridView" runat="server" DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>

        <asp:ListView ID="SpecialEventsListView" runat="server" DataSourceID="SpecialEventsDataSource" DataKeyNames="EventCode" InsertItemPosition="FirstItem">
            <LayoutTemplate>
                <fieldset runat="server" id="itemPlaceholderContainer">
                    <div runat="server" id="itemPlaceholder" />
                </fieldset>
            </LayoutTemplate>

            <ItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Edit" ID="EditButton">Edit
                        <span class="glyphicon glyphicon-pencil"></span></asp:LinkButton>

                    <asp:LinkButton runat="server" CommandName="Delete" ID="DeleteButton">Delete
                        <span class="glyphicon glyphicon-trash"></span></asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;

                    <asp:CheckBox Checked='<%# Eval("Active") %>' runat="server" ID="ActiveCheckBox" Enabled="false" Text="Active" />
                    &mdash;
                    <asp:Label ID="Label1" runat="server" AssociatedControlID="EventCodeData" CssClass="control-label">Event Code</asp:Label>
                    <asp:Label ID="EventCodeData" runat="server" Text='<%# Eval("EventCode") %>' />
                    &mdash;
                    <asp:Label ID="Label2" runat="server" AssociatedControlID="EventCodeData" CssClass="control-label">Description</asp:Label>
                    <asp:Label ID="DescriptionData" runat="server" Text='<%# Eval("Description") %>' />
                </div>
            </ItemTemplate>

            <EditItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Update" Text="Update" ID="UpdateButton" /> &nbsp &nbsp;
                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /> &nbsp &nbsp &nbsp;
                    Event Code
                    <asp:TextBox runat="server" ID="EventCodeTextBox" Text='<%# Bind("EventCode") %>' Enabled="false" />
                    Description
                    <asp:TextBox runat="server" ID="DescriptionTextBox" Text='<%# Bind("Description") %>'  />
                    <asp:CheckBox runat="server" ID="ActiveCheckBox" Checked='<%# Bind("Active") %>' Text="Active"  />
                </div>
            </EditItemTemplate>

            <InsertItemTemplate>
                <div>
                    <asp:LinkButton runat="server" ID="InsertButton" CommandName="Insert">  
                    Insert <span class="glyphicon glyphicon-plus"></span>&nbsp &nbsp;
                    </asp:LinkButton>

                    <asp:LinkButton runat="server" ID="CancelButton" CommandName="Cancel">
                        Clear <span class="glyphicon glyphicon-refresh"></span>
                    </asp:LinkButton>
                    &nbsp &nbsp;

                    <asp:CheckBox runat="server" ID="ActiveCheckBox" Text="Active" Checked='<%# Bind("Active") %>' />
                    &nbsp &nbsp;

                    <asp:Label ID="label3" runat="server" CssClass="control-label" AssociatedControlID="EventCodeTextBox">EventCode</asp:Label>
                    <asp:TextBox ID="EventCodeTextBox" runat="server" Text='<%# Bind("EventCode") %>' />

                    <asp:Label ID="label4" runat="server" CssClass="control-label" AssociatedControlID="DescriptionTextBox">Description</asp:Label>
                    <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />

                </div>
            </InsertItemTemplate>
        </asp:ListView>

    </div>

</asp:Content>

