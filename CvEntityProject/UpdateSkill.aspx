<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UpdateSkill.aspx.cs" Inherits="CvEntityProject.UpdateSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>UPDATING NEW SKILL WEBSITE</h4>
<br />

<asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="skill..."></asp:TextBox> <%--bunun içine placeholder'da eklenebilir üsttekini yorum satırına almalısın eğer burada placeholder kullanacaksan.--%>
<br />
<asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-group" />

</asp:Content>
