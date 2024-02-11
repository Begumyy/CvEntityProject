<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="NewSkill.aspx.cs" Inherits="CvEntityProject.NewSkill" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>ADDING A NEW SKILL WEBSITE</h4>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Skill Description"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox> <%--bunun içine placeholder'da eklenebilir üsttekini yorum satırına almalısın eğer burada placeholder kullanacaksan.--%>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-info" OnClick="Button1_Click" />
</asp:Content>
