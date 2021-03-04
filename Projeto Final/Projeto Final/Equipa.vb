Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Equipa

    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentTeam As Integer
    Dim currentSearchTeam As Integer
    Dim ID_Campeonato As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Campeonato_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub Equipa_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.EQUIPAREAL"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim Equipa As New EquipaObject
            Equipa.id = RDR.Item("id_Equipa")
            Equipa.Nome = RDR.Item("Nome")
            Equipa.JogosJogados = RDR.Item("JogosJogados")
            Equipa.TotalPontos = RDR.Item("TotalPontos")
            Equipa.GolosMarcados = RDR.Item("GolosMarcados")
            Equipa.GolosSofridos = RDR.Item("GolosSofridos")
            Equipa.Campeonato = RDR.Item("Campeonato")
            Equipa.Classificacao = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Classificacao")), "", RDR.Item("Classificacao")))
            ListagemListBox.Items.Add(Equipa)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Campeonato"
        CN.Open()
        RDR = CMD.ExecuteReader
        campeonatoBox.Items.Clear()
        campeonato2Box.Items.Clear()
        campeonato3Box.Items.Clear()
        campeonato3Box.Items.Add("")
        ID_Campeonato.Clear()
        Campeonato_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Campeonato")
            Dim Nome = RDR.Item("Nome")
            ID_Campeonato.Add(ID, Nome)
            Campeonato_ID.Add(Nome, ID)
            campeonatoBox.Items.Add(Nome)
            campeonato2Box.Items.Add(Nome)
            campeonato3Box.Items.Add(Nome)
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

    Private Sub Clear()
        inputID.Text = ""
        inputNome.Text = ""
        inputJogosJogados.Text = ""
        inputTotalPontos.Text = ""
        inputGolosMarcados.Text = ""
        inputGolosSofridos.Text = ""
        inputClassificacao.Text = ""
        campeonatoBox.SelectedIndex = campeonatoBox.FindStringExact("")
        input2ID.Text = ""
        input2Nome.Text = ""
        input2JogosJogados.Text = ""
        input2TotalPontos.Text = ""
        input2GolosMarcados.Text = ""
        input2GolosSofridos.Text = ""
        input2Classificacao.Text = ""
        campeonato2Box.SelectedIndex = campeonato2Box.FindStringExact("")
        input3Nome.Text = ""
        campeonato3Box.SelectedIndex = campeonato3Box.FindStringExact("")

    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputJogosJogados.ForeColor = Color.Black
        inputTotalPontos.ForeColor = Color.Black
        inputGolosMarcados.ForeColor = Color.Black
        inputGolosSofridos.ForeColor = Color.Black
        inputClassificacao.ForeColor = Color.Black
        Dim valido = True
        Dim nome = inputNome.Text
        Dim jogosjogados = inputJogosJogados.Text
        Dim totalPontos = inputTotalPontos.Text
        Dim GolosMarcados = inputGolosMarcados.Text
        Dim GolosSofridos = inputGolosSofridos.Text
        Dim Campeonato = Campeonato_ID.Item(campeonatoBox.SelectedItem)
        Dim Classificacao = inputClassificacao.Text


        If nome = "" Or nome.Length > 20 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If Not (IsNumeric(jogosjogados)) Then
            If Not jogosjogados = "" Then
                valido = False
                inputJogosJogados.ForeColor = Color.Red
            Else
                jogosjogados = 0
            End If
        Else
            jogosjogados = Convert.ToInt32(jogosjogados)
        End If

        If Not (IsNumeric(totalPontos)) Then
            If Not totalPontos = "" Then
                valido = False
                inputTotalPontos.ForeColor = Color.Red
            Else
                totalPontos = 0
            End If
        Else
            totalPontos = Convert.ToInt32(totalPontos)
        End If


        If Not (IsNumeric(GolosMarcados)) Then
            If Not GolosMarcados = "" Then
                valido = False
                inputGolosMarcados.ForeColor = Color.Red
            Else
                GolosMarcados = 0
            End If
        Else
            GolosMarcados = Convert.ToInt32(GolosMarcados)
        End If

        If Not (IsNumeric(GolosSofridos)) Then
            If Not GolosSofridos = "" Then
                valido = False
                inputGolosSofridos.ForeColor = Color.Red
            Else
                GolosSofridos = 0
            End If
        Else
            GolosSofridos = Convert.ToInt32(GolosSofridos)
        End If

        If Not (IsNumeric(Classificacao)) Then
            If Not Classificacao = "" Then
                valido = False
                inputClassificacao.ForeColor = Color.Red
            End If
        Else
            Classificacao = Convert.ToInt32(Classificacao)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If Classificacao = "" Then
                CMD.CommandText = "INSERT INTO ProjetoBD.EQUIPAREAL (Nome,JogosJogados,TotalPontos,GolosMarcados,GolosSofridos,Campeonato) VALUES (@nome,@jogosjogados,@totalPontos,@GolosMarcados,@GolosSofridos,@Campeonato);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@jogosjogados", jogosjogados)
                CMD.Parameters.AddWithValue("@totalPontos", totalPontos)
                CMD.Parameters.AddWithValue("@GolosMarcados", GolosMarcados)
                CMD.Parameters.AddWithValue("@GolosSofridos", GolosSofridos)
                CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
            Else
                'CMD.CommandText = "INSERT INTO ProjetoBD.EQUIPAREAL (Nome,JogosJogados,TotalPontos,GolosMarcados,GolosSofridos,Campeonato,Classificacao) VALUES ('" & nome & "','" + jogosjogados & "','" + totalPontos & "','" + GolosMarcados & "','" + GolosSofridos & "','" + Campeonato & "','" + Classificacao & "');"
                CMD.CommandText = "INSERT INTO ProjetoBD.EQUIPAREAL (Nome,JogosJogados,TotalPontos,GolosMarcados,GolosSofridos,Campeonato) VALUES (@nome,@jogosjogados,@totalPontos,@GolosMarcados,@GolosSofridos,@Campeonato,@Classificacao);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@jogosjogados", jogosjogados)
                CMD.Parameters.AddWithValue("@totalPontos", totalPontos)
                CMD.Parameters.AddWithValue("@GolosMarcados", GolosMarcados)
                CMD.Parameters.AddWithValue("@GolosSofridos", GolosSofridos)
                CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
                CMD.Parameters.AddWithValue("@Classificacao", Classificacao)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Equipa Inserida Com Sucesso!")
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
        inputJogosJogados.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text
        Dim nome = inputNome.Text
        Dim Campeonato = Campeonato_ID.Item(campeonatoBox.SelectedItem)

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

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "UPDATE ProjetoBD.EQUIPAREAL SET Campeonato = @Campeonato, Nome = @nome WHERE id_Equipa = @id;"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
            CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
            CMD.Parameters.AddWithValue("@id", id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Os campos permitidos foram atualizados Com Sucesso!")
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
            CMD.CommandText = "Exec ProjetoBD.deleteEquipaReal @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Equipa Removida Com Sucesso!")
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
            currentTeam = ListagemListBox.SelectedIndex
            ShowTeam()
        End If
    End Sub

    Private Sub ShowTeam()
        If ListagemListBox.Items.Count = 0 Or currentTeam < 0 Then Exit Sub
        Dim equipa As New EquipaObject
        equipa = CType(ListagemListBox.Items.Item(currentTeam), EquipaObject)
        inputID.Text = equipa.id
        inputNome.Text = equipa.Nome
        inputJogosJogados.Text = equipa.JogosJogados
        inputTotalPontos.Text = equipa.TotalPontos
        inputGolosMarcados.Text = equipa.GolosMarcados
        inputGolosSofridos.Text = equipa.GolosSofridos
        campeonatoBox.SelectedIndex = campeonatoBox.FindStringExact(ID_Campeonato.Item(equipa.Campeonato))
        inputClassificacao.Text = equipa.Classificacao
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


    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim nome = input3Nome.Text
        Dim Campeonato = campeonato3Box.SelectedItem

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        If Not Campeonato = "" Then
            Campeonato = Campeonato_ID.Item(Campeonato)
            CMD.CommandText = "SELECT * FROM ProjetoBD.getEquipasFiltradas(@Campeonato,@nome)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
            CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
        Else
            CMD.CommandText = "SELECT * FROM ProjetoBD.getEquipasFiltradas(-1, @nome)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
        End If

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim Equipa As New EquipaObject
            Equipa.id = RDR.Item("id_Equipa")
            Equipa.Nome = RDR.Item("Nome")
            Equipa.JogosJogados = RDR.Item("JogosJogados")
            Equipa.TotalPontos = RDR.Item("TotalPontos")
            Equipa.GolosMarcados = RDR.Item("GolosMarcados")
            Equipa.GolosSofridos = RDR.Item("GolosSofridos")
            Equipa.Campeonato = RDR.Item("Campeonato")
            Equipa.Classificacao = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Classificacao")), "", RDR.Item("Classificacao")))
            pesquisaListBox.Items.Add(Equipa)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchTeam = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchTeam < 0 Then Exit Sub
        Dim equipa As New EquipaObject
        equipa = CType(pesquisaListBox.Items.Item(currentSearchTeam), EquipaObject)
        input2ID.Text = equipa.id
        input2Nome.Text = equipa.Nome
        input2JogosJogados.Text = equipa.JogosJogados
        input2TotalPontos.Text = equipa.TotalPontos
        input2GolosMarcados.Text = equipa.GolosMarcados
        input2GolosSofridos.Text = equipa.GolosSofridos
        campeonato2Box.SelectedIndex = campeonato2Box.FindStringExact(ID_Campeonato.Item(equipa.Campeonato))
        input2Classificacao.Text = equipa.Classificacao
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class EquipaObject
    Public Property id As Object
    Public Property Nome As Object
    Public Property JogosJogados As Object
    Public Property TotalPontos As String
    Public Property GolosMarcados As Object
    Public Property GolosSofridos As String
    Public Property Campeonato As String
    Public Property Classificacao As String

    Overrides Function ToString() As String
        Return Nome
    End Function
End Class