<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BUPA_Demo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Demo</h1>
       
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
               Private Program
            </p>
            <p>
                <a class="btn btn-default" href="Private/Privateprogram.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                Public Program
            </p>
            <p>
                <a class="btn btn-default" href="PublicProgram.aspx">Learn more &raquo;</a>
            </p>
        </div>
       
    </div>

</asp:Content>
