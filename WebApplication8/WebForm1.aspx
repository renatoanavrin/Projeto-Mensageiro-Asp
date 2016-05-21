<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Comunicador renato</title>
     <!--<link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />-->
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
  </head>
    <!--<script src="Scripts/jquery-1.10.2.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script> -->
<script src="Scripts/jquery-1.10.2.js"></script>
<script src="Scripts/bootstrap.min.js"></script>

<body class="fundo-cinza">
    <form id="form1" runat="server">
        <div class="col-md-12 fundo-azul height120 barra" ></div>

        <div class="col-md-8  height800 col-centered principal fundo-branco">
            
            <div class="col-md-4">
              
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </div>

            <div class="col-md-8 caixaMensagens">

            </div>
        </div>
    <div>
        <asp:Button ID="addUsuario" runat="server" Text="Adicionar Usuário" OnClick="addUsuario_Click" />
    </div>
    </form>
</body>
</html>
