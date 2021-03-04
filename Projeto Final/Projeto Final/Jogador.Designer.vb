<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jogador))
        Me.equipaBox = New System.Windows.Forms.ComboBox()
        Me.EquipaLabel = New System.Windows.Forms.Label()
        Me.inputNacionalidade = New System.Windows.Forms.TextBox()
        Me.PosicaoLabel = New System.Windows.Forms.Label()
        Me.NacionalidadeLabel = New System.Windows.Forms.Label()
        Me.AtualizarButton = New System.Windows.Forms.Button()
        Me.RemoverButton = New System.Windows.Forms.Button()
        Me.AdicionarButton = New System.Windows.Forms.Button()
        Me.inputDataNasc = New System.Windows.Forms.TextBox()
        Me.inputNome = New System.Windows.Forms.TextBox()
        Me.inputID = New System.Windows.Forms.TextBox()
        Me.DataNascLabel = New System.Windows.Forms.Label()
        Me.NomeLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.ListagemListBox = New System.Windows.Forms.ListBox()
        Me.PosicaoBox = New System.Windows.Forms.ComboBox()
        Me.pesquisarButton = New System.Windows.Forms.Button()
        Me.input3Nome = New System.Windows.Forms.TextBox()
        Me.Nome3Label = New System.Windows.Forms.Label()
        Me.equipa3Box = New System.Windows.Forms.ComboBox()
        Me.Equipa3Label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.input2ID = New System.Windows.Forms.TextBox()
        Me.ID2Label = New System.Windows.Forms.Label()
        Me.Equipa2Label = New System.Windows.Forms.Label()
        Me.Posicao2Label = New System.Windows.Forms.Label()
        Me.input2Nacionalidade = New System.Windows.Forms.TextBox()
        Me.input2DataNasc = New System.Windows.Forms.TextBox()
        Me.input2Nome = New System.Windows.Forms.TextBox()
        Me.Nacionalidade2Label = New System.Windows.Forms.Label()
        Me.DataNasc2Label = New System.Windows.Forms.Label()
        Me.Nome2Label = New System.Windows.Forms.Label()
        Me.pesquisaListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input3Nacionalidade = New System.Windows.Forms.TextBox()
        Me.Nacionalidade3Label = New System.Windows.Forms.Label()
        Me.posicao3box = New System.Windows.Forms.ComboBox()
        Me.posicao3Label = New System.Windows.Forms.Label()
        Me.posicao2box = New System.Windows.Forms.ComboBox()
        Me.equipa2box = New System.Windows.Forms.ComboBox()
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
        'equipaBox
        '
        Me.equipaBox.FormattingEnabled = True
        Me.equipaBox.Location = New System.Drawing.Point(310, 441)
        Me.equipaBox.Name = "equipaBox"
        Me.equipaBox.Size = New System.Drawing.Size(186, 24)
        Me.equipaBox.TabIndex = 82
        '
        'EquipaLabel
        '
        Me.EquipaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EquipaLabel.Location = New System.Drawing.Point(147, 441)
        Me.EquipaLabel.Name = "EquipaLabel"
        Me.EquipaLabel.Size = New System.Drawing.Size(125, 22)
        Me.EquipaLabel.TabIndex = 79
        Me.EquipaLabel.Text = "Equipa:"
        '
        'inputNacionalidade
        '
        Me.inputNacionalidade.Location = New System.Drawing.Point(310, 375)
        Me.inputNacionalidade.Name = "inputNacionalidade"
        Me.inputNacionalidade.Size = New System.Drawing.Size(186, 22)
        Me.inputNacionalidade.TabIndex = 77
        '
        'PosicaoLabel
        '
        Me.PosicaoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PosicaoLabel.Location = New System.Drawing.Point(147, 409)
        Me.PosicaoLabel.Name = "PosicaoLabel"
        Me.PosicaoLabel.Size = New System.Drawing.Size(125, 22)
        Me.PosicaoLabel.TabIndex = 76
        Me.PosicaoLabel.Text = "Posicao:"
        '
        'NacionalidadeLabel
        '
        Me.NacionalidadeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NacionalidadeLabel.Location = New System.Drawing.Point(147, 375)
        Me.NacionalidadeLabel.Name = "NacionalidadeLabel"
        Me.NacionalidadeLabel.Size = New System.Drawing.Size(125, 22)
        Me.NacionalidadeLabel.TabIndex = 75
        Me.NacionalidadeLabel.Text = "País:"
        '
        'AtualizarButton
        '
        Me.AtualizarButton.Location = New System.Drawing.Point(414, 481)
        Me.AtualizarButton.Name = "AtualizarButton"
        Me.AtualizarButton.Size = New System.Drawing.Size(82, 29)
        Me.AtualizarButton.TabIndex = 73
        Me.AtualizarButton.Text = "Atualizar"
        Me.AtualizarButton.UseVisualStyleBackColor = True
        '
        'RemoverButton
        '
        Me.RemoverButton.Location = New System.Drawing.Point(274, 481)
        Me.RemoverButton.Name = "RemoverButton"
        Me.RemoverButton.Size = New System.Drawing.Size(82, 29)
        Me.RemoverButton.TabIndex = 72
        Me.RemoverButton.Text = "Remover"
        Me.RemoverButton.UseVisualStyleBackColor = True
        '
        'AdicionarButton
        '
        Me.AdicionarButton.Location = New System.Drawing.Point(147, 481)
        Me.AdicionarButton.Name = "AdicionarButton"
        Me.AdicionarButton.Size = New System.Drawing.Size(82, 29)
        Me.AdicionarButton.TabIndex = 71
        Me.AdicionarButton.Text = "Adicionar"
        Me.AdicionarButton.UseVisualStyleBackColor = True
        '
        'inputDataNasc
        '
        Me.inputDataNasc.Location = New System.Drawing.Point(310, 342)
        Me.inputDataNasc.Name = "inputDataNasc"
        Me.inputDataNasc.Size = New System.Drawing.Size(186, 22)
        Me.inputDataNasc.TabIndex = 70
        '
        'inputNome
        '
        Me.inputNome.Location = New System.Drawing.Point(310, 305)
        Me.inputNome.Name = "inputNome"
        Me.inputNome.Size = New System.Drawing.Size(186, 22)
        Me.inputNome.TabIndex = 69
        '
        'inputID
        '
        Me.inputID.Location = New System.Drawing.Point(214, 266)
        Me.inputID.Name = "inputID"
        Me.inputID.ReadOnly = True
        Me.inputID.Size = New System.Drawing.Size(282, 22)
        Me.inputID.TabIndex = 68
        '
        'DataNascLabel
        '
        Me.DataNascLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataNascLabel.Location = New System.Drawing.Point(147, 342)
        Me.DataNascLabel.Name = "DataNascLabel"
        Me.DataNascLabel.Size = New System.Drawing.Size(125, 22)
        Me.DataNascLabel.TabIndex = 67
        Me.DataNascLabel.Text = "Data Nascimento:"
        '
        'NomeLabel
        '
        Me.NomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NomeLabel.Location = New System.Drawing.Point(147, 305)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.Size = New System.Drawing.Size(125, 22)
        Me.NomeLabel.TabIndex = 66
        Me.NomeLabel.Text = "Nome:"
        '
        'IDLabel
        '
        Me.IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDLabel.Location = New System.Drawing.Point(147, 266)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(49, 22)
        Me.IDLabel.TabIndex = 65
        Me.IDLabel.Text = "ID:"
        '
        'ListagemListBox
        '
        Me.ListagemListBox.FormattingEnabled = True
        Me.ListagemListBox.ItemHeight = 16
        Me.ListagemListBox.Location = New System.Drawing.Point(147, 12)
        Me.ListagemListBox.Name = "ListagemListBox"
        Me.ListagemListBox.Size = New System.Drawing.Size(349, 244)
        Me.ListagemListBox.TabIndex = 74
        '
        'PosicaoBox
        '
        Me.PosicaoBox.FormattingEnabled = True
        Me.PosicaoBox.Location = New System.Drawing.Point(310, 407)
        Me.PosicaoBox.Name = "PosicaoBox"
        Me.PosicaoBox.Size = New System.Drawing.Size(186, 24)
        Me.PosicaoBox.TabIndex = 107
        '
        'pesquisarButton
        '
        Me.pesquisarButton.Location = New System.Drawing.Point(908, 288)
        Me.pesquisarButton.Name = "pesquisarButton"
        Me.pesquisarButton.Size = New System.Drawing.Size(82, 29)
        Me.pesquisarButton.TabIndex = 132
        Me.pesquisarButton.Text = "Pesquisar"
        Me.pesquisarButton.UseVisualStyleBackColor = True
        '
        'input3Nome
        '
        Me.input3Nome.Location = New System.Drawing.Point(897, 63)
        Me.input3Nome.Name = "input3Nome"
        Me.input3Nome.Size = New System.Drawing.Size(154, 22)
        Me.input3Nome.TabIndex = 131
        '
        'Nome3Label
        '
        Me.Nome3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome3Label.Location = New System.Drawing.Point(866, 38)
        Me.Nome3Label.Name = "Nome3Label"
        Me.Nome3Label.Size = New System.Drawing.Size(51, 22)
        Me.Nome3Label.TabIndex = 130
        Me.Nome3Label.Text = "Nome:"
        '
        'equipa3Box
        '
        Me.equipa3Box.FormattingEnabled = True
        Me.equipa3Box.Location = New System.Drawing.Point(897, 248)
        Me.equipa3Box.Name = "equipa3Box"
        Me.equipa3Box.Size = New System.Drawing.Size(154, 24)
        Me.equipa3Box.TabIndex = 129
        '
        'Equipa3Label
        '
        Me.Equipa3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Equipa3Label.Location = New System.Drawing.Point(866, 223)
        Me.Equipa3Label.Name = "Equipa3Label"
        Me.Equipa3Label.Size = New System.Drawing.Size(62, 22)
        Me.Equipa3Label.TabIndex = 128
        Me.Equipa3Label.Text = "Equipa:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(863, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Filtros:"
        '
        'input2ID
        '
        Me.input2ID.Location = New System.Drawing.Point(607, 288)
        Me.input2ID.Name = "input2ID"
        Me.input2ID.ReadOnly = True
        Me.input2ID.Size = New System.Drawing.Size(215, 22)
        Me.input2ID.TabIndex = 126
        '
        'ID2Label
        '
        Me.ID2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID2Label.Location = New System.Drawing.Point(527, 288)
        Me.ID2Label.Name = "ID2Label"
        Me.ID2Label.Size = New System.Drawing.Size(61, 22)
        Me.ID2Label.TabIndex = 125
        Me.ID2Label.Text = "ID:"
        '
        'Equipa2Label
        '
        Me.Equipa2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Equipa2Label.Location = New System.Drawing.Point(527, 466)
        Me.Equipa2Label.Name = "Equipa2Label"
        Me.Equipa2Label.Size = New System.Drawing.Size(135, 22)
        Me.Equipa2Label.TabIndex = 118
        Me.Equipa2Label.Text = "Equipa:"
        '
        'Posicao2Label
        '
        Me.Posicao2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Posicao2Label.Location = New System.Drawing.Point(527, 432)
        Me.Posicao2Label.Name = "Posicao2Label"
        Me.Posicao2Label.Size = New System.Drawing.Size(135, 22)
        Me.Posicao2Label.TabIndex = 117
        Me.Posicao2Label.Text = "Posicao:"
        '
        'input2Nacionalidade
        '
        Me.input2Nacionalidade.Location = New System.Drawing.Point(668, 399)
        Me.input2Nacionalidade.Name = "input2Nacionalidade"
        Me.input2Nacionalidade.ReadOnly = True
        Me.input2Nacionalidade.Size = New System.Drawing.Size(154, 22)
        Me.input2Nacionalidade.TabIndex = 116
        '
        'input2DataNasc
        '
        Me.input2DataNasc.Location = New System.Drawing.Point(668, 362)
        Me.input2DataNasc.Name = "input2DataNasc"
        Me.input2DataNasc.ReadOnly = True
        Me.input2DataNasc.Size = New System.Drawing.Size(154, 22)
        Me.input2DataNasc.TabIndex = 115
        '
        'input2Nome
        '
        Me.input2Nome.Location = New System.Drawing.Point(607, 323)
        Me.input2Nome.Name = "input2Nome"
        Me.input2Nome.ReadOnly = True
        Me.input2Nome.Size = New System.Drawing.Size(215, 22)
        Me.input2Nome.TabIndex = 114
        '
        'Nacionalidade2Label
        '
        Me.Nacionalidade2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nacionalidade2Label.Location = New System.Drawing.Point(527, 399)
        Me.Nacionalidade2Label.Name = "Nacionalidade2Label"
        Me.Nacionalidade2Label.Size = New System.Drawing.Size(135, 22)
        Me.Nacionalidade2Label.TabIndex = 113
        Me.Nacionalidade2Label.Text = "País:"
        '
        'DataNasc2Label
        '
        Me.DataNasc2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataNasc2Label.Location = New System.Drawing.Point(527, 362)
        Me.DataNasc2Label.Name = "DataNasc2Label"
        Me.DataNasc2Label.Size = New System.Drawing.Size(135, 22)
        Me.DataNasc2Label.TabIndex = 112
        Me.DataNasc2Label.Text = "Data Nascimento:"
        '
        'Nome2Label
        '
        Me.Nome2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome2Label.Location = New System.Drawing.Point(527, 323)
        Me.Nome2Label.Name = "Nome2Label"
        Me.Nome2Label.Size = New System.Drawing.Size(61, 22)
        Me.Nome2Label.TabIndex = 111
        Me.Nome2Label.Text = "Nome:"
        '
        'pesquisaListBox
        '
        Me.pesquisaListBox.FormattingEnabled = True
        Me.pesquisaListBox.ItemHeight = 16
        Me.pesquisaListBox.Location = New System.Drawing.Point(527, 32)
        Me.pesquisaListBox.Name = "pesquisaListBox"
        Me.pesquisaListBox.Size = New System.Drawing.Size(295, 244)
        Me.pesquisaListBox.TabIndex = 110
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(508, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 554)
        Me.Button1.TabIndex = 109
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(524, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Área de Pesquisa:"
        '
        'input3Nacionalidade
        '
        Me.input3Nacionalidade.Location = New System.Drawing.Point(897, 123)
        Me.input3Nacionalidade.Name = "input3Nacionalidade"
        Me.input3Nacionalidade.Size = New System.Drawing.Size(154, 22)
        Me.input3Nacionalidade.TabIndex = 134
        '
        'Nacionalidade3Label
        '
        Me.Nacionalidade3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nacionalidade3Label.Location = New System.Drawing.Point(866, 98)
        Me.Nacionalidade3Label.Name = "Nacionalidade3Label"
        Me.Nacionalidade3Label.Size = New System.Drawing.Size(104, 22)
        Me.Nacionalidade3Label.TabIndex = 133
        Me.Nacionalidade3Label.Text = "País:"
        '
        'posicao3box
        '
        Me.posicao3box.FormattingEnabled = True
        Me.posicao3box.Location = New System.Drawing.Point(897, 189)
        Me.posicao3box.Name = "posicao3box"
        Me.posicao3box.Size = New System.Drawing.Size(154, 24)
        Me.posicao3box.TabIndex = 136
        '
        'posicao3Label
        '
        Me.posicao3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.posicao3Label.Location = New System.Drawing.Point(866, 164)
        Me.posicao3Label.Name = "posicao3Label"
        Me.posicao3Label.Size = New System.Drawing.Size(62, 22)
        Me.posicao3Label.TabIndex = 135
        Me.posicao3Label.Text = "Posicao:"
        '
        'posicao2box
        '
        Me.posicao2box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.posicao2box.FormattingEnabled = True
        Me.posicao2box.Location = New System.Drawing.Point(668, 432)
        Me.posicao2box.Name = "posicao2box"
        Me.posicao2box.Size = New System.Drawing.Size(154, 24)
        Me.posicao2box.TabIndex = 138
        '
        'equipa2box
        '
        Me.equipa2box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.equipa2box.FormattingEnabled = True
        Me.equipa2box.Location = New System.Drawing.Point(668, 466)
        Me.equipa2box.Name = "equipa2box"
        Me.equipa2box.Size = New System.Drawing.Size(154, 24)
        Me.equipa2box.TabIndex = 137
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
        Me.EquipaFictPartLigaButton.Location = New System.Drawing.Point(12, 631)
        Me.EquipaFictPartLigaButton.Name = "EquipaFictPartLigaButton"
        Me.EquipaFictPartLigaButton.Size = New System.Drawing.Size(118, 46)
        Me.EquipaFictPartLigaButton.TabIndex = 151
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
        Me.JogadorPertEquipaFictButton.Location = New System.Drawing.Point(12, 575)
        Me.JogadorPertEquipaFictButton.Name = "JogadorPertEquipaFictButton"
        Me.JogadorPertEquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPertEquipaFictButton.TabIndex = 150
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
        Me.JogadorPlaysInJogoButton.Location = New System.Drawing.Point(10, 519)
        Me.JogadorPlaysInJogoButton.Name = "JogadorPlaysInJogoButton"
        Me.JogadorPlaysInJogoButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPlaysInJogoButton.TabIndex = 149
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
        Me.MenuButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(137, 70)
        Me.MenuButton.TabIndex = 147
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
        Me.UtilizadorButton.Location = New System.Drawing.Point(10, 463)
        Me.UtilizadorButton.Name = "UtilizadorButton"
        Me.UtilizadorButton.Size = New System.Drawing.Size(118, 50)
        Me.UtilizadorButton.TabIndex = 146
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
        Me.LigaFictButton.Location = New System.Drawing.Point(10, 407)
        Me.LigaFictButton.Name = "LigaFictButton"
        Me.LigaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.LigaFictButton.TabIndex = 145
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
        Me.EquipaFictButton.Location = New System.Drawing.Point(12, 351)
        Me.EquipaFictButton.Name = "EquipaFictButton"
        Me.EquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaFictButton.TabIndex = 144
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
        Me.JogadorButton.Location = New System.Drawing.Point(12, 295)
        Me.JogadorButton.Name = "JogadorButton"
        Me.JogadorButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorButton.TabIndex = 143
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
        Me.EstadioButton.Location = New System.Drawing.Point(12, 183)
        Me.EstadioButton.Name = "EstadioButton"
        Me.EstadioButton.Size = New System.Drawing.Size(118, 50)
        Me.EstadioButton.TabIndex = 142
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
        Me.EquipaButton.Location = New System.Drawing.Point(12, 127)
        Me.EquipaButton.Name = "EquipaButton"
        Me.EquipaButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaButton.TabIndex = 141
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
        Me.JogosButton.Location = New System.Drawing.Point(10, 239)
        Me.JogosButton.Name = "JogosButton"
        Me.JogosButton.Size = New System.Drawing.Size(118, 50)
        Me.JogosButton.TabIndex = 140
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
        Me.CampButton.Location = New System.Drawing.Point(10, 71)
        Me.CampButton.Name = "CampButton"
        Me.CampButton.Size = New System.Drawing.Size(118, 50)
        Me.CampButton.TabIndex = 139
        Me.CampButton.Text = "Campeonato"
        Me.CampButton.UseVisualStyleBackColor = False
        Me.CampButton.Visible = False
        '
        'MenuBackButton
        '
        Me.MenuBackButton.BackColor = System.Drawing.Color.Black
        Me.MenuBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuBackButton.Image = Global.Projeto_Final.My.Resources.Resources.homepage
        Me.MenuBackButton.Location = New System.Drawing.Point(0, 0)
        Me.MenuBackButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuBackButton.Name = "MenuBackButton"
        Me.MenuBackButton.Size = New System.Drawing.Size(137, 708)
        Me.MenuBackButton.TabIndex = 148
        Me.MenuBackButton.UseVisualStyleBackColor = False
        Me.MenuBackButton.Visible = False
        '
        'LimparCamposButton
        '
        Me.LimparCamposButton.Location = New System.Drawing.Point(251, 528)
        Me.LimparCamposButton.Name = "LimparCamposButton"
        Me.LimparCamposButton.Size = New System.Drawing.Size(127, 38)
        Me.LimparCamposButton.TabIndex = 325
        Me.LimparCamposButton.Text = "Limpar Campos"
        Me.LimparCamposButton.UseVisualStyleBackColor = True
        '
        'Jogador
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
        Me.Controls.Add(Me.posicao2box)
        Me.Controls.Add(Me.equipa2box)
        Me.Controls.Add(Me.posicao3box)
        Me.Controls.Add(Me.posicao3Label)
        Me.Controls.Add(Me.input3Nacionalidade)
        Me.Controls.Add(Me.Nacionalidade3Label)
        Me.Controls.Add(Me.pesquisarButton)
        Me.Controls.Add(Me.input3Nome)
        Me.Controls.Add(Me.Nome3Label)
        Me.Controls.Add(Me.equipa3Box)
        Me.Controls.Add(Me.Equipa3Label)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.input2ID)
        Me.Controls.Add(Me.ID2Label)
        Me.Controls.Add(Me.Equipa2Label)
        Me.Controls.Add(Me.Posicao2Label)
        Me.Controls.Add(Me.input2Nacionalidade)
        Me.Controls.Add(Me.input2DataNasc)
        Me.Controls.Add(Me.input2Nome)
        Me.Controls.Add(Me.Nacionalidade2Label)
        Me.Controls.Add(Me.DataNasc2Label)
        Me.Controls.Add(Me.Nome2Label)
        Me.Controls.Add(Me.pesquisaListBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PosicaoBox)
        Me.Controls.Add(Me.equipaBox)
        Me.Controls.Add(Me.EquipaLabel)
        Me.Controls.Add(Me.inputNacionalidade)
        Me.Controls.Add(Me.PosicaoLabel)
        Me.Controls.Add(Me.NacionalidadeLabel)
        Me.Controls.Add(Me.AtualizarButton)
        Me.Controls.Add(Me.RemoverButton)
        Me.Controls.Add(Me.AdicionarButton)
        Me.Controls.Add(Me.inputDataNasc)
        Me.Controls.Add(Me.inputNome)
        Me.Controls.Add(Me.inputID)
        Me.Controls.Add(Me.DataNascLabel)
        Me.Controls.Add(Me.NomeLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.ListagemListBox)
        Me.Controls.Add(Me.MenuBackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Jogador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents equipaBox As ComboBox
    Friend WithEvents EquipaLabel As Label
    Friend WithEvents inputNacionalidade As TextBox
    Friend WithEvents PosicaoLabel As Label
    Friend WithEvents NacionalidadeLabel As Label
    Friend WithEvents AtualizarButton As Button
    Friend WithEvents RemoverButton As Button
    Friend WithEvents AdicionarButton As Button
    Friend WithEvents inputDataNasc As TextBox
    Friend WithEvents inputNome As TextBox
    Friend WithEvents inputID As TextBox
    Friend WithEvents DataNascLabel As Label
    Friend WithEvents NomeLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents ListagemListBox As ListBox
    Friend WithEvents PosicaoBox As ComboBox
    Friend WithEvents pesquisarButton As Button
    Friend WithEvents input3Nome As TextBox
    Friend WithEvents Nome3Label As Label
    Friend WithEvents equipa3Box As ComboBox
    Friend WithEvents Equipa3Label As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents input2ID As TextBox
    Friend WithEvents ID2Label As Label
    Friend WithEvents Equipa2Label As Label
    Friend WithEvents Posicao2Label As Label
    Friend WithEvents input2Nacionalidade As TextBox
    Friend WithEvents input2DataNasc As TextBox
    Friend WithEvents input2Nome As TextBox
    Friend WithEvents Nacionalidade2Label As Label
    Friend WithEvents DataNasc2Label As Label
    Friend WithEvents Nome2Label As Label
    Friend WithEvents pesquisaListBox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents input3Nacionalidade As TextBox
    Friend WithEvents Nacionalidade3Label As Label
    Friend WithEvents posicao3box As ComboBox
    Friend WithEvents posicao3Label As Label
    Friend WithEvents posicao2box As ComboBox
    Friend WithEvents equipa2box As ComboBox
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
