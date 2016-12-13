<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="yavorynskyylab1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 289px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Height="40px" OnClientClick="Errors()" OnClick="Button1_Click" style="z-index: 1; left: 12px; top: 135px; position: absolute; right: 869px" Text="+" Width="50px" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 13px; top: 83px; position: absolute; width: 108px"></asp:TextBox>
    
    </div>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 197px; top: 84px; position: absolute; width: 111px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 94px; top: 228px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Height="40px" OnClientClick="Errors()" OnClick="Button2_Click" style="z-index: 1; left: 73px; top: 135px; position: absolute" Text="-" Width="50px" />
        <asp:Button ID="Button3" runat="server" Height="40px" OnClientClick="Errors()" OnClick="Button3_Click" style="z-index: 1; left: 133px; top: 136px; position: absolute; right: 748px" Text="*" Width="50px" />
        <asp:Button ID="Button4" runat="server" Height="40px" OnClientClick="Errors()" OnClick="Button4_Click" style="z-index: 1; left: 196px; top: 136px; position: absolute; right: 685px" Text="/" Width="50px" />
        <asp:Button ID="Button5" runat="server" Height="40px" OnClientClick="Errors()" OnClick="Button5_Click" style="z-index: 1; left: 258px; top: 137px; position: absolute" Text="C" Width="50px" />
    </form>

    <script type="text/javascript">
        var Errors = function ()
        {
        var a = document.getElementById('TextBox1').value.trim().replace(/,/, '.');
        var b = document.getElementById('TextBox2').value.trim().replace(/,/, '.');
        var r = true;
        if (a === '' || b === '') {
            alert('Одне або кілька полiв є незаповнені');
            r = false;
        }
        if (isNaN(a)===true || isNaN(b)===true)
        {
            alert('Одне або кілька значення не є числом');
            r = false;
        }
        return r;
        }
    </script>
</body>
</html>
