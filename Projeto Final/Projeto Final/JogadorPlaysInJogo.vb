Imports System.Configuration
Imports System.Data.SqlClient

Public Class JogadorPlaysInJogo
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentJogadorPlaysInJogo As Integer
    Dim currentSearchJogador As Integer
    Dim ID_Jogador As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Jogador_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
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
        CMD.CommandText = "SELECT * FROM ProjetoBD.JogadorPlaysInJogo"
        CN.Open()
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim JogadorPlaysInJogo As New JogadorPlaysInJogoObject
            JogadorPlaysInJogo.Jogo_ID = RDR.Item("Jogo_ID")
            JogadorPlaysInJogo.Jogador_ID = RDR.Item("Jogador_ID")
            JogadorPlaysInJogo.Pontuacao = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Pontuacao")), "", RDR.Item("Pontuacao")))
            JogadorPlaysInJogo.Jogador_Nome = ID_Jogador.Item(JogadorPlaysInJogo.Jogador_ID)
            ListagemListBox.Items.Add(JogadorPlaysInJogo)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipa2box.Items.Clear()
        EquipaCasa3Box.Items.Clear()
        EquipaFora3Box.Items.Clear()
        posicao2box.Items.Clear()
        ID_Equipa.Clear()
        Equipa_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa")
            Dim Equipa = RDR.Item("Nome")
            ID_Equipa.Add(ID, Equipa)
            Equipa_ID.Add(Equipa, ID)
            equipa2box.Items.Add(Equipa)
            EquipaFora3Box.Items.Add(Equipa)
            EquipaCasa3Box.Items.Add(Equipa)
        End While
        CN.Close()
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
        inputJogoID.Text = ""
        inputJogadorID.Text = ""
        inputPontuacao.Text = ""
        input2JogadorID.Text = ""
        input2DataNasc.Text = ""
        input2Nacionalidade.Text = ""
        EquipaCasa3Box.SelectedIndex = EquipaCasa3Box.FindStringExact("")
        EquipaFora3Box.SelectedIndex = EquipaFora3Box.FindStringExact("")
        JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact("")
        JogadorNome2Box.SelectedIndex = JogadorNome2Box.FindStringExact("")
        posicao2box.SelectedIndex = posicao2box.FindStringExact("")
        equipa2box.SelectedIndex = equipa2box.FindStringExact("")
    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputJogoID.ForeColor = Color.Black
        inputJogadorID.ForeColor = Color.Black
        inputPontuacao.ForeColor = Color.Black
        Dim valido = True
        Dim Jogo_id = inputJogoID.Text
        Dim id_Jogador_id = Jogador_ID.Item(JogadorNome1Box.SelectedItem)
        Dim Pontuacao = inputPontuacao.Text

        If Not (IsNumeric(Jogo_id)) Then
            valido = False
            inputJogoID.ForeColor = Color.Red
        Else
            Jogo_id = Convert.ToInt32(Jogo_id)
        End If


        If Not (IsNumeric(Pontuacao)) Then
            valido = False
            inputPontuacao.ForeColor = Color.Red
        Else
            Pontuacao = Convert.ToDouble(Pontuacao)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "INSERT INTO ProjetoBD.JogadorPlaysInJogo (Jogador_ID,Jogo_ID,Pontuacao) VALUES (@id_Jogador,@id_Jogo,@Pontuacao);"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id_Jogador", id_Jogador_id)
            CMD.Parameters.AddWithValue("@id_Jogo", Jogo_id)
            CMD.Parameters.AddWithValue("@Pontuacao", Replace(Pontuacao, ",", "."))
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            MsgBox("JogadorPlaysInJogo Inserido Com Sucesso!")
            pesquisaListBox.Items.Clear()
            Clear()
            loadTuplos()
        End If
    End Sub

    Private Sub AtualizarButton_Click(sender As Object, e As EventArgs) Handles AtualizarButton.Click
        inputJogoID.ForeColor = Color.Black
        inputJogadorID.ForeColor = Color.Black
        inputPontuacao.ForeColor = Color.Black
        Dim valido = True
        Dim Jogo_id = inputJogoID.Text
        Dim id_Jogador_id = JogadorNome1Box.SelectedItem
        Dim Pontuacao = inputPontuacao.Text

        Try
            id_Jogador_id = Jogador_ID.Item(id_Jogador_id)
        Catch ex As Exception
            MsgBox("Selecione um Jogador valido!")
            Return
        End Try

        If Not (IsNumeric(Jogo_id)) Then
            valido = False
            inputJogoID.ForeColor = Color.Red
        Else
            Jogo_id = Convert.ToInt32(Jogo_id)
        End If


        If Not (IsNumeric(Pontuacao)) Then
            valido = False
            inputPontuacao.ForeColor = Color.Red
        Else
            Pontuacao = Convert.ToDouble(Pontuacao)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "UPDATE ProjetoBD.JogadorPlaysInJogo SET Pontuacao = @Pontuacao WHERE Jogo_ID = @id_Jogo and Jogador_ID = @id_Jogador;"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id_Jogador", id_Jogador_id)
            CMD.Parameters.AddWithValue("@id_Jogo", Jogo_id)
            CMD.Parameters.AddWithValue("@Pontuacao", Replace(Pontuacao, ",", "."))
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            MsgBox("JogadorPlaysInJogo atualizado Com Sucesso!")
            pesquisaListBox.Items.Clear()
            Clear()
            loadTuplos()
        End If
    End Sub

    Private Sub RemoverButton_Click(sender As Object, e As EventArgs) Handles RemoverButton.Click
        inputJogoID.ForeColor = Color.Black
        inputJogadorID.ForeColor = Color.Black
        Dim valido = True
        Dim Jogo_id = inputJogoID.Text
        Dim id_Jogador_id = JogadorNome1Box.SelectedItem

        Try
            id_Jogador_id = Jogador_ID.Item(id_Jogador_id)
        Catch ex As Exception
            MsgBox("Selecione um Jogador valido!")
            Return
        End Try

        If Not (IsNumeric(Jogo_id)) Then
            valido = False
            inputJogoID.ForeColor = Color.Red
        Else
            Jogo_id = Convert.ToInt32(Jogo_id)
        End If


        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD.CommandText = "DELETE ProjetoBD.JogadorPlaysInJogo WHERE Jogo_ID=@id1 and Jogador_ID=@id2 "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id1", Jogo_id)
            CMD.Parameters.AddWithValue("@id2", id_Jogador_id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                Throw New Exception("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()
            MsgBox("JogadorPlaysInJogo Removido Com Sucesso!")
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

    Private Sub LigaFictButton_Click(sender As Object, e As EventArgs) Handles LigaFictButton.Click
        Me.Hide()
        LigaFicticia.Show()
        LigaFicticia.Show()
    End Sub

    Private Sub UtilizadorButton_Click(sender As Object, e As EventArgs) Handles UtilizadorButton.Click
        Me.Hide()
        Utilizador.Show()
        Utilizador.loadTuplos()
    End Sub

    Private Sub JogadorPertEquipaFictButton_Click(sender As Object, e As EventArgs) Handles JogadorPertEquipaFictButton.Click
        Me.Hide()
        JogadorPertEquipaFict.Show()
        JogadorPertEquipaFict.loadTuplos()
    End Sub

    Private Sub JogosButton_Click(sender As Object, e As EventArgs) Handles JogosButton.Click
        Me.Hide()
        Jogo.Show()
        Jogo.loadTuplos()
    End Sub

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentJogadorPlaysInJogo = ListagemListBox.SelectedIndex
            ShowJogadorPlaysInJogo()
        End If
    End Sub

    Private Sub ShowJogadorPlaysInJogo()
        If ListagemListBox.Items.Count = 0 Or currentJogadorPlaysInJogo < 0 Then Exit Sub
        Dim JogadorPlaysInJogo As New JogadorPlaysInJogoObject
        JogadorPlaysInJogo = CType(ListagemListBox.Items.Item(currentJogadorPlaysInJogo), JogadorPlaysInJogoObject)
        inputJogadorID.Text = JogadorPlaysInJogo.Jogador_ID
        inputJogoID.Text = JogadorPlaysInJogo.Jogo_ID
        inputPontuacao.Text = JogadorPlaysInJogo.Pontuacao
        JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact(ID_Jogador.Item(JogadorPlaysInJogo.Jogador_ID))
    End Sub

    Private Sub inputJogadorID_TextChanged(sender As Object, e As EventArgs) Handles inputJogadorID.TextChanged
        Try
            JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact(ID_Jogador.Item(inputJogadorID.Text))
        Catch ex As Exception
            JogadorNome1Box.SelectedIndex = JogadorNome1Box.FindStringExact("")
        End Try
    End Sub

    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim casa_id = EquipaCasa3Box.SelectedItem
        Dim fora_id = EquipaFora3Box.SelectedItem
        If Not (casa_id = "" Or fora_id = "") Then
            casa_id = Equipa_ID.Item(casa_id)
            fora_id = Equipa_ID.Item(fora_id)
        Else
            MsgBox("Deve Selecionar ambas as equipas!")
            Return
        End If



        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN


        CMD.CommandText = "SELECT * FROM projetoBD.getJogadorPlaysInJogoFiltrados(@casa_id,@fora_id)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@casa_id", casa_id)
        CMD.Parameters.AddWithValue("@fora_id", fora_id)
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

End Class


Public Class JogadorPlaysInJogoObject
    Public Property Jogador_ID As Object
    Public Property Jogo_ID As Object
    Public Property Pontuacao As Object
    Public Property Jogador_Nome As Object

    Overrides Function ToString() As String
        Return Jogador_Nome & " -> " & Jogo_ID

    End Function
End Class