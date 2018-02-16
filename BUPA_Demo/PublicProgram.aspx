<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="PublicProgram.aspx.cs" Inherits="BUPA_Demo.PublicProgram" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <p>

   </p>
    <p>

   </p>
    <p>

   </p>
    <asp:Repeater ID="PublicRepeator" runat="server">
       <ItemTemplate>
            <div>  
                      <table class="table table-bordered table-striped table-condensed">  
                        <tr>  
                            <td style="width:500px;"><%#Eval("Name")%></td> 
                            <td style="width:500px;">
                            <a class="btn btn-info" href="PublicProgramDetail.aspx?id=<%#Eval("ProgramId")%>">Details</a>
                              </td>  
                        </tr>                                                  
                    </table>  
                </div>  
        </ItemTemplate>
    </asp:Repeater>
 </asp:Content>
