Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Jogador
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentPlayer As Integer
    Dim currentSearchPlayer As Integer
    Dim ID_Equipa As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Equipa_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub Jogador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.JOGADOR"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim Jogador As New JogadorObject
            Jogador.ID = RDR.Item("id_Jogador")
            Jogador.Nome = RDR.Item("Nome")
            Jogador.Data_Nasc = Convert.ToDateTime(IIf(RDR.IsDBNull(RDR.GetOrdinal("Data_Nasc")), "", RDR.Item("Data_Nasc")))
            Jogador.Nacionalidade = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Nacionalidade")), "", RDR.Item("Nacionalidade")))
            Jogador.Equipa = RDR.Item("Equipa")
            Jogador.Posicao = RDR.Item("Posicao")
            ListagemListBox.Items.Add(Jogador)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipaBox.Items.Clear()
        equipa2box.Items.Clear()
        equipa3Box.Items.Clear()
        PosicaoBox.Items.Clear()
        posicao2box.Items.Clear()
        posicao3box.Items.Clear()
        posicao3box.Items.Add("")
        equipa3Box.Items.Add("")
        equipa3Box.SelectedIndex = PosicaoBox.FindStringExact("")
        ID_Equipa.Clear()
        Equipa_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa")
            Dim Equipa = RDR.Item("Nome")
            ID_Equipa.Add(ID, Equipa)
            Equipa_ID.Add(Equipa, ID)
            equipaBox.Items.Add(Equipa)
            equipa2box.Items.Add(Equipa)
            equipa3Box.Items.Add(Equipa)
        End While
        CN.Close()
        PosicaoBox.Items.Add("GR")
        PosicaoBox.Items.Add("DD")
        PosicaoBox.Items.Add("DC")
        PosicaoBox.Items.Add("DE")
        PosicaoBox.Items.Add("MD")
        PosicaoBox.Items.Add("MO")
        PosicaoBox.Items.Add("ED")
        PosicaoBox.Items.Add("EE")
        PosicaoBox.Items.Add("PL")
        posicao2box.Items.Add("GR")
        posicao2box.Items.Add("DD")
        posicao2box.Items.Add("DC")
        posicao2box.Items.Add("DE")
        posicao2box.Items.Add("MD")
        posicao2box.Items.Add("MO")
        posicao2box.Items.Add("ED")
        posicao2box.Items.Add("EE")
        posicao2box.Items.Add("PL")
        posicao3box.Items.Add("GR")
        posicao3box.Items.Add("DD")
        posicao3box.Items.Add("DC")
        posicao3box.Items.Add("DE")
        posicao3box.Items.Add("MD")
        posicao3box.Items.Add("MO")
        posicao3box.Items.Add("ED")
        posicao3box.Items.Add("EE")
        posicao3box.Items.Add("PL")
        posicao3box.SelectedIndex = posicao3box.FindStringExact("")
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

    Private Sub EquipaFictPartLiga_Click(sender As Object, e As EventArgs) Handles EquipaFictPartLigaButton.Click
        Me.Hide()
        EquipaFictPartLiga.Show()
        EquipaFictPartLiga.loadTuplos()
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

    Private Sub EstadioButton_Click(sender As Object, e As EventArgs) Handles EstadioButton.Click
        Me.Hide()
        Estadio.Show()
        Estadio.loadTuplos()
    End Sub

    Private Sub Clear()
        inputID.Text = ""
        inputNome.Text = ""
        inputDataNasc.Text = ""
        inputNacionalidade.Text = ""
        input2ID.Text = ""
        input2Nome.Text = ""
        input2DataNasc.Text = ""
        input2Nacionalidade.Text = ""
        input3Nacionalidade.Text = ""
        input3Nome.Text = ""
        PosicaoBox.SelectedIndex = PosicaoBox.FindStringExact("")
        equipaBox.SelectedIndex = equipaBox.FindStringExact("")
        posicao2box.SelectedIndex = posicao2box.FindStringExact("")
        equipa2box.SelectedIndex = equipa2box.FindStringExact("")
        posicao3box.SelectedIndex = posicao3box.FindStringExact("")
        equipa3Box.SelectedIndex = equipa3Box.FindStringExact("")

    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputDataNasc.ForeColor = Color.Black
        inputNacionalidade.ForeColor = Color.Black

        Dim valido = True
        Dim nome = inputNome.Text
        Dim DataNasc = inputDataNasc.Text
        Dim Nacionalidade = inputNacionalidade.Text
        Dim Posicao = PosicaoBox.SelectedItem
        Dim Equipa = Equipa_ID.Item(equipaBox.SelectedItem)


        If nome = "" Or nome.Length > 20 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If Nacionalidade.Length > 35 Then
            valido = False
            inputNacionalidade.ForeColor = Color.Red
        Else
            Nacionalidade = Replace(Nacionalidade, "'", "''")
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
            Console.WriteLine(DataNasc)
            If Nacionalidade = "" Then
                CMD.CommandText = "INSERT INTO ProjetoBD.Jogador (Nome,Data_Nasc,Equipa,Posicao) VALUES (@nome,@data,@Equipa,@Posicao);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@data", DataNasc)
                CMD.Parameters.AddWithValue("@Equipa", Equipa)
                CMD.Parameters.AddWithValue("@Posicao", Posicao)
            Else
                CMD.CommandText = "INSERT INTO ProjetoBD.Jogador (Nome,Data_Nasc,Nacionalidade,Equipa,Posicao) VALUES (@nome,@data,@Nacionalidade,@Equipa,@Posicao);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@data", DataNasc)
                CMD.Parameters.AddWithValue("@Equipa", Equipa)
                CMD.Parameters.AddWithValue("@Posicao", Posicao)
                CMD.Parameters.AddWithValue("@Nacionalidade", Nacionalidade)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogador Inserido Com Sucesso!")
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
        Dim valido = True
        Dim ID = inputID.Text
        Dim nome = inputNome.Text
        Dim Nacionalidade = inputNacionalidade.Text
        Dim Posicao = PosicaoBox.SelectedItem
        Dim Equipa = Equipa_ID.Item(equipaBox.SelectedItem)


        If nome = "" Or nome.Length > 20 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If Not (IsNumeric(ID)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            ID = Convert.ToInt32(ID)
        End If

        If Nacionalidade.Length > 35 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            Nacionalidade = Replace(Nacionalidade, "'", "''")
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "UPDATE ProjetoBD.JOGADOR SET Posicao = @Posicao, Equipa=@Equipa, Nome = @nome, Nacionalidade = @Nacionalidade WHERE id_Jogador = @id;"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
            CMD.Parameters.AddWithValue("@id", ID)
            CMD.Parameters.AddWithValue("@Equipa", Equipa)
            CMD.Parameters.AddWithValue("@Posicao", Posicao)
            CMD.Parameters.AddWithValue("@Nacionalidade", Nacionalidade)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogador Atualizado Com Sucesso!")
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

        If ID = "" Or Not (IsNumeric(ID)) Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            CMD.CommandText = "Exec ProjetoBD.deleteJogador @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", ID)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogador Removido Com Sucesso!")
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

    Private Sub ListagemListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListagemListBox.SelectedIndexChanged
        If ListagemListBox.SelectedIndex > -1 Then
            currentPlayer = ListagemListBox.SelectedIndex
            ShowPlayer()
        End If
    End Sub

    Private Sub ShowPlayer()
        If ListagemListBox.Items.Count = 0 Or currentPlayer < 0 Then Exit Sub
        Dim Jogador As New JogadorObject
        Jogador = CType(ListagemListBox.Items.Item(currentPlayer), JogadorObject)
        inputID.Text = Jogador.ID
        inputNome.Text = Jogador.Nome
        inputDataNasc.Text = Jogador.Data_Nasc
        inputNacionalidade.Text = Jogador.Nacionalidade
        PosicaoBox.SelectedIndex = PosicaoBox.FindStringExact(Jogador.Posicao)
        equipaBox.SelectedIndex = equipaBox.FindStringExact(ID_Equipa.Item(Jogador.Equipa))
    End Sub

    Private Sub EquipaFictButton_Click(sender As Object, e As EventArgs) Handles EquipaFictButton.Click
        Me.Hide()
        EquipaFicticia.Show()
        EquipaFicticia.loadTuplos()
    End Sub

    Private Sub Jogador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub EquipaButton_Click(sender As Object, e As EventArgs) Handles EquipaButton.Click
        Me.Hide()
        Equipa.Show()
        Equipa.loadTuplos()
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
        Dim nome = input3Nome.Text
        Dim nacionalidade = input3Nacionalidade.Text
        Dim posicao = posicao3box.SelectedItem
        Dim equipa = equipa3Box.SelectedItem

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        If Not equipa = "" Then
            equipa = Equipa_ID.Item(equipa)
        Else
            equipa = -1
        End If

        CMD.CommandText = "SELECT * FROM projetoBD.getJogadoresFiltrados(@nome,@nacionalidade,@posicao,@equipa)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@nome", nome)
        CMD.Parameters.AddWithValue("@nacionalidade", nacionalidade)
        CMD.Parameters.AddWithValue("@posicao", posicao)
        CMD.Parameters.AddWithValue("@equipa", equipa)
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
            currentSearchPlayer = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchPlayer < 0 Then Exit Sub
        Dim jogador As New JogadorObject
        jogador = CType(pesquisaListBox.Items.Item(currentSearchPlayer), JogadorObject)
        input2ID.Text = jogador.ID
        input2Nome.Text = jogador.Nome
        input2DataNasc.Text = jogador.Data_Nasc
        input2Nacionalidade.Text = jogador.Nacionalidade
        posicao2box.SelectedIndex = posicao2box.FindStringExact(jogador.Posicao)
        equipa2box.SelectedIndex = equipa2box.FindStringExact(ID_Equipa.Item(jogador.Equipa))
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class JogadorObject
    Public Property ID As Object
    Public Property Nome As Object
    Public Property Data_Nasc As Date
    Public Property Nacionalidade As String
    Public Property Equipa As Object
    Public Property Posicao As String
    Overrides Function ToString() As String
        Return Nome
    End Function
End Class