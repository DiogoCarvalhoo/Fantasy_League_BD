Imports System.Configuration
Imports System.Data.SqlClient
Public Class EquipaFictPartLiga
    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentEquipaFictPartLiga As Integer
    Dim currentSearchEquipaFict As Integer
    Dim ID_Liga As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Liga_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ID_EquipaFict As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim EquipaFict_ID As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Email_Nick As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Nick_Email As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub EquipaFictPartLiga_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Liga"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        LigaNomeBox.Items.Clear()
        Liga3box.Items.Clear()
        ID_Liga.Clear()
        Liga_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Liga")
            Dim Nome = RDR.Item("Nome")
            ID_Liga.Add(ID, Nome)
            Liga_ID.Add(Nome, ID)
            LigaNomeBox.Items.Add(Nome)
            Liga3box.Items.Add(Nome)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.ID_Nome_Equipa_Fict"
        CN.Open()
        RDR = CMD.ExecuteReader
        equipaFictNomeBox.Items.Clear()
        ID_EquipaFict.Clear()
        EquipaFict_ID.Clear()
        While RDR.Read
            Dim ID = RDR.Item("id_Equipa_Ficticia")
            Dim Equipa = RDR.Item("Nome")
            equipaFictNomeBox.Items.Add(Equipa)
            ID_EquipaFict.Add(ID, Equipa)
            EquipaFict_ID.Add(Equipa, ID)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.EquipaFictPartLiga"
        CN.Open()
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim EquipaFictPartLiga As New EquipaFictPartLigaObject
            EquipaFictPartLiga.Equipa_Fict_ID = RDR.Item("Equipa_Ficticia_ID")
            EquipaFictPartLiga.Liga_ID = RDR.Item("Liga_ID")
            EquipaFictPartLiga.Liga_Nome = ID_Liga.Item(EquipaFictPartLiga.Liga_ID)
            EquipaFictPartLiga.Equipa_Fict_Nome = ID_EquipaFict.Item(EquipaFictPartLiga.Equipa_Fict_ID)
            ListagemListBox.Items.Add(EquipaFictPartLiga)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.Emails_Nick_Utilizador"
        CN.Open()
        RDR = CMD.ExecuteReader
        Email_Nick.Clear()
        Nick_Email.Clear()
        While RDR.Read
            Dim email = RDR.Item("Email")
            Dim nick = RDR.Item("Nick")
            Email_Nick.Add(email, nick)
            Nick_Email.Add(nick, email)
            Nick2Box.Items.Add(nick)
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
        inputEquipaFictID.Text = ""
        inputLigaID.Text = ""
        input2ID.Text = ""
        input2Nome.Text = ""
        input2TotalPontos.Text = ""
        Liga3box.SelectedIndex = Liga3box.FindStringExact("")
        LigaNomeBox.SelectedIndex = LigaNomeBox.FindStringExact("")
        equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact("")
        Nick2Box.SelectedIndex = Nick2Box.FindStringExact("")
    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputEquipaFictID.ForeColor = Color.Black
        inputLigaID.ForeColor = Color.Black

        Dim valido = True
        Dim id_EquipaFict_id = EquipaFict_ID.Item(equipaFictNomeBox.SelectedItem)
        Dim id_Liga_id = Liga_ID.Item(LigaNomeBox.SelectedItem)


        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD = New SqlCommand
            CMD.Connection = CN
            CMD.CommandText = "INSERT INTO ProjetoBD.EquipaFictPartLiga (Equipa_Ficticia_ID, Liga_ID) VALUES (@equipa_id,@liga_id);"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@equipa_id", id_EquipaFict_id)
            CMD.Parameters.AddWithValue("@liga_id", id_Liga_id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("EquipaFictPartLiga Inserido Com Sucesso!")
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
        inputLigaID.ForeColor = Color.Black

        Dim valido = True
        Dim id_EquipaFict_id = equipaFictNomeBox.SelectedItem
        Dim id_Liga_id = LigaNomeBox.SelectedItem

        Try
            id_EquipaFict_id = EquipaFict_ID.Item(id_EquipaFict_id)
            id_Liga_id = Liga_ID.Item(id_Liga_id)
        Catch ex As Exception
            MsgBox("Selecione uma Equipa Válida e uma Liga Válida!")
            Return
        End Try

        If valido = False Then
            MsgBox("Campos Inválidos")
        Else
            CMD.CommandText = "DELETE ProjetoBD.EquipaFictPartLiga WHERE Equipa_Ficticia_ID=@id1 and Liga_ID=@id2 "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id1", id_EquipaFict_id)
            CMD.Parameters.AddWithValue("@id2", id_Liga_id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("EquipaFictPartLiga Removido Com Sucesso!")
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

    Private Sub JogadorPertEquipaFictButton_Click(sender As Object, e As EventArgs) Handles JogadorPertEquipaFictButton.Click
        Me.Hide()
        JogadorPertEquipaFict.Show()
        JogadorPertEquipaFict.loadTuplos()
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
            currentEquipaFictPartLiga = ListagemListBox.SelectedIndex
            ShowEquipaFictPartLiga()
        End If
    End Sub

    Private Sub ShowEquipaFictPartLiga()
        If ListagemListBox.Items.Count = 0 Or currentEquipaFictPartLiga < 0 Then Exit Sub
        Dim EquipaFictPartLiga As New EquipaFictPartLigaObject
        EquipaFictPartLiga = CType(ListagemListBox.Items.Item(currentEquipaFictPartLiga), EquipaFictPartLigaObject)
        inputLigaID.Text = EquipaFictPartLiga.Liga_ID
        inputEquipaFictID.Text = EquipaFictPartLiga.Equipa_Fict_ID
        LigaNomeBox.SelectedIndex = LigaNomeBox.FindStringExact(ID_Liga.Item(EquipaFictPartLiga.Liga_ID))
        equipaFictNomeBox.SelectedIndex = equipaFictNomeBox.FindStringExact(ID_EquipaFict.Item(EquipaFictPartLiga.Equipa_Fict_ID))
    End Sub

    Private Sub inputJogadorID_TextChanged(sender As Object, e As EventArgs) Handles inputLigaID.TextChanged
        Try
            LigaNomeBox.SelectedIndex = LigaNomeBox.FindStringExact(ID_Liga.Item(inputLigaID.Text))
        Catch ex As Exception
            LigaNomeBox.SelectedIndex = LigaNomeBox.FindStringExact("")
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
        Dim id = Liga3box.SelectedItem
        If Not id = "" Then
            id = Liga_ID.Item(id)
        Else
            MsgBox("Deve Selecionar Uma Liga")
            Return
        End If

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN


        CMD.CommandText = "SELECT * FROM projetoBD.getEquipaFictPartLigaFiltradas(@id)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@id", id)
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        pesquisaListBox.Items.Clear()
        While RDR.Read
            Dim Equipa As New EquipaFicticiaObject
            Equipa.ID = RDR.Item("id_Equipa_Ficticia")
            Equipa.Nome = RDR.Item("Nome")
            Equipa.TotalPontos = RDR.Item("TotalPontos")
            Equipa.emailcriador = RDR.Item("utilizador")
            pesquisaListBox.Items.Add(Equipa)
        End While
        CN.Close()
        Clear()
    End Sub

    Private Sub pesquisaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pesquisaListBox.SelectedIndexChanged
        If pesquisaListBox.SelectedIndex > -1 Then
            currentSearchEquipaFict = pesquisaListBox.SelectedIndex
            ShowEquipaFict()
        End If
    End Sub

    Private Sub ShowEquipaFict()
        If pesquisaListBox.Items.Count = 0 Or currentSearchEquipaFict < 0 Then Exit Sub
        Dim EquipaFict As New EquipaFicticiaObject
        EquipaFict = CType(pesquisaListBox.Items.Item(currentSearchEquipaFict), EquipaFicticiaObject)
        input2ID.Text = EquipaFict.ID
        input2Nome.Text = EquipaFict.Nome
        input2TotalPontos.Text = EquipaFict.TotalPontos
        Nick2Box.SelectedIndex = Nick2Box.FindStringExact(Email_Nick.Item(EquipaFict.emailcriador))
    End Sub

    Private Sub JogadorPlaysInJogoButton_Click(sender As Object, e As EventArgs) Handles JogadorPlaysInJogoButton.Click
        Me.Hide()
        JogadorPlaysInJogo.Show()
        JogadorPlaysInJogo.loadTuplos()
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class EquipaFictPartLigaObject
    Public Property Liga_ID As Object
    Public Property Equipa_Fict_ID As Object
    Public Property Liga_Nome As Object
    Public Property Equipa_Fict_Nome As Object

    Overrides Function ToString() As String
        Return Equipa_Fict_Nome & " -> " & Liga_Nome
    End Function
End Class