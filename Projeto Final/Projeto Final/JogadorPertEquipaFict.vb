Imports System.Configuration
Imports System.Data.SqlClient

Public Class JogadorPertEquipaFict
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentJogadorPertEquipaFict As Integer
    Dim currentSearchJogador As Integer
    Dim ID_Jogador As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Jogador_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ID_EquipaFict As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim EquipaFict_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ID_Equipa As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Equipa_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub JogadorPlaysInJogo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Jogador"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        JogadorNome1Box.Items.Clear()
        JogadorNome2Box.Items.Clear()
        ID_Jogador.Clear()
        Jogador_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Jogador")
            Dim Nome = RDR.Item("Nome")
            ID_Jogador.Add(ID, Nome)
            Jogador_ID.Add(Nome, ID)
            JogadorNome2Box.Items.Add(Nome)
            JogadorNome1Box.Items.Add(Nome)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa_Fict"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipaFictNomeBox.Items.Clear()
        equipafict3Box.Items.Clear()
        ID_EquipaFict.Clear()
        EquipaFict_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa_Ficticia")
            Dim Equipa = RDR.Item("Nome")
            equipaFictNomeBox.Items.Add(Equipa)
            equipafict3Box.Items.Add(Equipa)
            ID_EquipaFict.Add(ID, Equipa)
            EquipaFict_ID.Add(Equipa, ID)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.JogadorPertenceEquipaFict"
        CN.Open()
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim JogadorPertEquipaFict As New JogadorPertEquipaFictObject
            JogadorPertEquipaFict.Equipa_Fict_ID = RDR.Item("EquipaFict_ID")
            JogadorPertEquipaFict.Jogador_ID = RDR.Item("Jogador_ID")
            JogadorPertEquipaFict.Jogador_Nome = ID_Jogador.Item(JogadorPertEquipaFict.Jogador_ID)
            JogadorPertEquipaFict.Equipa_Fict_Nome = ID_EquipaFict.Item(JogadorPertEquipaFict.Equipa_Fict_ID)
            ListagemListBox.Items.Add(JogadorPertEquipaFict)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipa2box.Items.Clear()
        posicao2box.Items.Clear()
        ID_Equipa.Clear()
        Equipa_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa")
            Dim Equipa = RDR.Item("Nome")
            ID_Equipa.Add(ID, Equipa)
            Equipa_ID.Add(Equipa, ID)
            equipa2box.Items.Add(Equipa)
        End While
        CN.Close()
        posicao2box.Items.Clear()
        posicao2box.Items.Add("GR")
        posicao2box.Items.Add("DD")
        posicao2box.Items.Add("DC")
        posicao2box.Items.Add("DE")
        posicao2box.Items.Add("MD")
        posicao2box.Items.Add("MO")
        posicao2box.Items.Add("ED")
        posicao2box.Items.Add("EE")
        posicao2box.Items.Add("PL")
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
        inputEquipaFictID.Text = ""
        inputJogadorID.Text = ""
        input2JogadorID.Text = ""
        input2DataNasc.Text = ""
        input2Nacionalidade.Text = ""
        equipafict3Box.SelectedIndex = equipafict3Box.FindStringExact("")
        equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact("")
        JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact("")
        JogadorNome2Box.SelectedIndex = JogadorNome2Box.FindStringExact("")
        equipa2box.SelectedIndex = equipa2box.FindStringExact("")
        posicao2box.SelectedIndex = posicao2box.FindStringExact("")
    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputEquipaFictID.ForeColor = Color.Black
        inputJogadorID.ForeColor = Color.Black

        Dim valido = True
        Dim id_EquipaFict_id = EquipaFict_ID.Item(equipaFictNomeBox.SelectedItem)
        Dim id_Jogador_id = Jogador_ID.Item(JogadorNome1Box.SelectedItem)


        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "INSERT INTO ProjetoBD.JOGADORPERTENCEEQUIPAFICT (EquipaFict_ID, Jogador_ID) VALUES (@id_Equipa,@id_Jogador);"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id_Equipa", id_EquipaFict_id)
            CMD.Parameters.AddWithValue("@id_Jogador", id_Jogador_id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("JogadorPertenceEquipaFicticia Inserido Com Sucesso!")
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
        inputEquipaFictID.ForeColor = Color.Black
        inputJogadorID.ForeColor = Color.Black

        Dim valido = True
        Dim id_EquipaFict_id = equipaFictNomeBox.SelectedItem
        Dim id_Jogador_id = JogadorNome1Box.SelectedItem

        Try
            id_EquipaFict_id = EquipaFict_ID.Item(id_EquipaFict_id)
            id_Jogador_id = Jogador_ID.Item(id_Jogador_id)
        Catch ex As Exception
            MsgBox("Selecione um Jogador Válido e uma Equipa Válida!")
            Return
        End Try


        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD.CommandText = "DELETE ProjetoBD.JogadorPertenceEquipaFict WHERE EquipaFict_ID=@id1 and Jogador_ID=@id2 "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id1", id_EquipaFict_id)
            CMD.Parameters.AddWithValue("@id2", id_Jogador_id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("JogadorPertenceEquipaFict Removido Com Sucesso!")
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

    Private Sub Jogo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
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
    Private Sub EquipaFictPartLiga_Click(sender As Object, e As EventArgs) Handles EquipaFictPartLigaButton.Click
        Me.Hide()
        EquipaFictPartLiga.Show()
        EquipaFictPartLiga.loadTuplos()
    End Sub
    Private Sub EquipaFictButton_Click(sender As Object, e As EventArgs) Handles EquipaFictButton.Click
        Me.Hide()
        EquipaFicticia.Show()
        EquipaFicticia.loadTuplos()
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

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentJogadorPertEquipaFict = ListagemListBox.SelectedIndex
            ShowJogadorPertenceEquipaFict()
        End If
    End Sub

    Private Sub ShowJogadorPertenceEquipaFict()
        If ListagemListBox.Items.Count = 0 Or currentJogadorPertEquipaFict < 0 Then Exit Sub
        Dim JogadorPertEquipaFict As New JogadorPertEquipaFictObject
        JogadorPertEquipaFict = CType(ListagemListBox.Items.Item(currentJogadorPertEquipaFict), JogadorPertEquipaFictObject)
        inputJogadorID.Text = JogadorPertEquipaFict.Jogador_ID
        inputEquipaFictID.Text = JogadorPertEquipaFict.Equipa_Fict_ID
        JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact(ID_Jogador.Item(JogadorPertEquipaFict.Jogador_ID))
        equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact(ID_EquipaFict.Item(JogadorPertEquipaFict.Equipa_Fict_ID))
    End Sub

    Private Sub inputJogadorID_TextChanged(sender As Object, e As EventArgs) Handles inputJogadorID.TextChanged
        Try
            JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact(ID_Jogador.Item(inputJogadorID.Text))
        Catch ex As Exception
            JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact("")
        End Try
    End Sub

    Private Sub inputEquipaFictID_TextChanged(sender As Object, e As EventArgs) Handles inputEquipaFictID.TextChanged
        Try
            equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact(ID_EquipaFict.Item(inputEquipaFictID.Text))
        Catch ex As Exception
            equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact("")
        End Try
    End Sub

    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim id = equipafict3Box.SelectedItem
        If Not id = "" Then
            id = EquipaFict_ID.Item(id)
        Else
            MsgBox("Deve Selecionar Uma Liga")
            Return
        End If

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN


        CMD.CommandText = "SELECT * FROM projetoBD.getJogadorPertEquipaFictFiltrados(@id)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@id", id)
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim jogador As New JogadorObject
            jogador.ID = RDR.Item("id_Jogador")
            jogador.Nome = RDR.Item("Nome")
            jogador.Data_Nasc = Convert.ToDateTime(IIf(RDR.IsDBNull(RDR.GetOrdinal("Data_Nasc")), "", RDR.Item("Data_Nasc")))
            jogador.Nacionalidade = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Nacionalidade")), "", RDR.Item("Nacionalidade")))
            jogador.Equipa = RDR.Item("Equipa")
            jogador.Posicao = RDR.Item("Posicao")
            pesquisaListBox.Items.Add(jogador)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchJogador = pesquisaListBox.SelectedIndex
            ShowJogador()
        End If
    End Sub

    Private Sub ShowJogador()
        If pesquisaListBox.Items.Count = 0 Or currentSearchJogador < 0 Then Exit Sub
        Dim jogador As New JogadorObject
        jogador = CType(pesquisaListBox.Items.Item(currentSearchJogador), JogadorObject)
        input2JogadorID.Text = jogador.ID
        input2DataNasc.Text = jogador.Data_Nasc
        input2Nacionalidade.Text = jogador.Nacionalidade
        posicao2box.SelectedIndex = posicao2box.FindStringExact(jogador.Posicao)
        equipa2box.SelectedIndex = equipa2box.FindStringExact(ID_Equipa.Item(jogador.Equipa))
        JogadorNome2Box.SelectedIndex = JogadorNome2Box.FindStringExact(ID_Jogador.Item(jogador.ID))
    End Sub

    Private Sub JogadorPlaysInJogoButton_Click(sender As Object, e As EventArgs) Handles JogadorPlaysInJogoButton.Click
        Me.Hide()
        JogadorPlaysInJogo.Show()
        JogadorPlaysInJogo.loadTuplos()
    End Sub

End Class

Public Class JogadorPertEquipaFictObject
    Public Property Jogador_ID As Object
    Public Property Equipa_Fict_ID As Object
    Public Property Jogador_Nome As Object
    Public Property Equipa_Fict_Nome As Object

    Overrides Function ToString() As String
        Return Jogador_Nome & " -> " & Equipa_Fict_Nome
    End Function
End Class