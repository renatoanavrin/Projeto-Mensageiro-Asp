﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

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
<script src="Scripts/WebForms/MSAjax/mensageiro.js"></script>

<body class="fundo-cinza">
    <form id="form1" runat="server">
        <div class="col-md-12 fundo-azul height120 barra" ></div>

        <div class="col-md-8  height800 col-centered principal fundo-branco" id="hiddenChoices">
            
            <div class="col-md-4" id="principalUsuario">
              
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </div>

            <div class="col-md-8 caixaMensagens"></div>
            
            <div class="col-md-8 caixaTexto pull-right">
                <asp:TextBox ID="TextBox1" runat="server"  Width="75%" Height="100%"></asp:TextBox>
                <asp:Button ID="btnEnviarMensagem" runat="server" Text="Enviar Mensagem" Width="200px" />
            </div>
             
        
        </div>
        
    <div id="botoes">
        <asp:Button ID="addUsuario" runat="server" Text="Adicionar Usuário" OnClick="addUsuario_Click" />
        <asp:Button ID="Conversar" runat="server" Text="Conversar" OnClick="addUsuario_Click" />
        <asp:Button runat="server" id="btnHidden" style="display:none" onclick="btnHidden_OnClick" Text="teste" />

    </div>

        <asp:TextBox ID="hiddenchoice" runat="server"></asp:TextBox>    
         <asp:TextBox ID="usuarioSessao" runat="server"></asp:TextBox>    
<div onclick="javascript:DivClicked(); return true;">click aqui</div>

<script>

function DivClicked(usuario)
{
    alert(usuario);
    //var btnHidden = $('#<%= btnHidden.ClientID %>');
    /*var btnHidden = usuario;
    if(btnHidden != null)
    {*/
    $('#hiddenchoice').val(usuario);

    btnHidden.click();
    //}

    
    

}

</script>
    </form>
</body>
</html>
