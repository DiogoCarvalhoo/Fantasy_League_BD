Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Campeonato


    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentChampionship As Integer
    Dim currentSearchChampionship As Integer

    Private Sub Campeonato_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.CAMPEONATO"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        PaisBox.Items.Clear()
        PaisBox.Items.Add("")
        While RDR.Read
            Dim Camp As New CampeonatoObject
            Camp.id = RDR.Item("id_Campeonato")
            Camp.nome = RDR.Item("Nome")
            Camp.totalEquipas = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("TotalEquipas")), "", RDR.Item("TotalEquipas")))
            Camp.pais = RDR.Item("país")
            ListagemListBox.Items.Add(Camp)
            PaisBox.Items.Add(Camp.pais)
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

    Private Sub Jogo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Close()
    End Sub

    Private Sub JogadorPlaysInJogoButton_Click(sender As Object, e As EventArgs) Handles JogadorPlaysInJogoButton.Click
        Me.Hide()
        JogadorPlaysInJogo.Show()
        JogadorPlaysInJogo.loadTuplos()
    End Sub

    Private Sub EquipaButton_Click(sender As Object, e As EventArgs) Handles EquipaButton.Click
        Me.Hide()
        Equipa.Show()
        Equipa.loadTuplos()
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

    Private Sub Clear()
        inputID.Text = ""
        inputNome.Text = ""
        inputPais.Text = ""
        inputTotalEquipas.Text = ""
        input2ID.Text = ""
        input2Nome.Text = ""
        input2Pais.Text = ""
        input2TotalEquipas.Text = ""
        input3Nome.Text = ""
        PaisBox.SelectedIndex = PaisBox.FindStringExact("")

    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles insercaoAdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputPais.ForeColor = Color.Black
        inputTotalEquipas.ForeColor = Color.Black
        Dim valido = True
        Dim nome = inputNome.Text
        Dim país = inputPais.Text
        Dim totalEquipas = inputTotalEquipas.Text


        If nome = "" Or nome.Length > 30 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If

        If país = "" Or país.Length > 15 Then
            valido = False
            inputPais.ForeColor = Color.Red
        Else
            país = Replace(país, "'", "''")
        End If

        If Not (IsNumeric(totalEquipas)) Then
            If totalEquipas = "" Then
                totalEquipas = 0
            Else
                valido = False
                inputTotalEquipas.ForeColor = Color.Red
            End If
        Else
            totalEquipas = Convert.ToInt32(totalEquipas)
            If totalEquipas < 0 Then
                valido = False
                inputTotalEquipas.ForeColor = Color.Red
            End If
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If totalEquipas = 0 Then
                CMD.CommandText = "INSERT INTO ProjetoBD.CAMPEONATO (Nome,País) VALUES (@nome,@país);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@país", país)
            Else
                CMD.CommandText = "INSERT INTO ProjetoBD.CAMPEONATO (Nome,País,TotalEquipas) VALUES (@nome,@país,@totalEquipas);"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@país", país)
                CMD.Parameters.AddWithValue("@totalEquipas", totalEquipas)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Campeonato Inserido Com Sucesso!")
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
        inputPais.ForeColor = Color.Black
        inputTotalEquipas.ForeColor = Color.Black
        Dim valido = True
        Dim ID = inputID.Text
        Dim nome = inputNome.Text
        Dim país = inputPais.Text
        Dim totalEquipas = inputTotalEquipas.Text

        If ID = "" Or Not (IsNumeric(ID)) Then
            valido = False
            inputID.ForeColor = Color.Red
        End If
        If nome = "" Or nome.Length > 30 Then
            valido = False
            inputNome.ForeColor = Color.Red
        Else
            nome = Replace(nome, "'", "''")
        End If
        If país = "" Or país.Length > 15 Then
            valido = False
            inputPais.ForeColor = Color.Red
        Else
            país = Replace(país, "'", "''")
        End If

        If Not (IsNumeric(totalEquipas)) Then
            If totalEquipas = "" Then
                totalEquipas = 0
            Else
                valido = False
                inputTotalEquipas.ForeColor = Color.Red
            End If
        Else
            totalEquipas = Convert.ToInt32(totalEquipas)
            If totalEquipas < 0 Then
                valido = False
                inputTotalEquipas.ForeColor = Color.Red
            End If
        End If

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            If totalEquipas = 0 Then
                CMD.CommandText = "UPDATE ProjetoBD.CAMPEONATO SET Nome=@nome, país=@país WHERE id_Campeonato = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@país", país)
                CMD.Parameters.AddWithValue("@id", ID)
            Else
                CMD.CommandText = "UPDATE ProjetoBD.CAMPEONATO SET Nome= @nome, país =@país, TotalEquipas=@totalEquipas WHERE id_Campeonato = @id;"
                CMD.Parameters.Clear()
                CMD.Parameters.AddWithValue("@nome", nome)
                CMD.Parameters.AddWithValue("@país", país)
                CMD.Parameters.AddWithValue("@totalEquipas", totalEquipas)
                CMD.Parameters.AddWithValue("@id", ID)
            End If
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Campeonato Atualizado Com Sucesso!")
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
            CMD.CommandText = "Exec ProjetoBD.deleteCampeonato @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", ID)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Campeonato Removido Com Sucesso!")
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
            currentChampionship = ListagemListBox.SelectedIndex
            ShowTeam()
        End If
    End Sub

    Private Sub ShowTeam()
        If ListagemListBox.Items.Count = 0 Or currentChampionship < 0 Then Exit Sub
        Dim camp As New CampeonatoObject
        camp = CType(ListagemListBox.Items.Item(currentChampionship), CampeonatoObject)
        inputID.Text = camp.id
        inputNome.Text = camp.nome
        inputPais.Text = camp.pais
        inputTotalEquipas.Text = camp.totalEquipas
    End Sub




    Private Sub pesquisarButton_Click(sender As Object, e As EventArgs) Handles pesquisarButton.Click
        Dim nome = input3Nome.Text
        Dim pais = PaisBox.SelectedItem

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM projetoBD.getCampeonatosFiltrados(@nome,@pais)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@nome", nome)
        CMD.Parameters.AddWithValue("@pais", pais)
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim Camp As New CampeonatoObject
            Camp.id = RDR.Item("id_Campeonato")
            Camp.nome = RDR.Item("Nome")
            Camp.pais = RDR.Item("País")
            Camp.totalEquipas = RDR.Item("TotalEquipas")
            pesquisaListBox.Items.Add(Camp)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchChampionship = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchChampionship < 0 Then Exit Sub
        Dim camp As New CampeonatoObject
        camp = CType(pesquisaListBox.Items.Item(currentSearchChampionship), CampeonatoObject)
        input2ID.Text = camp.id
        input2Nome.Text = camp.nome
        input2TotalEquipas.Text = camp.totalEquipas
        input2Pais.Text = camp.pais
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class CampeonatoObject
    Public Property id As Object
    Public Property pais As Object
    Public Property nome As Object
    Public Property totalEquipas As String
    Overrides Function ToString() As String
        Return nome
    End Function
End Class