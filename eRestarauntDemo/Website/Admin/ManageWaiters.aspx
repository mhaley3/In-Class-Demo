<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageWaiters.aspx.cs" Inherits="Admin_ManageWaiters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row col-md-12">
        <h1>Manage Special Events
            <span class="glyphicon glyphicon-glass"></span>
        </h1>
    

    <!-- ObjectDataSource control to do the underlying communication with my BLL and my ListView control -->

        <asp:ObjectDataSource ID="WaitersDataSource" runat="server" TypeName="eRestaraunt.Framework.BLL.RestaurantAdminController"
            SelectMethod="ListAllWaiters" DataObjectTypeName="eRestaraunt.Framework.Entities.Waiters" OldValuesParameterFormatString="original_{0}" UpdateMethod="UpdateWaiters" DeleteMethod="DeleteWaiters" InsertMethod="AddWaiters" ></asp:ObjectDataSource>
        <asp:Label ID="MessageLabel" runat="server" />

    <%--<asp:GridView ID="SpecialEventsGridView" runat="server" DataSourceID="SpecialEventsDataSource"></asp:GridView>--%>

        <asp:ListView ID="WaitersListView" runat="server" DataSourceID="WaitersDataSource" DataKeyNames="WaiterID" InsertItemPosition="LastItem">
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
                    <asp:Label ID="EventCodeData" runat="server" Text='<%# Eval("WaiterID") %>' />
                    &mdash;
                    <asp:Label ID="Label2" runat="server" AssociatedControlID="EventCodeData" CssClass="control-label">Description</asp:Label>
                    <asp:Label ID="DescriptionData" runat="server" Text='<%# Eval("LastName") %>' />
                </div>
            </ItemTemplate>

            <EditItemTemplate>
                <div>
                    <asp:LinkButton runat="server" CommandName="Update" Text="Update" ID="UpdateButton" /> &nbsp &nbsp;
                    <asp:LinkButton runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" /> &nbsp &nbsp &nbsp;
                    Event Code
                    <asp:TextBox runat="server" ID="EventCodeTextBox" Text='<%# Bind("WaiterID") %>' Enabled="false" />
                    Description
                    <asp:TextBox runat="server" ID="DescriptionTextBox" Text='<%# Bind("LastName") %>'  />
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

                    <asp:Label ID="label3" runat="server" CssClass="control-label" AssociatedControlID="EventCodeTextBox">WaiterID</asp:Label>
                    <asp:TextBox ID="EventCodeTextBox" runat="server" Text='<%# Bind("WaiterID") %>' />

                    <asp:Label ID="label4" runat="server" CssClass="control-label" AssociatedControlID="DescriptionTextBox">Last Name</asp:Label>
                    <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("LastName") %>' />

                </div>
            </InsertItemTemplate>
        </asp:ListView>

    </div>

</asp:Content>

