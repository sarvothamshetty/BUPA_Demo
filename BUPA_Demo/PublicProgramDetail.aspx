<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="PublicProgramDetail.aspx.cs" Inherits="BUPA_Demo.PublicProgramDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater ID="RepeaterProgram" runat="server">
       <ItemTemplate>
             <div>  
                    <table class="table table-bordered table-striped table-condensed">  
                        <tr>  
                            <th><%#Eval("Name")%></th>  
                        </tr>  
                        <tr>  
                            <td>Description : </td>  
                            <td><%#Eval("Description")%></td>  
                        </tr>  
                        <tr>  
                            <td>StartTime : </td>  
                            <td><%#Eval("StartTime")%></td>  
                        </tr>  
                        <tr>  
                            <td>EndTime : </td>  
                            <td><%#Eval("EndTime")%></td>  
                        </tr>  
                        <tr>  
                            <td>OnAir : </td>  
                          
                            <td><%#Convert.ToBoolean(Eval("IsOnAirNow")) == true ? "Yes":"No"%></td>  
                        </tr>  
                        <tr>  
                            <td>Program Image : </td>  
                            <td> <img  src="<%#Eval("ProgramImage")%>" height="42" width="42"  /></td>  

                           
                        </tr>  
                         <tr>  
                            <td>Paid : </td>  
                             <td><%#Convert.ToBoolean(Eval("IsPaidProgram")) == true ? "Yes":"No"%></td> 
                         
                        </tr>                          
                    </table>  
                </div>  
        </ItemTemplate>
    </asp:Repeater>

    </asp:Content>
