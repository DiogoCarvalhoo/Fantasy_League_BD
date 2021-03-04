<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Utilizador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utilizador))
        Me.input3Email = New System.Windows.Forms.TextBox()
        Me.Salt2Box = New System.Windows.Forms.ComboBox()
        Me.Salt2Label = New System.Windows.Forms.Label()
        Me.input2Email = New System.Windows.Forms.TextBox()
        Me.Email2Label = New System.Windows.Forms.Label()
        Me.input2DataNasc = New System.Windows.Forms.TextBox()
        Me.DataNascimento2Label = New System.Windows.Forms.Label()
        Me.input2Password = New System.Windows.Forms.TextBox()
        Me.input2Nick = New System.Windows.Forms.TextBox()
        Me.Password2Label = New System.Windows.Forms.Label()
        Me.Nick2Label = New System.Windows.Forms.Label()
        Me.pesquisarButton = New System.Windows.Forms.Button()
        Me.input3Nick = New System.Windows.Forms.TextBox()
        Me.Nick3Label = New System.Windows.Forms.Label()
        Me.Email3Label = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pesquisaListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaltBox = New System.Windows.Forms.ComboBox()
        Me.SaltLabel = New System.Windows.Forms.Label()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.inputDataNasc = New System.Windows.Forms.TextBox()
        Me.DataNascLabel = New System.Windows.Forms.Label()
        Me.AtualizarButton = New System.Windows.Forms.Button()
        Me.RemoverButton = New System.Windows.Forms.Button()
        Me.AdicionarButton = New System.Windows.Forms.Button()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.inputNick = New System.Windows.Forms.TextBox()
        Me.PassWordLabel = New System.Windows.Forms.Label()
        Me.NickLabel = New System.Windows.Forms.Label()
        Me.ListagemListBox = New System.Windows.Forms.ListBox()
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
        'input3Email
        '
        Me.input3Email.Location = New System.Drawing.Point(904, 164)
        Me.input3Email.Name = "input3Email"
        Me.input3Email.Size = New System.Drawing.Size(149, 22)
        Me.input3Email.TabIndex = 160
        '
        'Salt2Box
        '
        Me.Salt2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Salt2Box.FormattingEnabled = True
        Me.Salt2Box.Location = New System.Drawing.Point(695, 451)
        Me.Salt2Box.Name = "Salt2Box"
        Me.Salt2Box.Size = New System.Drawing.Size(149, 24)
        Me.Salt2Box.TabIndex = 159
        '
        'Salt2Label
        '
        Me.Salt2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Salt2Label.Location = New System.Drawing.Point(550, 453)
        Me.Salt2Label.Name = "Salt2Label"
        Me.Salt2Label.Size = New System.Drawing.Size(125, 22)
        Me.Salt2Label.TabIndex = 158
        Me.Salt2Label.Text = "Salt:"
        '
        'input2Email
        '
        Me.input2Email.Location = New System.Drawing.Point(695, 531)
        Me.input2Email.Name = "input2Email"
        Me.input2Email.ReadOnly = True
        Me.input2Email.Size = New System.Drawing.Size(149, 22)
        Me.input2Email.TabIndex = 157
        '
        'Email2Label
        '
        Me.Email2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email2Label.Location = New System.Drawing.Point(550, 531)
        Me.Email2Label.Name = "Email2Label"
        Me.Email2Label.Size = New System.Drawing.Size(125, 22)
        Me.Email2Label.TabIndex = 156
        Me.Email2Label.Text = "Email:"
        '
        'input2DataNasc
        '
        Me.input2DataNasc.Location = New System.Drawing.Point(695, 492)
        Me.input2DataNasc.Name = "input2DataNasc"
        Me.input2DataNasc.ReadOnly = True
        Me.input2DataNasc.Size = New System.Drawing.Size(149, 22)
        Me.input2DataNasc.TabIndex = 155
        '
        'DataNascimento2Label
        '
        Me.DataNascimento2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataNascimento2Label.Location = New System.Drawing.Point(550, 492)
        Me.DataNascimento2Label.Name = "DataNascimento2Label"
        Me.DataNascimento2Label.Size = New System.Drawing.Size(125, 22)
        Me.DataNascimento2Label.TabIndex = 154
        Me.DataNascimento2Label.Text = "Data Nascimento:"
        '
        'input2Password
        '
        Me.input2Password.Location = New System.Drawing.Point(695, 416)
        Me.input2Password.Name = "input2Password"
        Me.input2Password.ReadOnly = True
        Me.input2Password.Size = New System.Drawing.Size(149, 22)
        Me.input2Password.TabIndex = 153
        '
        'input2Nick
        '
        Me.input2Nick.Location = New System.Drawing.Point(617, 381)
        Me.input2Nick.Name = "input2Nick"
        Me.input2Nick.ReadOnly = True
        Me.input2Nick.Size = New System.Drawing.Size(227, 22)
        Me.input2Nick.TabIndex = 152
        '
        'Password2Label
        '
        Me.Password2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Password2Label.Location = New System.Drawing.Point(550, 416)
        Me.Password2Label.Name = "Password2Label"
        Me.Password2Label.Size = New System.Drawing.Size(125, 22)
        Me.Password2Label.TabIndex = 151
        Me.Password2Label.Text = "Password:"
        '
        'Nick2Label
        '
        Me.Nick2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nick2Label.Location = New System.Drawing.Point(550, 381)
        Me.Nick2Label.Name = "Nick2Label"
        Me.Nick2Label.Size = New System.Drawing.Size(49, 22)
        Me.Nick2Label.TabIndex = 150
        Me.Nick2Label.Text = "Nick:"
        '
        'pesquisarButton
        '
        Me.pesquisarButton.Location = New System.Drawing.Point(912, 196)
        Me.pesquisarButton.Name = "pesquisarButton"
        Me.pesquisarButton.Size = New System.Drawing.Size(82, 29)
        Me.pesquisarButton.TabIndex = 149
        Me.pesquisarButton.Text = "Pesquisar"
        Me.pesquisarButton.UseVisualStyleBackColor = True
        '
        'input3Nick
        '
        Me.input3Nick.Location = New System.Drawing.Point(899, 95)
        Me.input3Nick.Name = "input3Nick"
        Me.input3Nick.Size = New System.Drawing.Size(154, 22)
        Me.input3Nick.TabIndex = 148
        '
        'Nick3Label
        '
        Me.Nick3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nick3Label.Location = New System.Drawing.Point(868, 70)
        Me.Nick3Label.Name = "Nick3Label"
        Me.Nick3Label.Size = New System.Drawing.Size(51, 22)
        Me.Nick3Label.TabIndex = 147
        Me.Nick3Label.Text = "Nick:"
        '
        'Email3Label
        '
        Me.Email3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email3Label.Location = New System.Drawing.Point(868, 129)
        Me.Email3Label.Name = "Email3Label"
        Me.Email3Label.Size = New System.Drawing.Size(94, 22)
        Me.Email3Label.TabIndex = 146
        Me.Email3Label.Text = "Email:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(865, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 17)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Filtros:"
        '
        'pesquisaListBox
        '
        Me.pesquisaListBox.FormattingEnabled = True
        Me.pesquisaListBox.ItemHeight = 16
        Me.pesquisaListBox.Location = New System.Drawing.Point(550, 43)
        Me.pesquisaListBox.Name = "pesquisaListBox"
        Me.pesquisaListBox.Size = New System.Drawing.Size(295, 324)
        Me.pesquisaListBox.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(547, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Área de Pesquisa:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(521, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 554)
        Me.Button1.TabIndex = 142
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaltBox
        '
        Me.SaltBox.FormattingEnabled = True
        Me.SaltBox.Location = New System.Drawing.Point(318, 451)
        Me.SaltBox.Name = "SaltBox"
        Me.SaltBox.Size = New System.Drawing.Size(186, 24)
        Me.SaltBox.TabIndex = 141
        '
        'SaltLabel
        '
        Me.SaltLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaltLabel.Location = New System.Drawing.Point(155, 453)
        Me.SaltLabel.Name = "SaltLabel"
        Me.SaltLabel.Size = New System.Drawing.Size(125, 22)
        Me.SaltLabel.TabIndex = 140
        Me.SaltLabel.Text = "Salt:"
        '
        'inputEmail
        '
        Me.inputEmail.Location = New System.Drawing.Point(318, 531)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(186, 22)
        Me.inputEmail.TabIndex = 139
        '
        'EmailLabel
        '
        Me.EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailLabel.Location = New System.Drawing.Point(155, 531)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(125, 22)
        Me.EmailLabel.TabIndex = 138
        Me.EmailLabel.Text = "Email:"
        '
        'inputDataNasc
        '
        Me.inputDataNasc.Location = New System.Drawing.Point(318, 492)
        Me.inputDataNasc.Name = "inputDataNasc"
        Me.inputDataNasc.Size = New System.Drawing.Size(186, 22)
        Me.inputDataNasc.TabIndex = 137
        '
        'DataNascLabel
        '
        Me.DataNascLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataNascLabel.Location = New System.Drawing.Point(155, 492)
        Me.DataNascLabel.Name = "DataNascLabel"
        Me.DataNascLabel.Size = New System.Drawing.Size(125, 22)
        Me.DataNascLabel.TabIndex = 136
        Me.DataNascLabel.Text = "Data Nascimento:"
        '
        'AtualizarButton
        '
        Me.AtualizarButton.Location = New System.Drawing.Point(422, 576)
        Me.AtualizarButton.Name = "AtualizarButton"
        Me.AtualizarButton.Size = New System.Drawing.Size(82, 29)
        Me.AtualizarButton.TabIndex = 134
        Me.AtualizarButton.Text = "Atualizar"
        Me.AtualizarButton.UseVisualStyleBackColor = True
        '
        'RemoverButton
        '
        Me.RemoverButton.Location = New System.Drawing.Point(287, 576)
        Me.RemoverButton.Name = "RemoverButton"
        Me.RemoverButton.Size = New System.Drawing.Size(82, 29)
        Me.RemoverButton.TabIndex = 133
        Me.RemoverButton.Text = "Remover"
        Me.RemoverButton.UseVisualStyleBackColor = True
        '
        'AdicionarButton
        '
        Me.AdicionarButton.Location = New System.Drawing.Point(155, 576)
        Me.AdicionarButton.Name = "AdicionarButton"
        Me.AdicionarButton.Size = New System.Drawing.Size(82, 29)
        Me.AdicionarButton.TabIndex = 132
        Me.AdicionarButton.Text = "Adicionar"
        Me.AdicionarButton.UseVisualStyleBackColor = True
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(318, 416)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(186, 22)
        Me.inputPassword.TabIndex = 131
        '
        'inputNick
        '
        Me.inputNick.Location = New System.Drawing.Point(222, 381)
        Me.inputNick.Name = "inputNick"
        Me.inputNick.Size = New System.Drawing.Size(282, 22)
        Me.inputNick.TabIndex = 130
        '
        'PassWordLabel
        '
        Me.PassWordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PassWordLabel.Location = New System.Drawing.Point(155, 416)
        Me.PassWordLabel.Name = "PassWordLabel"
        Me.PassWordLabel.Size = New System.Drawing.Size(125, 22)
        Me.PassWordLabel.TabIndex = 129
        Me.PassWordLabel.Text = "Password:"
        '
        'NickLabel
        '
        Me.NickLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NickLabel.Location = New System.Drawing.Point(155, 381)
        Me.NickLabel.Name = "NickLabel"
        Me.NickLabel.Size = New System.Drawing.Size(49, 22)
        Me.NickLabel.TabIndex = 128
        Me.NickLabel.Text = "Nick:"
        '
        'ListagemListBox
        '
        Me.ListagemListBox.FormattingEnabled = True
        Me.ListagemListBox.ItemHeight = 16
        Me.ListagemListBox.Location = New System.Drawing.Point(154, 12)
        Me.ListagemListBox.Name = "ListagemListBox"
        Me.ListagemListBox.Size = New System.Drawing.Size(350, 356)
        Me.ListagemListBox.TabIndex = 135
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
        Me.EquipaFictPartLigaButton.Location = New System.Drawing.Point(12, 630)
        Me.EquipaFictPartLigaButton.Name = "EquipaFictPartLigaButton"
        Me.EquipaFictPartLigaButton.Size = New System.Drawing.Size(118, 46)
        Me.EquipaFictPartLigaButton.TabIndex = 173
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
        Me.JogadorPertEquipaFictButton.Location = New System.Drawing.Point(12, 574)
        Me.JogadorPertEquipaFictButton.Name = "JogadorPertEquipaFictButton"
        Me.JogadorPertEquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPertEquipaFictButton.TabIndex = 172
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
        Me.JogadorPlaysInJogoButton.Location = New System.Drawing.Point(10, 518)
        Me.JogadorPlaysInJogoButton.Name = "JogadorPlaysInJogoButton"
        Me.JogadorPlaysInJogoButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorPlaysInJogoButton.TabIndex = 171
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
        Me.MenuButton.Location = New System.Drawing.Point(0, -1)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(137, 70)
        Me.MenuButton.TabIndex = 169
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
        Me.UtilizadorButton.Location = New System.Drawing.Point(10, 462)
        Me.UtilizadorButton.Name = "UtilizadorButton"
        Me.UtilizadorButton.Size = New System.Drawing.Size(118, 50)
        Me.UtilizadorButton.TabIndex = 168
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
        Me.LigaFictButton.Location = New System.Drawing.Point(10, 406)
        Me.LigaFictButton.Name = "LigaFictButton"
        Me.LigaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.LigaFictButton.TabIndex = 167
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
        Me.EquipaFictButton.Location = New System.Drawing.Point(12, 350)
        Me.EquipaFictButton.Name = "EquipaFictButton"
        Me.EquipaFictButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaFictButton.TabIndex = 166
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
        Me.JogadorButton.Location = New System.Drawing.Point(12, 294)
        Me.JogadorButton.Name = "JogadorButton"
        Me.JogadorButton.Size = New System.Drawing.Size(118, 50)
        Me.JogadorButton.TabIndex = 165
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
        Me.EstadioButton.Location = New System.Drawing.Point(12, 182)
        Me.EstadioButton.Name = "EstadioButton"
        Me.EstadioButton.Size = New System.Drawing.Size(118, 50)
        Me.EstadioButton.TabIndex = 164
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
        Me.EquipaButton.Location = New System.Drawing.Point(12, 126)
        Me.EquipaButton.Name = "EquipaButton"
        Me.EquipaButton.Size = New System.Drawing.Size(118, 50)
        Me.EquipaButton.TabIndex = 163
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
        Me.JogosButton.Location = New System.Drawing.Point(10, 238)
        Me.JogosButton.Name = "JogosButton"
        Me.JogosButton.Size = New System.Drawing.Size(118, 50)
        Me.JogosButton.TabIndex = 162
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
        Me.CampButton.Location = New System.Drawing.Point(10, 70)
        Me.CampButton.Name = "CampButton"
        Me.CampButton.Size = New System.Drawing.Size(118, 50)
        Me.CampButton.TabIndex = 161
        Me.CampButton.Text = "Campeonato"
        Me.CampButton.UseVisualStyleBackColor = False
        Me.CampButton.Visible = False
        '
        'MenuBackButton
        '
        Me.MenuBackButton.BackColor = System.Drawing.Color.Black
        Me.MenuBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuBackButton.Image = Global.Projeto_Final.My.Resources.Resources.homepage
        Me.MenuBackButton.Location = New System.Drawing.Point(0, -1)
        Me.MenuBackButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuBackButton.Name = "MenuBackButton"
        Me.MenuBackButton.Size = New System.Drawing.Size(137, 708)
        Me.MenuBackButton.TabIndex = 170
        Me.MenuBackButton.UseVisualStyleBackColor = False
        Me.MenuBackButton.Visible = False
        '
        'LimparCamposButton
        '
        Me.LimparCamposButton.Location = New System.Drawing.Point(264, 623)
        Me.LimparCamposButton.Name = "LimparCamposButton"
        Me.LimparCamposButton.Size = New System.Drawing.Size(127, 38)
        Me.LimparCamposButton.TabIndex = 325
        Me.LimparCamposButton.Text = "Limpar Campos"
        Me.LimparCamposButton.UseVisualStyleBackColor = True
        '
        'Utilizador
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
        Me.Controls.Add(Me.input3Email)
        Me.Controls.Add(Me.Salt2Box)
        Me.Controls.Add(Me.Salt2Label)
        Me.Controls.Add(Me.input2Email)
        Me.Controls.Add(Me.Email2Label)
        Me.Controls.Add(Me.input2DataNasc)
        Me.Controls.Add(Me.DataNascimento2Label)
        Me.Controls.Add(Me.input2Password)
        Me.Controls.Add(Me.input2Nick)
        Me.Controls.Add(Me.Password2Label)
        Me.Controls.Add(Me.Nick2Label)
        Me.Controls.Add(Me.pesquisarButton)
        Me.Controls.Add(Me.input3Nick)
        Me.Controls.Add(Me.Nick3Label)
        Me.Controls.Add(Me.Email3Label)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.pesquisaListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SaltBox)
        Me.Controls.Add(Me.SaltLabel)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.inputDataNasc)
        Me.Controls.Add(Me.DataNascLabel)
        Me.Controls.Add(Me.AtualizarButton)
        Me.Controls.Add(Me.RemoverButton)
        Me.Controls.Add(Me.AdicionarButton)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.inputNick)
        Me.Controls.Add(Me.PassWordLabel)
        Me.Controls.Add(Me.NickLabel)
        Me.Controls.Add(Me.ListagemListBox)
        Me.Controls.Add(Me.MenuBackButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Utilizador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasy League"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input3Email As TextBox
    Friend WithEvents Salt2Box As ComboBox
    Friend WithEvents Salt2Label As Label
    Friend WithEvents input2Email As TextBox
    Friend WithEvents Email2Label As Label
    Friend WithEvents input2DataNasc As TextBox
    Friend WithEvents DataNascimento2Label As Label
    Friend WithEvents input2Password As TextBox
    Friend WithEvents input2Nick As TextBox
    Friend WithEvents Password2Label As Label
    Friend WithEvents Nick2Label As Label
    Friend WithEvents pesquisarButton As Button
    Friend WithEvents input3Nick As TextBox
    Friend WithEvents Nick3Label As Label
    Friend WithEvents Email3Label As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents pesquisaListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents SaltBox As ComboBox
    Friend WithEvents SaltLabel As Label
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents EmailLabel As Label
    Friend WithEvents inputDataNasc As TextBox
    Friend WithEvents DataNascLabel As Label
    Friend WithEvents AtualizarButton As Button
    Friend WithEvents RemoverButton As Button
    Friend WithEvents AdicionarButton As Button
    Friend WithEvents inputPassword As TextBox
    Friend WithEvents inputNick As TextBox
    Friend WithEvents PassWordLabel As Label
    Friend WithEvents NickLabel As Label
    Friend WithEvents ListagemListBox As ListBox
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
