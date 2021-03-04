Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient
Imports System.Configuration

Public Class EquipaFicticia

    Dim CN As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString)
    Dim CMD As SqlCommand
    Dim currentTeam As Integer
    Dim currentSearchTeam As Integer
    Dim Email_Nick As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Nick_Email As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub EquipaFicticia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTuplos()
        CN.Close()
    End Sub

    Sub loadTuplos()
        'CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.EQUIPAFICTICIA"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListagemListBox.Items.Clear()
        While RDR.Read
            Dim Equipa As New EquipaFicticiaObject
            Equipa.ID = RDR.Item("id_Equipa_Ficticia")
            Equipa.Nome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Nome")), "", RDR.Item("Nome")))
            Equipa.TotalPontos = RDR.Item("TotalPontos")
            Equipa.emailcriador = RDR.Item("utilizador")
            ListagemListBox.Items.Add(Equipa)
        End While
        CN.Close()
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT * FROM ProjetoBD.Emails_Nick_Utilizador"
        CN.Open()
        RDR = CMD.ExecuteReader
        NickBox.Items.Clear()
        Nick2Box.Items.Clear()
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
            Nick2Box.Items.Add(nick)
            Nick3Box.Items.Add(nick)
        End While
        Nick3Box.SelectedIndex = Nick3Box.FindStringExact("")
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

    Private Sub Clear()
        inputID.Text = ""
        input2ID.Text = ""
        input2Nome.Text = ""
        input2TotalPontos.Text = ""
        inputNome.Text = ""
        inputTotalPontos.Text = ""
        Nick2Box.SelectedIndex = Nick2Box.FindStringExact("")
        NickBox.SelectedIndex = NickBox.FindStringExact("")
        Nick3Box.SelectedIndex = Nick3Box.FindStringExact("")
    End Sub

    Private Sub insercaoAdicionarButton_Click(sender As Object, e As EventArgs) Handles AdicionarButton.Click
        inputID.ForeColor = Color.Black
        inputNome.ForeColor = Color.Black
        inputTotalPontos.ForeColor = Color.Black

        Dim valido = True
        Dim nome = inputNome.Text
        Dim emailcriador = Nick_Email.Item(NickBox.SelectedItem)


        If nome = "" Or nome.Length > 40 Then
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
            CMD.CommandText = "INSERT INTO ProjetoBD.EQUIPAFICTICIA (Nome,utilizador) VALUES (@nome,@emailcriador);"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
            CMD.Parameters.AddWithValue("@emailcriador", emailcriador)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Equipa Fictícia Inserida Com Sucesso!")
            Catch ex As Exception
                MsgBox("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()

            pesquisaListBox.Items.Clear()
            loadTuplos()
            Clear()
        End If
    End Sub

    Private Sub AtualizarButton_Click(sender As Object, e As EventArgs) Handles AtualizarButton.Click
        inputNome.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text
        Dim nome = inputNome.Text

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
        End If

        If nome = "" Or nome.Length > 40 Then
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
            Console.WriteLine(Campeonato)
            CMD.CommandText = "UPDATE ProjetoBD.EQUIPAFICTICIA SET Nome = @nome WHERE id_Equipa_Ficticia = @id;"
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@nome", nome)
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
            loadTuplos()
            Clear()
        End If
    End Sub

    Private Sub RemoverButton_Click(sender As Object, e As EventArgs) Handles RemoverButton.Click
        inputNome.ForeColor = Color.Black
        Dim valido = True
        Dim id = inputID.Text

        If Not (IsNumeric(id)) Then
            valido = False
            inputID.ForeColor = Color.Red
        Else
            id = Convert.ToInt32(id)
            CMD.CommandText = "Exec ProjetoBD.deleteEquipaFicticia @id "
            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@id", id)
            CN.Open()
            Try
                CMD.ExecuteNonQuery()
                MsgBox("Equipa Fictícia Removida Com Sucesso!")
            Catch ex As Exception
                MsgBox("Failed to delete contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
            Finally
                CN.Close()
            End Try
            CN.Close()

            pesquisaListBox.Items.Clear()
            loadTuplos()
            Clear()
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
        Dim equipa As New EquipaFicticiaObject
        equipa = CType(ListagemListBox.Items.Item(currentTeam), EquipaFicticiaObject)
        inputID.Text = equipa.ID
        inputNome.Text = equipa.Nome
        inputTotalPontos.Text = equipa.TotalPontos
        NickBox.SelectedIndex = NickBox.FindStringExact(Email_Nick.Item(equipa.emailcriador))
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
        Dim nick = Nick3Box.SelectedItem

        CN = New SqlConnection("Data Source = tcp:mednat.ieeta.pt\SQLSERVER,8101 ; Initial Catalog = p4g3; uid = p4g3; password = Geforce960m")
        CMD = New SqlCommand
        CMD.Connection = CN
        If Not nick = "" Then
            nick = Nick_Email.Item(nick)
        End If
        CMD.CommandText = "SELECT * FROM projetoBD.getEquipasFicticiasFiltradas(@nome,@nick)"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@nome", nome)
        CMD.Parameters.AddWithValue("@nick", nick)

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
            currentSearchTeam = pesquisaListBox.SelectedIndex
            ShowTeam2()
        End If
    End Sub

    Private Sub ShowTeam2()
        If pesquisaListBox.Items.Count = 0 Or currentSearchTeam < 0 Then Exit Sub
        Dim equipa As New EquipaFicticiaObject
        equipa = CType(pesquisaListBox.Items.Item(currentSearchTeam), EquipaFicticiaObject)
        input2ID.Text = equipa.ID
        input2Nome.Text = equipa.Nome
        input2TotalPontos.Text = equipa.TotalPontos
        Nick2Box.SelectedIndex = Nick2Box.FindStringExact(Email_Nick.Item(equipa.emailcriador))
    End Sub

    Private Sub LimparCamposButton_Click(sender As Object, e As EventArgs) Handles LimparCamposButton.Click
        Clear()
    End Sub
End Class

Public Class EquipaFicticiaObject
    Public Property ID As Object
    Public Property Nome As String
    Public Property TotalPontos As String
    Public Property emailcriador As String

    Overrides Function ToString() As String
        Return Nome
    End Function
End Class