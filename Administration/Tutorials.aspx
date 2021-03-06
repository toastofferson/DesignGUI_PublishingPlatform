﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tutorials.aspx.cs" Inherits="Administration.Tutorials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!-- Home page -->
    <h2>Tutorials</h2>
    <!-- Add news -->
    <% if(isAdmin){ %>
        <asp:Button runat="server" Text="Add a tutorial" OnClick="New_Tutorial" CssClass="btn btn-default" />
    <% } %>
    
    <table id="TutorialTable"  style="width: 100%" class="table table-hover">
        <thead>
            <tr>
                <th>Title</th>
                <th>Last Modification</th>
                <th>Action</th>
                <th>Publish</th>
            </tr>
        </thead>
        <asp:ListView ID="LVTuto" runat="server" ItemType="Administration.ServiceReference1.TutorialItem" OnPreRender="LVTuto_PreRender">
            <EmptyDataTemplate>
                <tbody>
                    <tr>
                        <td>No news was returned.</td>
                    </tr>
                </tbody>
            </EmptyDataTemplate>
            <%--<GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"> </td>
                </tr>
            </GroupTemplate>--%>
            <ItemTemplate>
                <tr>
                    <td class="published<%#: Item.Published %>"><h4><%#: Item.Title %></h4></td>
                    <td class="published<%#: Item.Published %>"><%#: Item.DateModified %></td>
                    <td class="published<%#: Item.Published %>">
                        <asp:HyperLink runat="server" NavigateUrl='<%# string.Format("~/TutorialView?id={0}", Item._id) %>' CssClass="btn btn-default">See</asp:HyperLink>
                        <% if(isAdmin){ %>
                            <asp:HyperLink runat="server" NavigateUrl='<%# string.Format("~/TutorialEditor?id={0}", Item._id) %>' CssClass="btn btn-default">Edit</asp:HyperLink>
                            
                            <asp:LinkButton runat="server" OnClick="PublishClick" CommandArgument="<%#: Item._id %>" Cssclass="btn btn-default btnpublish">Publish</asp:LinkButton>
                            <asp:LinkButton runat="server" OnClick="UnPublishClick" CommandArgument="<%#: Item._id %>" class="btn btn-default btnunpublish">Unpublish</asp:LinkButton>
                            <asp:LinkButton runat="server" OnClick="DeleteClick" CommandArgument="<%#: Item._id %>" class="btn btn-default btndelete">Delete</asp:LinkButton>
                        <% } %>
                        
                    </td>
                    <td class="published<%#: Item.Published %>"> <%#: Item.Published %> </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <tbody id="itemPlaceholderContainer" runat="server">
                    <tr id="itemPlaceholder" runat="server"> </tr>
                </tbody>
            </LayoutTemplate>
        </asp:ListView>
    </table>
    <style>
        .publishedFalse{
            background : #f68181;
        }
        .btnunpublish{
            background-color:#e5b209;
            color:#333333;

        }
         .btnpublish{
            background-color:#0fbc37;
            color:#333333;
        }
        .btndelete{
            background-color:#db1406;
            color:#333333;
        }

    </style>
    <script type="text/javascript" charset="utf8" src="//cdn.datatables.net/1.10.12/js/jquery.dataTables.js"></script>
    <script>
        $(document).ready(function () {
            $("#TutorialTable").DataTable();
        });
</script>
</asp:Content>
