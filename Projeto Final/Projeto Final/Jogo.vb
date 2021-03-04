Imports System.Configuration
Imports System.Data.SqlClient

Public Class Jogo
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentJogo As Integer
    Dim currentSearchJogo As Integer
    Dim ID_Campeonato As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Campeonato_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ID_Equipa As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Equipa_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ID_Estadio As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Estadio_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Private Sub Jogo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Campeonato"
        CN.Open()
        Dim RDR As SqlDataReader
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
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipaCasaBox.Items.Clear()
        equipaCasa2Box.Items.Clear()
        equipaCasa3Box.Items.Clear()
        equipaForaBox.Items.Clear()
        equipaFora2Box.Items.Clear()
        equipaFora3Box.Items.Clear()
        equipaCasa3Box.Items.Add("")
        equipaFora3Box.Items.Add("")
        ID_Equipa.Clear()
        Equipa_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa")
            Dim Equipa = RDR.Item("Nome")
            ID_Equipa.Add(ID, Equipa)
            Equipa_ID.Add(Equipa, ID)
            equipaCasaBox.Items.Add(Equipa)
            equipaCasa2Box.Items.Add(Equipa)
            equipaCasa3Box.Items.Add(Equipa)
            equipaForaBox.Items.Add(Equipa)
            equipaFora2Box.Items.Add(Equipa)
            equipaFora3Box.Items.Add(Equipa)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_NomeEstadio"
        CN.Open()
        RDR = CMD.ExecuteReader
        estadioBox.Items.Clear()
        estadio2Box.Items.Clear()
        estadio3Box.Items.Clear()
        estadio3Box.Items.Add("")
        ID_Estadio.Clear()
        Estadio_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Estadio")
            Dim Estadio = RDR.Item("Nome")
            ID_Estadio.Add(ID, Estadio)
            Estadio_ID.Add(Estadio, ID)
            estadioBox.Items.Add(Estadio)
            estadio2Box.Items.Add(Estadio)
            estadio3Box.Items.Add(Estadio)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.JOGO"
        CN.Open()
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim Jogo As New JogoObject
            Jogo.ID = RDR.Item("id_Jogo")
            Jogo.Data = Convert.ToDateTime(IIf(RDR.IsDBNull(RDR.GetOrdinal("Data")), "", RDR.Item("Data")))
            Jogo.NumJornada = RDR.Item("NumJornada")
            Jogo.Assistência = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Assistência")), "", RDR.Item("Assistência")))
            Jogo.ResultadoCasa = RDR.Item("ResultadoCasa")
            Jogo.ResultadoFora = RDR.Item("ResultadoFora")
            Jogo.EquipaCasa = RDR.Item("EquipaCasa")
            Jogo.EquipaVisitante = RDR.Item("EquipaVisitante")
            Jogo.Campeonato = RDR.Item("Campeonato")
            Jogo.Estadio = RDR.Item("Estadio")
            Jogo.EquipaCasaNome = ID_Equipa.Item(Jogo.EquipaCasa)
            Jogo.EquipaVisitanteNome = ID_Equipa.Item(Jogo.EquipaVisitante)
            ListagemListBox.Items.Add(Jogo)
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

    Private Sub Clear()
        inputID.Text = ""
        inputData.Text = ""
        inputNumJornada.Text = ""
        inputAssistencia.Text = ""
        inputResultadoCasa.Text = ""
        inputResultadoFora.Text = ""
        input2ID.Text = ""
        input2Data.Text = ""
        input2NumJornada.Text = ""
        input2Assistencia.Text = ""
        input2ResultadoCasa.Text = ""
        input2ResultadoFora.Text = ""
        input3Data.Text = ""
        input3NumJornada.Text = ""
        equipaCasaBox.SelectedIndex = equipaCasaBox.FindStringExact("")
        equipaForaBox.SelectedIndex = equipaForaBox.FindStringExact("")
        campeonatoBox.SelectedIndex = campeonatoBox.FindStringExact("")
        estadioBox.SelectedIndex = estadioBox.FindStringExact("")
        equipaCasa2Box.SelectedIndex = equipaCasa2Box.FindStringExact("")
        equipaFora2Box.SelectedIndex = equipaFora2Box.FindStringExact("")
        campeonato2Box.SelectedIndex = campeonato2Box.FindStringExact("")
        estadio2Box.SelectedIndex = estadio2Box.FindStringExact("")
        equipaCasa3Box.SelectedIndex = equipaCasa3Box.FindStringExact("")
        equipaFora3Box.SelectedIndex = equipaFora3Box.FindStringExact("")
        campeonato3Box.SelectedIndex = campeonato3Box.FindStringExact("")
        estadio3Box.SelectedIndex = estadio3Box.FindStringExact("")

    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputData.ForeColor = Color.Black
        inputNumJornada.ForeColor = Color.Black
        inputAssistencia.ForeColor = Color.Black
        inputResultadoCasa.ForeColor = Color.Black
        inputResultadoFora.ForeColor = Color.Black
        Dim valido = True
        Dim Data = inputData.Text
        Dim NumJornada = inputNumJornada.Text
        Dim Assistencia = inputAssistencia.Text
        Dim ResultadoCasa = inputResultadoCasa.Text
        Dim ResultadoFora = inputResultadoFora.Text
        Dim EquipaCasa = Equipa_ID(equipaCasaBox.SelectedItem)
        Dim EquipaVisitante = Equipa_ID(equipaForaBox.SelectedItem)
        Dim Campeonato = Campeonato_ID.Item(campeonatoBox.SelectedItem)
        Dim Estadio = Estadio_ID.Item(estadioBox.SelectedItem)

        If Not (IsDate(Data)) Then
            valido = False
            inputData.ForeColor = Color.Red
        Else
            Data = Replace(Data, "/", "-")
            Dim parts As String() = Data.Split(New Char() {"-"c})
            Data = parts(2) + "-" + parts(1) + "-" + parts(0)
        End If

        If Not (IsNumeric(NumJornada)) Then
            valido = False
            inputNumJornada.ForeColor = Color.Red
        Else
            NumJornada = Convert.ToInt32(NumJornada)
        End If

        If Not (IsNumeric(Assistencia)) Then
            If Not Assistencia = "" Then
                valido = False
                inputAssistencia.ForeColor = Color.Red
            Else
                Assistencia = -1
            End If
        Else
            Assistencia = Convert.ToInt32(Assistencia)
        End If

        If Not (IsNumeric(ResultadoCasa)) Then
            valido = False
            inputResultadoCasa.ForeColor = Color.Red
        Else
            ResultadoCasa = Convert.ToInt32(ResultadoCasa)
        End If

        If Not (IsNumeric(ResultadoFora)) Then
            valido = False
            inputResultadoFora.ForeColor = Color.Red
        Else
            ResultadoFora = Convert.ToInt32(ResultadoFora)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If Assistencia = -1 Then
                CMD.CommandText = "INSERT INTO ProjetoBD.JOGO (Data,NumJornada,ResultadoCasa,ResultadoFora,EquipaCasa,EquipaVisitante,Campeonato,Estadio) VALUES (@data,@NumJornada,@ResultadoCasa,@ResultadoFora,@EquipaCasa,@EquipaVisitante,@Campeonato,@Estadio);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@data", Data)
                CMD.Parameters.AddWithValue("@NumJornada", NumJornada)
                CMD.Parameters.AddWithValue("@ResultadoCasa", ResultadoCasa)
                CMD.Parameters.AddWithValue("@ResultadoFora", ResultadoFora)
                CMD.Parameters.AddWithValue("@EquipaCasa", EquipaCasa)
                CMD.Parameters.AddWithValue("@EquipaVisitante", EquipaVisitante)
                CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
                CMD.Parameters.AddWithValue("@Estadio", Estadio)
            Else
                CMD.CommandText = "INSERT INTO ProjetoBD.JOGO (Data,NumJornada,Assistência,ResultadoCasa,ResultadoFora,EquipaCasa,EquipaVisitante,Campeonato,Estadio) VALUES (@data,@NumJornada,@Assistencia,@ResultadoCasa,@ResultadoFora,@EquipaCasa,@EquipaVisitante,@Campeonato,@Estadio);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@data", Data)
                CMD.Parameters.AddWithValue("@NumJornada", NumJornada)
                CMD.Parameters.AddWithValue("@Assistencia", Assistencia)
                CMD.Parameters.AddWithValue("@ResultadoCasa", ResultadoCasa)
                CMD.Parameters.AddWithValue("@ResultadoFora", ResultadoFora)
                CMD.Parameters.AddWithValue("@EquipaCasa", EquipaCasa)
                CMD.Parameters.AddWithValue("@EquipaVisitante", EquipaVisitante)
                CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
                CMD.Parameters.AddWithValue("@Estadio", Estadio)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogo Inserido Com Sucesso!")
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
        inputAssistencia.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text
        Dim Assistencia = inputAssistencia.Text

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
        End If

        If Not (IsNumeric(Assistencia)) Then
            If Not Assistencia = "" Then
                valido = False
                inputAssistencia.ForeColor = Color.Red
            Else
                Assistencia = -1
            End If
        Else
            Assistencia = Convert.ToInt32(Assistencia)
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If Assistencia = -1 Then
                CMD.CommandText = "UPDATE ProjetoBD.JOGO SET Assistência = null WHERE id_Jogo = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@id", id)
            Else
                CMD.CommandText = "UPDATE ProjetoBD.JOGO SET Assistência = @Assistencia WHERE id_Jogo = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@id", id)
                CMD.Parameters.AddWithValue("@Assistencia", Assistencia)
            End If
            Console.WriteLine(CMD.CommandText)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogo Atualizado Com Sucesso!")
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
            inputID.ForeColor = Color.Red
        Else
            CMD.CommandText = "Exec ProjetoBD.deleteJogo @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", ID)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Jogo Removido Com Sucesso!")
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
            currentJogo = ListagemListBox.SelectedIndex
            ShowPlayer()
        End If
    End Sub


    Private Sub ShowPlayer()
        If ListagemListBox.Items.Count = 0 Or currentJogo < 0 Then Exit Sub
        Dim Jogo As New JogoObject
        Jogo = CType(ListagemListBox.Items.Item(currentJogo), JogoObject)
        inputID.Text = Jogo.ID
        inputData.Text = Jogo.Data
        inputNumJornada.Text = Jogo.NumJornada
        inputAssistencia.Text = Jogo.Assistência
        inputResultadoCasa.Text = Jogo.ResultadoCasa
        inputResultadoFora.Text = Jogo.ResultadoFora
        equipaCasaBox.SelectedIndex = equipaCasaBox.FindStringExact(ID_Equipa.Item(Jogo.EquipaCasa))
        equipaForaBox.SelectedIndex = equipaForaBox.FindStringExact(ID_Equipa.Item(Jogo.EquipaVisitante))
        campeonatoBox.SelectedIndex = campeonatoBox.FindStringExact(ID_Campeonato.Item(Jogo.Campeonato))
        estadioBox.SelectedIndex = estadioBox.FindStringExact(ID_Estadio.Item(Jogo.Estadio))
    End Sub

    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim Data = input3Data.Text
        Dim NumJornada = input3NumJornada.Text
        Dim EquipaCasa = equipaCasa3Box.SelectedItem
        Dim EquipaVisitante = equipaFora3Box.SelectedItem
        Dim Campeonato = campeonato3Box.SelectedItem
        Dim Estadio = estadio3Box.SelectedItem


        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        If Not (IsDate(Data)) Then
            Data = -1
        Else
            Data = Replace(Data, "/", "-")
            Dim parts As String() = Data.Split(New Char() {"-"c})
            Data = parts(2) + "-" + parts(1) + "-" + parts(0)
        End If
        If NumJornada = "" Then
            NumJornada = -1
        End If
        If Not EquipaCasa = "" Then
            EquipaCasa = Equipa_ID.Item(EquipaCasa)
        Else
            EquipaCasa = -1
        End If
        If Not EquipaVisitante = "" Then
            EquipaVisitante = Equipa_ID.Item(EquipaVisitante)
        Else
            EquipaVisitante = -1
        End If
        If Not Campeonato = "" Then
            Campeonato = Campeonato_ID.Item(Campeonato)
        Else
            Campeonato = -1
        End If
        If Not Estadio = "" Then
            Estadio = Estadio_ID.Item(Estadio)
        Else
            Estadio = -1
        End If

        If Data = -1 Then
            CMD.CommandText = "SELECT * FROM projetoBD.getJogosFiltrados('9999-12-31',@NumJornada,@EquipaCasa,@EquipaVisitante,@Campeonato,@Estadio)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@NumJornada", NumJornada)
            CMD.Parameters.AddWithValue("@EquipaCasa", EquipaCasa)
            CMD.Parameters.AddWithValue("@EquipaVisitante", EquipaVisitante)
            CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
            CMD.Parameters.AddWithValue("@Estadio", Estadio)
        Else
            CMD.CommandText = "SELECT * FROM projetoBD.getJogosFiltrados(@data,@NumJornada,@EquipaCasa,@EquipaVisitante,@Campeonato,@Estadio)"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@data", Data)
            CMD.Parameters.AddWithValue("@NumJornada", NumJornada)
            CMD.Parameters.AddWithValue("@EquipaCasa", EquipaCasa)
            CMD.Parameters.AddWithValue("@EquipaVisitante", EquipaVisitante)
            CMD.Parameters.AddWithValue("@Campeonato", Campeonato)
            CMD.Parameters.AddWithValue("@Estadio", Estadio)
        End If
        Console.WriteLine(CMD.CommandText)
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim jogo As New JogoObject
            jogo.ID = RDR.Item("id_Jogo")
            jogo.Data = Convert.ToDateTime(IIf(RDR.IsDBNull(RDR.GetOrdinal("Data")), "", RDR.Item("Data")))
            jogo.NumJornada = RDR.Item("NumJornada")
            jogo.Assistência = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Assistência")), "", RDR.Item("Assistência")))
            jogo.ResultadoCasa = RDR.Item("ResultadoCasa")
            jogo.ResultadoFora = RDR.Item("ResultadoFora")
            jogo.EquipaCasa = RDR.Item("EquipaCasa")
            jogo.EquipaVisitante = RDR.Item("EquipaVisitante")
            jogo.Campeonato = RDR.Item("Campeonato")
            jogo.Estadio = RDR.Item("Estadio")
            jogo.EquipaCasaNome = ID_Equipa.Item(jogo.EquipaCasa)
            jogo.EquipaVisitanteNome = ID_Equipa.Item(jogo.EquipaVisitante)
            pesquisaListBox.Items.Add(jogo)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchJogo = pesquisaListBox.SelectedIndex
            ShowJogo()
        End If
    End Sub

    Private Sub ShowJogo()
        If pesquisaListBox.Items.Count = 0 Or currentSearchJogo < 0 Then Exit Sub
        Dim jogo As New JogoObject
        jogo = CType(pesquisaListBox.Items.Item(currentSearchJogo), JogoObject)
        input2ID.Text = jogo.ID
        input2Data.Text = jogo.Data
        input2NumJornada.Text = jogo.NumJornada
        input2Assistencia.Text = jogo.Assistência
        input2ResultadoCasa.Text = jogo.ResultadoCasa
        input2ResultadoFora.Text = jogo.ResultadoFora
        equipaCasa2Box.SelectedIndex = equipaCasa2Box.FindStringExact(ID_Equipa.Item(jogo.EquipaCasa))
        equipaFora2Box.SelectedIndex = equipaFora2Box.FindStringExact(ID_Equipa.Item(jogo.EquipaVisitante))
        campeonato2Box.SelectedIndex = campeonato2Box.FindStringExact(ID_Campeonato.Item(jogo.Campeonato))
        estadio2Box.SelectedIndex = estadio2Box.FindStringExact(ID_Estadio.Item(jogo.Estadio))
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class JogoObject
    Public Property ID As Object
    Public Property Data As Date
    Public Property NumJornada As Object
    Public Property Assistência As Object
    Public Property ResultadoCasa As Object
    Public Property ResultadoFora As Object
    Public Property EquipaCasa As Object
    Public Property EquipaVisitante As Object
    Public Property Campeonato As Object
    Public Property Estadio As Object
    Public Property EquipaCasaNome As Object
    Public Property EquipaVisitanteNome As Object

    Overrides Function ToString() As String
        Return EquipaCasaNome & " " & ResultadoCasa & "  Vs " & ResultadoFora & " " & EquipaVisitanteNome
    End Function
End Class