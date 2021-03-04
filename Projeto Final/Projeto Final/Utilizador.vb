Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Utilizador
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentUtilizador As Integer
    Dim currentsearchuser As Integer

    Private Sub Utilizador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.UTILIZADOR"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim Utilizador As New UtilizadorObject
            Utilizador.Nick = RDR.Item("Nick")
            Utilizador.Password = Convert.ToInt32(RDR.Item(("Hashed_Pass")))
            Utilizador.Salt = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Salt")), "", RDR.Item("Salt")))
            Utilizador.DataNasc = Convert.ToDateTime(IIf(RDR.IsDBNull(RDR.GetOrdinal("Data_Nasc")), "", RDR.Item("Data_Nasc")))
            Utilizador.EmailCriador = RDR.Item("Email")
            ListagemListBox.Items.Add(Utilizador)
        End While
        SaltBox.Items.Clear()
        SaltBox.Items.Add("128")
        SaltBox.Items.Add("256")
        SaltBox.Items.Add("512")
        Salt2Box.Items.Clear()
        Salt2Box.Items.Add("128")
        Salt2Box.Items.Add("256")
        Salt2Box.Items.Add("512")
        CN.Close()
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If MenuBackButton.Visible = False Then
            MenuBackButton.Visible = True
            CampButton.Visible = True
            JogosButton.Visible = True
            EquipaButton.Visible = True
            EstadioButton.Visible = True
            JogadorButton.Visible = True
            EquipaFictButton.Visible = True
            LigaFictButton.Visible = True
            UtilizadorButton.Visible = True
            JogadorPlaysInJogoButton.Visible = True
            EquipaFictPartLigaButton.Visible = True
            JogadorPertEquipaFictButton.Visible = True
        Else
            MenuBackButton.Visible = False
            CampButton.Visible = False
            JogosButton.Visible = False
            EquipaButton.Visible = False
            EstadioButton.Visible = False
            JogadorButton.Visible = False
            EquipaFictButton.Visible = False
            LigaFictButton.Visible = False
            UtilizadorButton.Visible = False
            JogadorPlaysInJogoButton.Visible = False
            EquipaFictPartLigaButton.Visible = False
            JogadorPertEquipaFictButton.Visible = False
        End If

    End Sub

    Private Sub Clear()
        inputNick.Text = ""
        input2DataNasc.Text = ""
        input2Email.Text = ""
        input2Nick.Text = ""
        input2Password.Text = ""
        input3Email.Text = ""
        input3Nick.Text = ""
        inputPassword.Text = ""
        inputDataNasc.Text = ""
        inputEmail.Text = ""
        SaltBox.SelectedIndex = SaltBox.FindStringExact("")
        Salt2Box.SelectedIndex = Salt2Box.FindStringExact("")

    End Sub

    Private Sub AdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputNick.ForeColor = Color.Black
        inputPassword.ForeColor = Color.Black
        inputDataNasc.ForeColor = Color.Black
        inputEmail.ForeColor = Color.Black

        Dim valido = True
        Dim nick = inputNick.Text
        Dim password = inputPassword.Text
        Dim DataNasc = inputDataNasc.Text
        Dim email = inputEmail.Text
        Dim salt = SaltBox.SelectedItem

        If nick = "" Or nick.Length > 20 Then
            valido = False
            inputNick.ForeColor = Color.Red
        Else
            nick = Replace(nick, "'", "''")
        End If

        If email = "" Or email.Length > 40 Then
            valido = False
            inputEmail.ForeColor = Color.Red
        End If

        If password = "" Then
            valido = False
            inputPassword.ForeColor = Color.Red
        End If

        If Not (IsDate(DataNasc)) Then
            valido = False
            inputDataNasc.ForeColor = Color.Red
        Else
            DataNasc = Replace(DataNasc, "/", "-")
            Dim parts As String() = DataNasc.Split(New Char() {"-"c})
            DataNasc = parts(2) + "-" + parts(1) + "-" + parts(0)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            'CMD.CommandText = "INSERT INTO ProjetoBD.UTILIZADOR (Nick,Hashed_Pass,Salt,Data_Nasc,Email) VALUES (@nick,CONVERT(INT, HASHBYTES('SHA2_256','" & password & "'+'" & salt & "')),'" & salt & "','" & DataNasc & "','" & email & "');"
            CMD.CommandText = "INSERT INTO ProjetoBD.UTILIZADOR (Nick,Hashed_Pass,Salt,Data_Nasc,Email) VALUES (@nick,CONVERT(INT, HASHBYTES('SHA2_256', @password + @salt )),@salt,@data,@email);"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nick", nick)
            CMD.Parameters.AddWithValue("@password", password)
            CMD.Parameters.AddWithValue("@salt", salt)
            CMD.Parameters.AddWithValue("@data", DataNasc)
            CMD.Parameters.AddWithValue("@email", email)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Utilizador Inserido Com Sucesso!")
            Catch ex As Exception
                MsgBox("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            pesquisaListBox.Items.Clear()
            Clear()
            loadTuplos()
        End If
    End Sub

    Private Sub AtualizarButton_Click(sender As Object, e As EventArgs) Handles AtualizarButton.Click
        inputNick.ForeColor = Color.Black
        inputPassword.ForeColor = Color.Black
        inputDataNasc.ForeColor = Color.Black
        inputEmail.ForeColor = Color.Black

        Dim valido = True
        Dim nick = inputNick.Text
        Dim password = inputPassword.Text
        Dim email = inputEmail.Text
        Dim salt = SaltBox.SelectedItem

        If nick = "" Or nick.Length > 20 Then
            valido = False
            inputNick.ForeColor = Color.Red
        Else
            nick = Replace(nick, "'", "''")
        End If

        If email = "" Or email.Length > 40 Then
            valido = False
            inputEmail.ForeColor = Color.Red
        End If

        If password = "" Then
            valido = False
            inputPassword.ForeColor = Color.Red
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "UPDATE ProjetoBD.UTILIZADOR SET Nick = @nick, Salt = @salt, Hashed_Pass = CONVERT(INT, HASHBYTES('SHA2_256', @password  +  @salt)) WHERE Email = @email;"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nick", nick)
            CMD.Parameters.AddWithValue("@password", password)
            CMD.Parameters.AddWithValue("@salt", salt)
            CMD.Parameters.AddWithValue("@email", email)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Utilizador Atualizado Com Sucesso!")
            Catch ex As Exception
                MsgBox("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()

            pesquisaListBox.Items.Clear()
            Clear()
            loadTuplos()
        End If
    End Sub

    Private Sub RemoverButton_Click(sender As Object, e As EventArgs) Handles RemoverButton.Click
        inputEmail.ForeColor = Color.Black
        Dim valido = True
        Dim email = inputEmail.Text

        If email = "" Or email.Length > 40 Then
            valido = False
            inputEmail.ForeColor = Color.Red
        Else
            CMD.CommandText = "Exec ProjetoBD.deleteUtilizador @email "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@email", email)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Utilizador Removido Com Sucesso!")
            Catch ex As Exception
                MsgBox("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            pesquisaListBox.Items.Clear()
            Clear()
            loadTuplos()
        End If
    End Sub
    Private Sub CampButton_Click(sender As Object, e As EventArgs) Handles CampButton.Click
        Me.Hide()
        Campeonato.Show()
        Campeonato.loadTuplos()
    End Sub

    Private Sub EquipaButton_Click(sender As Object, e As EventArgs) Handles EquipaButton.Click
        Me.Hide()
        Equipa.Show()
        Equipa.loadTuplos()
    End Sub

    Private Sub EstadioButton_Click(sender As Object, e As EventArgs) Handles EstadioButton.Click
        Me.Hide()
        Estadio.Show()
        Estadio.loadTuplos()
    End Sub

    Private Sub JogadorButton_Click(sender As Object, e As EventArgs) Handles JogadorButton.Click
        Me.Hide()
        Jogador.Show()
        Jogador.loadTuplos()
    End Sub

    Private Sub EquipaFictButton_Click(sender As Object, e As EventArgs) Handles EquipaFictButton.Click
        Me.Hide()
        EquipaFicticia.Show()
        EquipaFicticia.loadTuplos()
    End Sub

    Private Sub Utilizador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub JogosButton_Click(sender As Object, e As EventArgs) Handles JogosButton.Click
        Me.Hide()
        Jogo.Show()
        Jogo.loadTuplos()
    End Sub

    Private Sub LigaFictButton_Click(sender As Object, e As EventArgs) Handles LigaFictButton.Click
        Me.Hide()
        LigaFicticia.Show()
        LigaFicticia.loadTuplos()
    End Sub
    Private Sub EquipaFictPartLiga_Click(sender As Object, e As EventArgs) Handles EquipaFictPartLigaButton.Click
        Me.Hide()
        EquipaFictPartLiga.Show()
        EquipaFictPartLiga.loadTuplos()
    End Sub
    Private Sub JogadorPlaysInJogoButton_Click(sender As Object, e As EventArgs) Handles JogadorPlaysInJogoButton.Click
        Me.Hide()
        JogadorPlaysInJogo.Show()
        JogadorPlaysInJogo.loadTuplos()
    End Sub

    Private Sub JogadorPertEquipaFictButton_Click(sender As Object, e As EventArgs) Handles JogadorPertEquipaFictButton.Click
        Me.Hide()
        JogadorPertEquipaFict.Show()
        JogadorPertEquipaFict.loadTuplos()
    End Sub

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentUtilizador = ListagemListBox.SelectedIndex
            ShowTeam()
        End If
    End Sub

    Private Sub ShowTeam()
        If ListagemListBox.Items.Count = 0 Or currentUtilizador < 0 Then Exit Sub
        Dim Utilizador As New UtilizadorObject
        Utilizador = CType(ListagemListBox.Items.Item(currentUtilizador), UtilizadorObject)
        inputNick.Text = Utilizador.Nick
        inputPassword.Text = Utilizador.Password
        inputDataNasc.Text = Utilizador.DataNasc
        inputEmail.Text = Utilizador.EmailCriador
        SaltBox.SelectedIndex = SaltBox.FindStringExact(Utilizador.Salt)
    End Sub

    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim nick = input3Nick.Text
        Dim email = input3Email.Text

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM projetoBD.getUtilizadoresFiltrados(@nick,@email)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@nick", nick)
        CMD.Parameters.AddWithValue("@email", email)
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim Utilizador As New UtilizadorObject
            Utilizador.Nick = RDR.Item("Nick")
            Utilizador.Password = RDR.Item("Hashed_Pass")
            Utilizador.Salt = RDR.Item("Salt")
            Utilizador.DataNasc = RDR.Item("Data_Nasc")
            Utilizador.EmailCriador = RDR.Item("Email")
            pesquisaListBox.Items.Add(Utilizador)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentsearchuser = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentsearchuser < 0 Then Exit Sub
        Dim user As New UtilizadorObject
        user = CType(pesquisaListBox.Items.Item(currentsearchuser), UtilizadorObject)
        input2Nick.Text = user.Nick
        input2Password.Text = user.Password
        Salt2Box.SelectedIndex = Salt2Box.FindStringExact(user.Salt)
        input2DataNasc.Text = user.DataNasc
        input2Email.Text = user.EmailCriador
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class UtilizadorObject
    Public Property Nick As Object
    Public Property Password As Object
    Public Property Salt As Object
    Public Property EmailCriador As String
    Public Property DataNasc As Date
    Overrides Function ToString() As String
        Return Nick
    End Function
End Class