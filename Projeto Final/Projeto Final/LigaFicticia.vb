Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class LigaFicticia
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentLigaFicticia As Integer
    Dim currentSearchLeague As Integer
    Dim Email_Nick As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Nick_Email As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private Sub LigaFicticia_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.LIGA"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim LigaFicticia As New LigaFicticiaObject
            LigaFicticia.ID = RDR.Item("id_Liga")
            LigaFicticia.Nome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Nome")), "", RDR.Item("Nome")))
            LigaFicticia.MaximoParticipantes = RDR.Item("MaximoParticipantes")
            LigaFicticia.EmailCriador = RDR.Item("EmailCriador")
            ListagemListBox.Items.Add(LigaFicticia)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.Emails_Nick_Utilizador"
        CN.Open()
        RDR = CMD.ExecuteReader
        NickBox.Items.Clear()
        nick2Box.Items.Clear()
        Nick3Box.Items.Clear()
        Nick3Box.Items.Add("")
        Email_Nick.Clear()
        Nick_Email.Clear()
        While RDR.Read
            Dim email = RDR.Item("Email")
            Dim nick = RDR.Item("Nick")
            Email_Nick.Add(email, nick)
            Nick_Email.Add(nick, email)
            NickBox.Items.Add(nick)
            nick2Box.Items.Add(nick)
            Nick3Box.Items.Add(nick)
        End While
        CN.Close()
        Nick3Box.SelectedIndex = Nick3Box.FindStringExact("")
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
        inputID.Text = ""
        input2ID.Text = ""
        input2MaximoParticipantes.Text = ""
        input2Nome.Text = ""
        inputNome.Text = ""
        inputMaximoParticipantes.Text = ""
        input3Nome.Text = ""
        NickBox.SelectedIndex = NickBox.FindStringExact("")
        nick2Box.SelectedIndex = nick2Box.FindStringExact("")
        Nick3Box.SelectedIndex = Nick3Box.FindStringExact("")
    End Sub

    Private Sub AdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputMaximoParticipantes.ForeColor = Color.Black

        Dim valido = True
        Dim nome = inputNome.Text
        Dim maximoparticipantes = inputMaximoParticipantes.Text
        Dim emailcriador = Nick_Email.Item(NickBox.SelectedItem)


        If nome = "" Or nome.Length > 40 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If Not (IsNumeric(maximoparticipantes)) Then
            If Not maximoparticipantes = "" Then
                valido = False
                inputMaximoParticipantes.ForeColor = Color.Red
            Else
                maximoparticipantes = 0
            End If
        Else
            maximoparticipantes = Convert.ToInt32(maximoparticipantes)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If maximoparticipantes = 0 Then
                CMD.CommandText = "INSERT INTO ProjetoBD.LIGA (Nome,EmailCriador) VALUES (@nome,@emailcriador);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@emailcriador", emailcriador)
            Else
                CMD.CommandText = "INSERT INTO ProjetoBD.LIGA (Nome,MaximoParticipantes,EmailCriador) VALUES (@nome,@maximoparticipantes,@emailcriador);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@emailcriador", emailcriador)
                CMD.Parameters.AddWithValue("@maximoparticipantes", maximoparticipantes)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Liga Inserida Com Sucesso!")
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
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputMaximoParticipantes.ForeColor = Color.Black

        Dim valido = True
        Dim id = inputID.Text
        Dim nome = inputNome.Text
        Dim maximoparticipantes = inputMaximoParticipantes.Text
        Dim emailcriador = Nick_Email.Item(NickBox.SelectedItem)

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
        End If

        If nome.Length > 40 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If Not (IsNumeric(maximoparticipantes)) Then
            If Not maximoparticipantes = "" Then
                valido = False
                inputMaximoParticipantes.ForeColor = Color.Red
            Else
                maximoparticipantes = 0
            End If
        Else
            maximoparticipantes = Convert.ToInt32(maximoparticipantes)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If maximoparticipantes = 0 Then
                CMD.CommandText = "UPDATE ProjetoBD.LIGA SET nome = @nome WHERE id_Liga = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@id", id)
            ElseIf nome = "" Then
                CMD.CommandText = "UPDATE ProjetoBD.LIGA SET MaximoParticipantes = @maximoparticipantes WHERE id_Liga = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@maximoparticipantes", maximoparticipantes)
            Else
                CMD.CommandText = "UPDATE ProjetoBD.LIGA SET nome = @nome, MaximoParticipantes = @maximoparticipantes WHERE id_Liga = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@maximoparticipantes", maximoparticipantes)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Liga Atualizada Com Sucesso!")
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
        inputID.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
            CMD.CommandText = "Exec ProjetoBD.deleteLiga @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Liga Removida Com Sucesso!")
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
    Private Sub EquipaFictPartLiga_Click(sender As Object, e As EventArgs) Handles EquipaFictPartLigaButton.Click
        Me.Hide()
        EquipaFictPartLiga.Show()
        EquipaFictPartLiga.loadTuplos()
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

    Private Sub UtilizadorButton_Click(sender As Object, e As EventArgs) Handles UtilizadorButton.Click
        Me.Hide()
        Utilizador.Show()
        Utilizador.loadTuplos()
    End Sub

    Private Sub LigaFicticia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub JogosButton_Click(sender As Object, e As EventArgs) Handles JogosButton.Click
        Me.Hide()
        Jogo.Show()
        Jogo.loadTuplos()
    End Sub

    Private Sub Equipa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentLigaFicticia = ListagemListBox.SelectedIndex
            ShowTeam()
        End If
    End Sub

    Private Sub ShowTeam()
        If ListagemListBox.Items.Count = 0 Or currentLigaFicticia < 0 Then Exit Sub
        Dim LigaFicticia As New LigaFicticiaObject
        LigaFicticia = CType(ListagemListBox.Items.Item(currentLigaFicticia), LigaFicticiaObject)
        inputID.Text = LigaFicticia.ID
        inputNome.Text = LigaFicticia.Nome
        inputMaximoParticipantes.Text = LigaFicticia.MaximoParticipantes
        NickBox.SelectedIndex = NickBox.FindStringExact(Email_Nick.Item(LigaFicticia.EmailCriador))
    End Sub

    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim nome = input3Nome.Text
        Dim Nick = Nick3Box.SelectedItem

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        If Not Nick = "" Then
            Nick = Nick_Email.Item(Nick)
        End If
        CMD.CommandText = "SELECT * FROM projetoBD.getLigasFicticiasFiltradas(@nome,@nick)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@nick", Nick)
        CMD.Parameters.AddWithValue("@nome", nome)

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim LigaFicticia As New LigaFicticiaObject
            LigaFicticia.ID = RDR.Item("id_Liga")
            LigaFicticia.Nome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Nome")), "", RDR.Item("Nome")))
            LigaFicticia.MaximoParticipantes = RDR.Item("MaximoParticipantes")
            LigaFicticia.EmailCriador = RDR.Item("EmailCriador")
            pesquisaListBox.Items.Add(LigaFicticia)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchLeague = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchLeague < 0 Then Exit Sub
        Dim liga As New LigaFicticiaObject
        liga = CType(pesquisaListBox.Items.Item(currentSearchLeague), LigaFicticiaObject)
        input2ID.Text = liga.ID
        input2Nome.Text = liga.Nome
        input2MaximoParticipantes.Text = liga.MaximoParticipantes
        nick2Box.SelectedIndex = nick2Box.FindStringExact(Email_Nick.Item(liga.EmailCriador))
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class LigaFicticiaObject
    Public Property Nome As Object
    Public Property ID As Object
    Public Property MaximoParticipantes As Object
    Public Property EmailCriador As String
    Overrides Function ToString() As String
        Return Nome
    End Function
End Class