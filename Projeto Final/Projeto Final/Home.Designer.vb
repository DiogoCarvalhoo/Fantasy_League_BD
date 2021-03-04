<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.MenuBackButton = New System.Windows.Forms.Button()
        Me.UtilizadorButton = New System.Windows.Forms.Button()
        Me.LigaFictButton = New System.Windows.Forms.Button()
        Me.EquipaFictButton = New System.Windows.Forms.Button()
        Me.JogadorButton = New System.Windows.Forms.Button()
        Me.EstadioButton = New System.Windows.Forms.Button()
        Me.EquipaButton = New System.Windows.Forms.Button()
        Me.JogosButton = New System.Windows.Forms.Button()
        Me.CampButton = New System.Windows.Forms.Button()
        Me.JogadorPlaysInJogoButton = New System.Windows.Forms.Button()
        Me.JogadorPertEquipaFictButton = New System.Windows.Forms.Button()
        Me.EquipaFictPartLigaButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.MenuButton.TabIndex = 11
        Me.MenuButton.Text = "Menu"
        Me.MenuButton.UseVisualStyleBackColor = False
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
        Me.MenuBackButton.TabIndex = 12
        Me.MenuBackButton.UseVisualStyleBackColor = False
        Me.MenuBackButton.Visible = False
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
        Me.UtilizadorButton.TabIndex = 10
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
        Me.LigaFictButton.TabIndex = 9
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
        Me.EquipaFictButton.TabIndex = 8
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
        Me.JogadorButton.TabIndex = 7
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
        Me.EstadioButton.TabIndex = 6
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
        Me.EquipaButton.TabIndex = 5
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
        Me.JogosButton.TabIndex = 4
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
        Me.CampButton.TabIndex = 3
        Me.CampButton.Text = "Campeonato"
        Me.CampButton.UseVisualStyleBackColor = False
        Me.CampButton.Visible = False
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
        Me.JogadorPlaysInJogoButton.TabIndex = 13
        Me.JogadorPlaysInJogoButton.Text = "JogadorPlaysInJogo"
        Me.JogadorPlaysInJogoButton.UseVisualStyleBackColor = False
        Me.JogadorPlaysInJogoButton.Visible = False
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
        Me.JogadorPertEquipaFictButton.TabIndex = 14
        Me.JogadorPertEquipaFictButton.Text = "JogadorPertenceEquipaFict"
        Me.JogadorPertEquipaFictButton.UseVisualStyleBackColor = False
        Me.JogadorPertEquipaFictButton.Visible = False
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
        Me.EquipaFictPartLigaButton.TabIndex = 15
        Me.EquipaFictPartLigaButton.Text = "EquipaFictPartLiga"
        Me.EquipaFictPartLigaButton.UseVisualStyleBackColor = False
        Me.EquipaFictPartLigaButton.Visible = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Projeto_Final.My.Resources.Resources.homepage2
        Me.ClientSize = New System.Drawing.Size(1082, 673)
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
        Me.Controls.Add(Me.MenuBackButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fantasy League"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CampButton As Button
    Friend WithEvents JogosButton As Button
    Friend WithEvents EquipaButton As Button
    Friend WithEvents EstadioButton As Button
    Friend WithEvents JogadorButton As Button
    Friend WithEvents EquipaFictButton As Button
    Friend WithEvents LigaFictButton As Button
    Friend WithEvents UtilizadorButton As Button
    Friend WithEvents MenuButton As Button
    Friend WithEvents MenuBackButton As Button
    Friend WithEvents JogadorPlaysInJogoButton As Button
    Friend WithEvents JogadorPertEquipaFictButton As Button
    Friend WithEvents EquipaFictPartLigaButton As Button
End Class
