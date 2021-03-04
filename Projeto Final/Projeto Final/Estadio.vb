Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Estadio

    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentStadium As Integer
    Dim currentSearchStadium As Integer

    Private Sub Estadio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ESTADIO"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        localizacaoBox.Items.Clear()
        localizacaoBox.Items.Add("")
        localizacaoBox.SelectedIndex = localizacaoBox.FindStringExact("")
        While RDR.Read
            Dim Estadio As New EstadioObject
            Estadio.ID = RDR.Item("id_Estadio")
            Estadio.Nome = RDR.Item("Nome")
            Estadio.localizacao = RDR.Item("Localizacao")
            Estadio.TotalAssistencia = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("TotalAssistencia")), "", RDR.Item("TotalAssistencia")))
            ListagemListBox.Items.Add(Estadio)
            localizacaoBox.Items.Add(Estadio.localizacao)
        End While
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

    Private Sub EquipaFictPartLiga_Click(sender As Object, e As EventArgs) Handles EquipaFictPartLigaButton.Click
        Me.Hide()
        EquipaFictPartLiga.Show()
        EquipaFictPartLiga.loadTuplos()
    End Sub
    Private Sub EquipaButton_Click(sender As Object, e As EventArgs) Handles EquipaButton.Click
        Me.Hide()
        Equipa.Show()
        Equipa.loadTuplos()
    End Sub

    Private Sub JogadorButton_Click(sender As Object, e As EventArgs) Handles JogadorButton.Click
        Me.Hide()
        Jogador.Show()
        Jogador.loadTuplos()
    End Sub

    Private Sub Clear()
        inputID.Text = ""
        inputNome.Text = ""
        inputLocalizacao.Text = ""
        inputTotalAssistencia.Text = ""
        input2ID.Text = ""
        input2Nome.Text = ""
        input2Localizacao.Text = ""
        input2TotalAssistencia.Text = ""
        input3Nome.Text = ""
        inputMinimo.Text = ""
        inputMaximo.Text = ""
        localizacaoBox.SelectedIndex = localizacaoBox.FindStringExact("")
    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputNome.ForeColor = Color.Black
        inputLocalizacao.ForeColor = Color.Black
        inputTotalAssistencia.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text
        Dim nome = inputNome.Text
        Dim localizacao = inputLocalizacao.Text
        Dim totalAssistencia = inputTotalAssistencia.Text


        If nome = "" Or nome.Length > 55 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If localizacao = "" Or localizacao.Length > 25 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            localizacao = Replace(localizacao, "'", "''")
        End If

        If Not (IsNumeric(totalAssistencia)) Then
            If Not totalAssistencia = "" Then
                valido = False
                inputTotalAssistencia.ForeColor = Color.Red
            Else
                totalAssistencia = 0
            End If
        Else
            totalAssistencia = Convert.ToInt32(totalAssistencia)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If totalAssistencia = 0 Then
                CMD.CommandText = "INSERT INTO ProjetoBD.ESTADIO (Nome,Localizacao) VALUES (@nome,@localizacao);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@localizacao", localizacao)
            Else
                CMD.CommandText = "INSERT INTO ProjetoBD.ESTADIO (Nome,Localizacao,TotalAssistencia) VALUES (@nome,@localizacao,@totalAssistencia);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@localizacao", localizacao)
                CMD.Parameters.AddWithValue("@totalAssistencia", totalAssistencia)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Estadio Inserido Com Sucesso!")
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
        inputLocalizacao.ForeColor = Color.Black
        inputTotalAssistencia.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text
        Dim nome = inputNome.Text
        Dim localizacao = inputLocalizacao.Text
        Dim totalAssistencia = inputTotalAssistencia.Text

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
        End If

        If nome = "" Or nome.Length > 20 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If localizacao = "" Or localizacao.Length > 25 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            localizacao = Replace(localizacao, "'", "''")
        End If

        If Not (IsNumeric(totalAssistencia)) Then
            If Not totalAssistencia = "" Then
                valido = False
                inputTotalAssistencia.ForeColor = Color.Red
            Else
                totalAssistencia = 0
            End If
        Else
            totalAssistencia = Convert.ToInt32(totalAssistencia)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If totalAssistencia = 0 Then
                CMD.CommandText = "UPDATE ProjetoBD.ESTADIO SET Localizacao = @localizacao, Nome = @nome WHERE id_Estadio = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@localizacao", localizacao)
                CMD.Parameters.AddWithValue("@id", id)
            Else
                CMD.CommandText = "UPDATE ProjetoBD.ESTADIO SET Localizacao = @localizacao, Nome = @nome, totalAssistencia =  @totalAssistencia WHERE id_Estadio = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@localizacao", localizacao)
                CMD.Parameters.AddWithValue("@totalAssistencia", totalAssistencia)
                CMD.Parameters.AddWithValue("@id", id)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Estadio Atualizado Com Sucesso!")
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
        Dim ID = inputID.Text
        If Not (IsNumeric(ID)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            ID = Convert.ToInt32(ID)
            CMD.CommandText = "Exec ProjetoBD.deleteEstadio @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", ID)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Estadio Removido Com Sucesso!")
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

    Private Sub Equipa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentStadium = ListagemListBox.SelectedIndex
            ShowStadium()
        End If
    End Sub

    Private Sub ShowStadium()
        If ListagemListBox.Items.Count = 0 Or currentStadium < 0 Then Exit Sub
        Dim Estadio As New EstadioObject
        Estadio = CType(ListagemListBox.Items.Item(currentStadium), EstadioObject)
        inputID.Text = Estadio.ID
        inputNome.Text = Estadio.Nome
        inputLocalizacao.Text = Estadio.localizacao
        inputTotalAssistencia.Text = Estadio.TotalAssistencia
    End Sub

    Private Sub EquipaFictButton_Click(sender As Object, e As EventArgs) Handles EquipaFictButton.Click
        Me.Hide()
        EquipaFicticia.Show()
        EquipaFicticia.loadTuplos()
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

    Private Sub UtilizadorButton_Click(sender As Object, e As EventArgs) Handles UtilizadorButton.Click
        Me.Hide()
        Utilizador.Show()
        Utilizador.loadTuplos()
    End Sub


    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        inputMinimo.ForeColor = Color.Black
        inputMaximo.ForeColor = Color.Black
        Dim nome = input3Nome.Text
        Dim localizacao = localizacaoBox.SelectedItem
        Dim minimo = inputMinimo.Text
        Dim maximo = inputMaximo.Text
        Dim valido = True

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN

        If Not (IsNumeric(minimo)) Then
            If Not minimo = "" Then
                valido = False
                inputMinimo.ForeColor = Color.Red
            Else
                minimo = -1
            End If
        Else
            minimo = Convert.ToInt32(minimo)
        End If

        If Not (IsNumeric(maximo)) Then
            If Not maximo = "" Then
                valido = False
                inputMaximo.ForeColor = Color.Red
            Else
                maximo = 999999
            End If
        Else
            maximo = Convert.ToInt32(maximo)
        End If

        If valido Then
            CMD.CommandText = "SELECT * FROM projetoBD.getEstadiosFiltrados(@nome,@localizacao,@maximo,@minimo)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
            CMD.Parameters.AddWithValue("@localizacao", localizacao)
            CMD.Parameters.AddWithValue("@maximo", maximo)
            CMD.Parameters.AddWithValue("@minimo", minimo)
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            pesquisaListBox.Items.Clear()
            While RDR.Read
                Dim Estadio As New EstadioObject
                Estadio.ID = RDR.Item("id_Estadio")
                Estadio.Nome = RDR.Item("Nome")
                Estadio.localizacao = RDR.Item("Localizacao")
                Estadio.TotalAssistencia = RDR.Item("TotalAssistencia")
                pesquisaListBox.Items.Add(Estadio)
            End While
            CN.Close()
            Clear()
        End If
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchStadium = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchStadium < 0 Then Exit Sub
        Dim estadio As New EstadioObject
        estadio = CType(pesquisaListBox.Items.Item(currentSearchStadium), EstadioObject)
        input2ID.Text = estadio.ID
        input2Nome.Text = estadio.Nome
        input2Localizacao.Text = estadio.localizacao
        input2TotalAssistencia.Text = estadio.TotalAssistencia
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class EstadioObject
    Public Property ID As Object
    Public Property Nome As Object
    Public Property localizacao As Object
    Public Property TotalAssistencia As String
    Overrides Function ToString() As String
        Return Nome
    End Function
End Class