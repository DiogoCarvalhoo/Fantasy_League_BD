<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Campeonato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Campeonato))
        Me.insercaoNomeLabel = New System.Windows.Forms.Label()
        Me.insercaoPaisLabel = New System.Windows.Forms.Label()
        Me.insercaoTotalEquipLabel = New System.Windows.Forms.Label()
        Me.inputNome = New System.Windows.Forms.TextBox()
        Me.inputPais = New System.Windows.Forms.TextBox()
        Me.inputTotalEquipas = New System.Windows.Forms.TextBox()
        Me.insercaoAdicionarButton = New System.Windows.Forms.Button()
        Me.RemoverButton = New System.Windows.Forms.Button()
        Me.AtualizarButton = New System.Windows.Forms.Button()
        Me.inputID = New System.Windows.Forms.TextBox()
        Me.insercaoIDLabel = New System.Windows.Forms.Label()
        Me.ListagemListBox = New System.Windows.Forms.ListBox()
        Me.pesquisarButton = New System.Windows.Forms.Button()
        Me.input3Nome = New System.Windows.Forms.TextBox()
        Me.Nome3Label = New System.Windows.Forms.Label()
        Me.PaisBox = New System.Windows.Forms.ComboBox()
        Me.Campeonato3Label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.input2ID = New System.Windows.Forms.TextBox()
        Me.ID2Label = New System.Windows.Forms.Label()
        Me.input2TotalEquipas = New System.Windows.Forms.TextBox()
        Me.input2Pais = New System.Windows.Forms.TextBox()
        Me.input2Nome = New System.Windows.Forms.TextBox()
        Me.TotalEquipas2Label = New System.Windows.Forms.Label()
        Me.Pais2Label = New System.Windows.Forms.Label()
        Me.Nome2Label = New System.Windows.Forms.Label()
        Me.pesquisaListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EquipaFictPartLigaButton = New System.Windows.Forms.Button()
        Me.JogadorPertEquipaFictButton = New System.Windows.Forms.Button()
        Me.JogadorPlaysInJogoButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.UtilizadorButton = New System.Windows.Forms.Button()
        Me.LigaFictButton = New System.Windows.Forms.Button()
        Me.EquipaFictButton = New System.Windows.Forms.Button()
        Me.JogadorButton = New System.Windows.Forms.Button()
        Me.EstadioButton = New System.Windows.Forms.Button()
        Me.EquipaButton = New System.Windows.Forms.Button()
        Me.JogosButton = New System.Windows.Forms.Button()
        Me.CampButton = New System.Windows.Forms.Button()
        Me.MenuBackButton = New System.Windows.Forms.Button()
        Me.LimparCamposButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'insercaoNomeLabel
        '
        Me.insercaoNomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insercaoNomeLabel.Location = New System.Drawing.Point(156, 330)
        Me.insercaoNomeLabel.Name = "insercaoNomeLabel"
        Me.insercaoNomeLabel.Size = New System.Drawing.Size(49, 22)
        Me.insercaoNomeLabel.TabIndex = 30
        Me.insercaoNomeLabel.Text = "Nome:"
        '
        'insercaoPaisLabel
        '
        Me.insercaoPaisLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insercaoPaisLabel.Location = New System.Drawing.Point(156, 369)
        Me.insercaoPaisLabel.Name = "insercaoPaisLabel"
        Me.insercaoPaisLabel.Size = New System.Drawing.Size(49, 22)
        Me.insercaoPaisLabel.TabIndex = 32
        Me.insercaoPaisLabel.Text = "País:"
        '
        'insercaoTotalEquipLabel
        '
        Me.insercaoTotalEquipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insercaoTotalEquipLabel.Location = New System.Drawing.Point(156, 406)
        Me.insercaoTotalEquipLabel.Name = "insercaoTotalEquipLabel"
        Me.insercaoTotalEquipLabel.Size = New System.Drawing.Size(102, 22)
        Me.insercaoTotalEquipLabel.TabIndex = 34
        Me.insercaoTotalEquipLabel.Text = "Total Equipas:"
        '
        'inputNome
        '
        Me.inputNome.Location = New System.Drawing.Point(223, 330)
        Me.inputNome.Name = "inputNome"
        Me.inputNome.Size = New System.Drawing.Size(282, 22)
        Me.inputNome.TabIndex = 35
        '
        'inputPais
        '
        Me.inputPais.Location = New System.Drawing.Point(223, 369)
        Me.inputPais.Name = "inputPais"
        Me.inputPais.Size = New System.Drawing.Size(282, 22)
        Me.inputPais.TabIndex = 36
        '
        'inputTotalEquipas
        '
        Me.inputTotalEquipas.Location = New System.Drawing.Point(282, 406)
        Me.inputTotalEquipas.Name = "inputTotalEquipas"
        Me.inputTotalEquipas.Size = New System.Drawing.Size(223, 22)
        Me.inputTotalEquipas.TabIndex = 37
        '
        'insercaoAdicionarButton
        '
        Me.insercaoAdicionarButton.Location = New System.Drawing.Point(156, 440)
        Me.insercaoAdicionarButton.Name = "insercaoAdicionarButton"
        Me.insercaoAdicionarButton.Size = New System.Drawing.Size(82, 29)
        Me.insercaoAdicionarButton.TabIndex = 38
        Me.insercaoAdicionarButton.Text = "Adicionar"
        Me.insercaoAdicionarButton.UseVisualStyleBackColor = True
        '
        'RemoverButton
        '
        Me.RemoverButton.Location = New System.Drawing.Point(423, 440)
        Me.RemoverButton.Name = "RemoverButton"
        Me.RemoverButton.Size = New System.Drawing.Size(82, 29)
        Me.RemoverButton.TabIndex = 39
        Me.RemoverButton.Text = "Remover"
        Me.RemoverButton.UseVisualStyleBackColor = True
        '
        'AtualizarButton
        '
        Me.AtualizarButton.Location = New System.Drawing.Point(282, 440)
        Me.AtualizarButton.Name = "AtualizarButton"
        Me.AtualizarButton.Size = New System.Drawing.Size(82, 29)
        Me.AtualizarButton.TabIndex = 40
        Me.AtualizarButton.Text = "Atualizar"
        Me.AtualizarButton.UseVisualStyleBackColor = True
        '
        'inputID
        '
        Me.inputID.Location = New System.Drawing.Point(223, 285)
        Me.inputID.Name = "inputID"
        Me.inputID.ReadOnly = True
        Me.inputID.Size = New System.Drawing.Size(282, 22)
        Me.inputID.TabIndex = 42
        '
        'insercaoIDLabel
        '
        Me.insercaoIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insercaoIDLabel.Location = New System.Drawing.Point(156, 285)
        Me.insercaoIDLabel.Name = "insercaoIDLabel"
        Me.insercaoIDLabel.Size = New System.Drawing.Size(49, 22)
        Me.insercaoIDLabel.TabIndex = 41
        Me.insercaoIDLabel.Text = "ID:"
        '
        'ListagemListBox
        '
        Me.ListagemListBox.FormattingEnabled = True
        Me.ListagemListBox.ItemHeight = 16
        Me.ListagemListBox.Location = New System.Drawing.Point(156, 18)
        Me.ListagemListBox.Name = "ListagemListBox"
        Me.ListagemListBox.Size = New System.Drawing.Size(348, 244)
        Me.ListagemListBox.TabIndex = 56
        '
        'pesquisarButton
        '
        Me.pesquisarButton.Location = New System.Drawing.Point(920, 164)
        Me.pesquisarButton.Name = "pesquisarButton"
        Me.pesquisarButton.Size = New System.Drawing.Size(82, 29)
        Me.pesquisarButton.TabIndex = 119
        Me.pesquisarButton.Text = "Pesquisar"
        Me.pesquisarButton.UseVisualStyleBackColor = True
        '
        'input3Nome
        '
        Me.input3Nome.Location = New System.Drawing.Point(907, 63)
        Me.input3Nome.Name = "input3Nome"
        Me.input3Nome.Size = New System.Drawing.Size(154, 22)
        Me.input3Nome.TabIndex = 118
        '
        'Nome3Label
        '
        Me.Nome3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome3Label.Location = New System.Drawing.Point(876, 38)
        Me.Nome3Label.Name = "Nome3Label"
        Me.Nome3Label.Size = New System.Drawing.Size(51, 22)
        Me.Nome3Label.TabIndex = 117
        Me.Nome3Label.Text = "Nome:"
        '
        'PaisBox
        '
        Me.PaisBox.FormattingEnabled = True
        Me.PaisBox.Location = New System.Drawing.Point(907, 122)
        Me.PaisBox.Name = "PaisBox"
        Me.PaisBox.Size = New System.Drawing.Size(154, 24)
        Me.PaisBox.TabIndex = 116
        '
        'Campeonato3Label
        '
        Me.Campeonato3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Campeonato3Label.Location = New System.Drawing.Point(876, 97)
        Me.Campeonato3Label.Name = "Campeonato3Label"
        Me.Campeonato3Label.Size = New System.Drawing.Size(94, 22)
        Me.Campeonato3Label.TabIndex = 115
        Me.Campeonato3Label.Text = "Pais:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(873, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Filtros:"
        '
        'input2ID
        '
        Me.input2ID.Location = New System.Drawing.Point(655, 294)
        Me.input2ID.Name = "input2ID"
        Me.input2ID.ReadOnly = True
        Me.input2ID.Size = New System.Drawing.Size(215, 22)
        Me.input2ID.TabIndex = 113
        '
        'ID2Label
        '
        Me.ID2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID2Label.Location = New System.Drawing.Point(575, 294)
        Me.ID2Label.Name = "ID2Label"
        Me.ID2Label.Size = New System.Drawing.Size(61, 22)
        Me.ID2Label.TabIndex = 112
        Me.ID2Label.Text = "ID:"
        '
        'input2TotalEquipas
        '
        Me.input2TotalEquipas.Location = New System.Drawing.Point(716, 405)
        Me.input2TotalEquipas.Name = "input2TotalEquipas"
        Me.input2TotalEquipas.ReadOnly = True
        Me.input2TotalEquipas.Size = New System.Drawing.Size(154, 22)
        Me.input2TotalEquipas.TabIndex = 103
        '
        'input2Pais
        '
        Me.input2Pais.Location = New System.Drawing.Point(655, 368)
        Me.input2Pais.Name = "input2Pais"
        Me.input2Pais.ReadOnly = True
        Me.input2Pais.Size = New System.Drawing.Size(215, 22)
        Me.input2Pais.TabIndex = 102
        '
        'input2Nome
        '
        Me.input2Nome.Location = New System.Drawing.Point(655, 329)
        Me.input2Nome.Name = "input2Nome"
        Me.input2Nome.ReadOnly = True
        Me.input2Nome.Size = New System.Drawing.Size(215, 22)
        Me.input2Nome.TabIndex = 101
        '
        'TotalEquipas2Label
        '
        Me.TotalEquipas2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalEquipas2Label.Location = New System.Drawing.Point(575, 405)
        Me.TotalEquipas2Label.Name = "TotalEquipas2Label"
        Me.TotalEquipas2Label.Size = New System.Drawing.Size(118, 22)
        Me.TotalEquipas2Label.TabIndex = 100
        Me.TotalEquipas2Label.Text = "Total Equipas:"
        '
        'Pais2Label
        '
        Me.Pais2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pais2Label.Location = New System.Drawing.Point(575, 368)
        Me.Pais2Label.Name = "Pais2Label"
        Me.Pais2Label.Size = New System.Drawing.Size(61, 22)
        Me.Pais2Label.TabIndex = 99
        Me.Pais2Label.Text = "Pais:"
        '
        'Nome2Label
        '
        Me.Nome2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome2Label.Location = New System.Drawing.Point(575, 329)
        Me.Nome2Label.Name = "Nome2Label"
        Me.Nome2Label.Size = New System.Drawing.Size(61, 22)
        Me.Nome2Label.TabIndex = 98
        Me.Nome2Label.Text = "Nome:"
        '
        'pesquisaListBox
        '
        Me.pesquisaListBox.FormattingEnabled = True
        Me.pesquisaListBox.ItemHeight = 16
        Me.pesquisaListBox.Location = New System.Drawing.Point(575, 38)
        Me.pesquisaListBox.Name = "pesquisaListBox"
        Me.pesquisaListBox.Size = New System.Drawing.Size(295, 244)
        Me.pesquisaListBox.TabIndex = 97
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(556, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 554)
        Me.Button1.TabIndex = 96
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(572, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Área de Pesquisa:"
        '
        'EquipaFictPartLigaButton
        '
        Me.EquipaFictPartLigaButton.BackColor = System.Drawing.Color.LimeGreen
        Me.EquipaFictPartLigaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipaFictPartLigaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EquipaFictPartLigaButton.FlatAppearance.BorderSize = 2
        Me.EquipaFictPartLigaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EquipaFictPartLigaButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EquipaFictPartLigaButton.Image = CType(resources.GetObject("EquipaFictPartLigaButton.Image"), System.Drawing.Image)
        Me.EquipaFictPartLigaButton.Location = New System.Drawing.Point(13, 631)
        Me.EquipaFictPartLigaButton.Name = "EquipaFictPartLigaButton"
        Me.EquipaFictPartLigaButton.Size = New System.Drawing.Size(118, 46)
        Me.EquipaFictPartLigaButton.TabIndex = 323
        Me.EquipaFictPartLigaButton.Text = "EquipaFictPartLiga"
        Me.EquipaFictPartLigaButton.UseVisualStyleBackColor = False
        Me.EquipaFictPartLigaButton.Visible = False
        '
        'JogadorPertEquipaFictButton
        '
        Me.JogadorPertEquipaFictButton.BackColor = System.Drawing.Color.LimeGreen
        Me.JogadorPertEquipaFictButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JogadorPertEquipaFictButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.JogadorPertEquipaFictButton.FlatAppearance.BorderSize = 2
        Me.JogadorPertEquipaFictButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogadorPertEquipaFictButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.JogadorPertEquipaFictButton.Image = CType(resources.GetObject("JogadorPertEquipaFictButton.Image"), System.Drawing.Image)
        Me.JogadorPertEquipaFictButton.Location = New System.Drawing.Point(13, 575)
        Me.JogadorPertEquipaFictButton.Name = "JogadorPertEquipaFictButton"
        Me.JogadorPertEquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPertEquipaFictButton.TabIndex = 322
        Me.JogadorPertEquipaFictButton.Text = "JogadorPertenceEquipaFict"
        Me.JogadorPertEquipaFictButton.UseVisualStyleBackColor = False
        Me.JogadorPertEquipaFictButton.Visible = False
        '
        'JogadorPlaysInJogoButton
        '
        Me.JogadorPlaysInJogoButton.BackColor = System.Drawing.Color.LimeGreen
        Me.JogadorPlaysInJogoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JogadorPlaysInJogoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.JogadorPlaysInJogoButton.FlatAppearance.BorderSize = 2
        Me.JogadorPlaysInJogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogadorPlaysInJogoButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.JogadorPlaysInJogoButton.Image = CType(resources.GetObject("JogadorPlaysInJogoButton.Image"), System.Drawing.Image)
        Me.JogadorPlaysInJogoButton.Location = New System.Drawing.Point(11, 519)
        Me.JogadorPlaysInJogoButton.Name = "JogadorPlaysInJogoButton"
        Me.JogadorPlaysInJogoButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPlaysInJogoButton.TabIndex = 321
        Me.JogadorPlaysInJogoButton.Text = "JogadorPlaysInJogo"
        Me.JogadorPlaysInJogoButton.UseVisualStyleBackColor = False
        Me.JogadorPlaysInJogoButton.Visible = False
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.LimeGreen
        Me.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.MenuButton.FlatAppearance.BorderSize = 2
        Me.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MenuButton.Image = Global.Projeto_Final.My.Resources.Resources.homepage
        Me.MenuButton.Location = New System.Drawing.Point(1, 0)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(137, 70)
        Me.MenuButton.TabIndex = 319
        Me.MenuButton.Text = "Menu"
        Me.MenuButton.UseVisualStyleBackColor = False
        '
        'UtilizadorButton
        '
        Me.UtilizadorButton.BackColor = System.Drawing.Color.LimeGreen
        Me.UtilizadorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UtilizadorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UtilizadorButton.FlatAppearance.BorderSize = 2
        Me.UtilizadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UtilizadorButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UtilizadorButton.Image = CType(resources.GetObject("UtilizadorButton.Image"), System.Drawing.Image)
        Me.UtilizadorButton.Location = New System.Drawing.Point(11, 463)
        Me.UtilizadorButton.Name = "UtilizadorButton"
        Me.UtilizadorButton.Size = New System.Drawing.Size(118, 50)
        Me.UtilizadorButton.TabIndex = 318
        Me.UtilizadorButton.Text = "Utilizador"
        Me.UtilizadorButton.UseVisualStyleBackColor = False
        Me.UtilizadorButton.Visible = False
        '
        'LigaFictButton
        '
        Me.LigaFictButton.BackColor = System.Drawing.Color.LimeGreen
        Me.LigaFictButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LigaFictButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.LigaFictButton.FlatAppearance.BorderSize = 2
        Me.LigaFictButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LigaFictButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LigaFictButton.Image = CType(resources.GetObject("LigaFictButton.Image"), System.Drawing.Image)
        Me.LigaFictButton.Location = New System.Drawing.Point(11, 407)
        Me.LigaFictButton.Name = "LigaFictButton"
        Me.LigaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.LigaFictButton.TabIndex = 317
        Me.LigaFictButton.Text = "Liga Fictícia"
        Me.LigaFictButton.UseVisualStyleBackColor = False
        Me.LigaFictButton.Visible = False
        '
        'EquipaFictButton
        '
        Me.EquipaFictButton.BackColor = System.Drawing.Color.LimeGreen
        Me.EquipaFictButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipaFictButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EquipaFictButton.FlatAppearance.BorderSize = 2
        Me.EquipaFictButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EquipaFictButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EquipaFictButton.Image = CType(resources.GetObject("EquipaFictButton.Image"), System.Drawing.Image)
        Me.EquipaFictButton.Location = New System.Drawing.Point(13, 351)
        Me.EquipaFictButton.Name = "EquipaFictButton"
        Me.EquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaFictButton.TabIndex = 316
        Me.EquipaFictButton.Text = "Equipa Fictícia"
        Me.EquipaFictButton.UseVisualStyleBackColor = False
        Me.EquipaFictButton.Visible = False
        '
        'JogadorButton
        '
        Me.JogadorButton.BackColor = System.Drawing.Color.LimeGreen
        Me.JogadorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JogadorButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.JogadorButton.FlatAppearance.BorderSize = 2
        Me.JogadorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogadorButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.JogadorButton.Image = CType(resources.GetObject("JogadorButton.Image"), System.Drawing.Image)
        Me.JogadorButton.Location = New System.Drawing.Point(13, 295)
        Me.JogadorButton.Name = "JogadorButton"
        Me.JogadorButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorButton.TabIndex = 315
        Me.JogadorButton.Text = "Jogador"
        Me.JogadorButton.UseVisualStyleBackColor = False
        Me.JogadorButton.Visible = False
        '
        'EstadioButton
        '
        Me.EstadioButton.BackColor = System.Drawing.Color.LimeGreen
        Me.EstadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EstadioButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EstadioButton.FlatAppearance.BorderSize = 2
        Me.EstadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EstadioButton.Image = CType(resources.GetObject("EstadioButton.Image"), System.Drawing.Image)
        Me.EstadioButton.Location = New System.Drawing.Point(13, 183)
        Me.EstadioButton.Name = "EstadioButton"
        Me.EstadioButton.Size = New System.Drawing.Size(118, 50)
        Me.EstadioButton.TabIndex = 314
        Me.EstadioButton.Text = "Estádio"
        Me.EstadioButton.UseVisualStyleBackColor = False
        Me.EstadioButton.Visible = False
        '
        'EquipaButton
        '
        Me.EquipaButton.BackColor = System.Drawing.Color.LimeGreen
        Me.EquipaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EquipaButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EquipaButton.FlatAppearance.BorderSize = 2
        Me.EquipaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EquipaButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EquipaButton.Image = CType(resources.GetObject("EquipaButton.Image"), System.Drawing.Image)
        Me.EquipaButton.Location = New System.Drawing.Point(13, 127)
        Me.EquipaButton.Name = "EquipaButton"
        Me.EquipaButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaButton.TabIndex = 313
        Me.EquipaButton.Text = "Equipa"
        Me.EquipaButton.UseVisualStyleBackColor = False
        Me.EquipaButton.Visible = False
        '
        'JogosButton
        '
        Me.JogosButton.BackColor = System.Drawing.Color.LimeGreen
        Me.JogosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JogosButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.JogosButton.FlatAppearance.BorderSize = 2
        Me.JogosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.JogosButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.JogosButton.Image = CType(resources.GetObject("JogosButton.Image"), System.Drawing.Image)
        Me.JogosButton.Location = New System.Drawing.Point(11, 239)
        Me.JogosButton.Name = "JogosButton"
        Me.JogosButton.Size = New System.Drawing.Size(118, 50)
        Me.JogosButton.TabIndex = 312
        Me.JogosButton.Text = "Jogos"
        Me.JogosButton.UseVisualStyleBackColor = False
        Me.JogosButton.Visible = False
        '
        'CampButton
        '
        Me.CampButton.BackColor = System.Drawing.Color.LimeGreen
        Me.CampButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CampButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CampButton.FlatAppearance.BorderSize = 2
        Me.CampButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CampButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CampButton.Image = CType(resources.GetObject("CampButton.Image"), System.Drawing.Image)
        Me.CampButton.Location = New System.Drawing.Point(11, 71)
        Me.CampButton.Name = "CampButton"
        Me.CampButton.Size = New System.Drawing.Size(118, 50)
        Me.CampButton.TabIndex = 311
        Me.CampButton.Text = "Campeonato"
        Me.CampButton.UseVisualStyleBackColor = False
        Me.CampButton.Visible = False
        '
        'MenuBackButton
        '
        Me.MenuBackButton.BackColor = System.Drawing.Color.Black
        Me.MenuBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuBackButton.Image = Global.Projeto_Final.My.Resources.Resources.homepage
        Me.MenuBackButton.Location = New System.Drawing.Point(1, 0)
        Me.MenuBackButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuBackButton.Name = "MenuBackButton"
        Me.MenuBackButton.Size = New System.Drawing.Size(137, 708)
        Me.MenuBackButton.TabIndex = 320
        Me.MenuBackButton.UseVisualStyleBackColor = False
        Me.MenuBackButton.Visible = False
        '
        'LimparCamposButton
        '
        Me.LimparCamposButton.Location = New System.Drawing.Point(261, 493)
        Me.LimparCamposButton.Name = "LimparCamposButton"
        Me.LimparCamposButton.Size = New System.Drawing.Size(127, 38)
        Me.LimparCamposButton.TabIndex = 324
        Me.LimparCamposButton.Text = "Limpar Campos"
        Me.LimparCamposButton.UseVisualStyleBackColor = True
        '
        'Campeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 673)
        Me.Controls.Add(Me.LimparCamposButton)
        Me.Controls.Add(Me.EquipaFictPartLigaButton)
        Me.Controls.Add(Me.JogadorPertEquipaFictButton)
        Me.Controls.Add(Me.JogadorPlaysInJogoButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.UtilizadorButton)
        Me.Controls.Add(Me.LigaFictButton)
        Me.Controls.Add(Me.EquipaFictButton)
        Me.Controls.Add(Me.JogadorButton)
        Me.Controls.Add(Me.EstadioButton)
        Me.Controls.Add(Me.EquipaButton)
        Me.Controls.Add(Me.JogosButton)
        Me.Controls.Add(Me.CampButton)
        Me.Controls.Add(Me.pesquisarButton)
        Me.Controls.Add(Me.input3Nome)
        Me.Controls.Add(Me.Nome3Label)
        Me.Controls.Add(Me.PaisBox)
        Me.Controls.Add(Me.Campeonato3Label)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.input2ID)
        Me.Controls.Add(Me.ID2Label)
        Me.Controls.Add(Me.input2TotalEquipas)
        Me.Controls.Add(Me.input2Pais)
        Me.Controls.Add(Me.input2Nome)
        Me.Controls.Add(Me.TotalEquipas2Label)
        Me.Controls.Add(Me.Pais2Label)
        Me.Controls.Add(Me.Nome2Label)
        Me.Controls.Add(Me.pesquisaListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListagemListBox)
        Me.Controls.Add(Me.inputID)
        Me.Controls.Add(Me.insercaoIDLabel)
        Me.Controls.Add(Me.AtualizarButton)
        Me.Controls.Add(Me.RemoverButton)
        Me.Controls.Add(Me.insercaoAdicionarButton)
        Me.Controls.Add(Me.inputTotalEquipas)
        Me.Controls.Add(Me.inputPais)
        Me.Controls.Add(Me.inputNome)
        Me.Controls.Add(Me.insercaoTotalEquipLabel)
        Me.Controls.Add(Me.insercaoPaisLabel)
        Me.Controls.Add(Me.insercaoNomeLabel)
        Me.Controls.Add(Me.MenuBackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Campeonato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campeonato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents insercaoNomeLabel As Label
    Friend WithEvents insercaoPaisLabel As Label
    Friend WithEvents insercaoTotalEquipLabel As Label
    Friend WithEvents inputNome As TextBox
    Friend WithEvents inputPais As TextBox
    Friend WithEvents inputTotalEquipas As TextBox
    Friend WithEvents insercaoAdicionarButton As Button
    Friend WithEvents RemoverButton As Button
    Friend WithEvents AtualizarButton As Button
    Friend WithEvents inputID As TextBox
    Friend WithEvents insercaoIDLabel As Label
    Friend WithEvents ListagemListBox As ListBox
    Friend WithEvents pesquisarButton As Button
    Friend WithEvents input3Nome As TextBox
    Friend WithEvents Nome3Label As Label
    Friend WithEvents PaisBox As ComboBox
    Friend WithEvents Campeonato3Label As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents input2ID As TextBox
    Friend WithEvents ID2Label As Label
    Friend WithEvents input2TotalEquipas As TextBox
    Friend WithEvents input2Pais As TextBox
    Friend WithEvents input2Nome As TextBox
    Friend WithEvents TotalEquipas2Label As Label
    Friend WithEvents Pais2Label As Label
    Friend WithEvents Nome2Label As Label
    Friend WithEvents pesquisaListBox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EquipaFictPartLigaButton As Button
    Friend WithEvents JogadorPertEquipaFictButton As Button
    Friend WithEvents JogadorPlaysInJogoButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents UtilizadorButton As Button
    Friend WithEvents LigaFictButton As Button
    Friend WithEvents EquipaFictButton As Button
    Friend WithEvents JogadorButton As Button
    Friend WithEvents EstadioButton As Button
    Friend WithEvents EquipaButton As Button
    Friend WithEvents JogosButton As Button
    Friend WithEvents CampButton As Button
    Friend WithEvents MenuBackButton As Button
    Friend WithEvents LimparCamposButton As Button
End Class
