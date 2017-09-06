<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LB_Name = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LL_Stammdaten = New System.Windows.Forms.LinkLabel()
        Me.LL_Kontakte = New System.Windows.Forms.LinkLabel()
        Me.LL_Eltern = New System.Windows.Forms.LinkLabel()
        Me.LL_Schule = New System.Windows.Forms.LinkLabel()
        Me.LL_Psycho = New System.Windows.Forms.LinkLabel()
        Me.LL_Kinderarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Hilfen = New System.Windows.Forms.LinkLabel()
        Me.LL_Augenarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_HNO = New System.Windows.Forms.LinkLabel()
        Me.LL_Zahnarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Krankenhaus = New System.Windows.Forms.LinkLabel()
        Me.LL_Hautarzt = New System.Windows.Forms.LinkLabel()
        Me.LL_Doku = New System.Windows.Forms.LinkLabel()
        Me.B_öffne = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LB_Name
        '
        Me.LB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Name.FormattingEnabled = True
        Me.LB_Name.ItemHeight = 20
        Me.LB_Name.Items.AddRange(New Object() {"Aaliyah", "Aleks", "David", "Dominik", "Fenya", "Jan", "Jeremy", "Leon", "Louis", "Maurice", "Michelle", "Natalie", "Noah", "Paul", "Raphael"})
        Me.LB_Name.Location = New System.Drawing.Point(300, 50)
        Me.LB_Name.Name = "LB_Name"
        Me.LB_Name.Size = New System.Drawing.Size(200, 24)
        Me.LB_Name.Sorted = True
        Me.LB_Name.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(50, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 129)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LL_Stammdaten
        '
        Me.LL_Stammdaten.AutoSize = True
        Me.LL_Stammdaten.Location = New System.Drawing.Point(50, 200)
        Me.LL_Stammdaten.Name = "LL_Stammdaten"
        Me.LL_Stammdaten.Size = New System.Drawing.Size(66, 13)
        Me.LL_Stammdaten.TabIndex = 3
        Me.LL_Stammdaten.TabStop = True
        Me.LL_Stammdaten.Text = "Stammdaten"
        '
        'LL_Kontakte
        '
        Me.LL_Kontakte.AutoSize = True
        Me.LL_Kontakte.Location = New System.Drawing.Point(50, 220)
        Me.LL_Kontakte.Name = "LL_Kontakte"
        Me.LL_Kontakte.Size = New System.Drawing.Size(50, 13)
        Me.LL_Kontakte.TabIndex = 3
        Me.LL_Kontakte.TabStop = True
        Me.LL_Kontakte.Text = "Kontakte"
        '
        'LL_Eltern
        '
        Me.LL_Eltern.AutoSize = True
        Me.LL_Eltern.Location = New System.Drawing.Point(50, 240)
        Me.LL_Eltern.Name = "LL_Eltern"
        Me.LL_Eltern.Size = New System.Drawing.Size(34, 13)
        Me.LL_Eltern.TabIndex = 3
        Me.LL_Eltern.TabStop = True
        Me.LL_Eltern.Text = "Eltern"
        '
        'LL_Schule
        '
        Me.LL_Schule.AutoSize = True
        Me.LL_Schule.Location = New System.Drawing.Point(50, 260)
        Me.LL_Schule.Name = "LL_Schule"
        Me.LL_Schule.Size = New System.Drawing.Size(40, 13)
        Me.LL_Schule.TabIndex = 3
        Me.LL_Schule.TabStop = True
        Me.LL_Schule.Text = "Schule"
        '
        'LL_Psycho
        '
        Me.LL_Psycho.AutoSize = True
        Me.LL_Psycho.Location = New System.Drawing.Point(50, 320)
        Me.LL_Psycho.Name = "LL_Psycho"
        Me.LL_Psycho.Size = New System.Drawing.Size(42, 13)
        Me.LL_Psycho.TabIndex = 3
        Me.LL_Psycho.TabStop = True
        Me.LL_Psycho.Text = "Psycho"
        '
        'LL_Kinderarzt
        '
        Me.LL_Kinderarzt.AutoSize = True
        Me.LL_Kinderarzt.Location = New System.Drawing.Point(50, 340)
        Me.LL_Kinderarzt.Name = "LL_Kinderarzt"
        Me.LL_Kinderarzt.Size = New System.Drawing.Size(54, 13)
        Me.LL_Kinderarzt.TabIndex = 3
        Me.LL_Kinderarzt.TabStop = True
        Me.LL_Kinderarzt.Text = "Kinderarzt"
        '
        'LL_Hilfen
        '
        Me.LL_Hilfen.AutoSize = True
        Me.LL_Hilfen.Location = New System.Drawing.Point(50, 300)
        Me.LL_Hilfen.Name = "LL_Hilfen"
        Me.LL_Hilfen.Size = New System.Drawing.Size(34, 13)
        Me.LL_Hilfen.TabIndex = 3
        Me.LL_Hilfen.TabStop = True
        Me.LL_Hilfen.Text = "Hilfen"
        '
        'LL_Augenarzt
        '
        Me.LL_Augenarzt.AutoSize = True
        Me.LL_Augenarzt.Location = New System.Drawing.Point(50, 440)
        Me.LL_Augenarzt.Name = "LL_Augenarzt"
        Me.LL_Augenarzt.Size = New System.Drawing.Size(55, 13)
        Me.LL_Augenarzt.TabIndex = 3
        Me.LL_Augenarzt.TabStop = True
        Me.LL_Augenarzt.Text = "Augenarzt"
        '
        'LL_HNO
        '
        Me.LL_HNO.AutoSize = True
        Me.LL_HNO.Location = New System.Drawing.Point(50, 360)
        Me.LL_HNO.Name = "LL_HNO"
        Me.LL_HNO.Size = New System.Drawing.Size(31, 13)
        Me.LL_HNO.TabIndex = 3
        Me.LL_HNO.TabStop = True
        Me.LL_HNO.Text = "HNO"
        '
        'LL_Zahnarzt
        '
        Me.LL_Zahnarzt.AutoSize = True
        Me.LL_Zahnarzt.Location = New System.Drawing.Point(50, 380)
        Me.LL_Zahnarzt.Name = "LL_Zahnarzt"
        Me.LL_Zahnarzt.Size = New System.Drawing.Size(49, 13)
        Me.LL_Zahnarzt.TabIndex = 3
        Me.LL_Zahnarzt.TabStop = True
        Me.LL_Zahnarzt.Text = "Zahnarzt"
        '
        'LL_Krankenhaus
        '
        Me.LL_Krankenhaus.AutoSize = True
        Me.LL_Krankenhaus.Location = New System.Drawing.Point(50, 400)
        Me.LL_Krankenhaus.Name = "LL_Krankenhaus"
        Me.LL_Krankenhaus.Size = New System.Drawing.Size(70, 13)
        Me.LL_Krankenhaus.TabIndex = 3
        Me.LL_Krankenhaus.TabStop = True
        Me.LL_Krankenhaus.Text = "Krankenhaus"
        '
        'LL_Hautarzt
        '
        Me.LL_Hautarzt.AutoSize = True
        Me.LL_Hautarzt.Location = New System.Drawing.Point(50, 420)
        Me.LL_Hautarzt.Name = "LL_Hautarzt"
        Me.LL_Hautarzt.Size = New System.Drawing.Size(47, 13)
        Me.LL_Hautarzt.TabIndex = 3
        Me.LL_Hautarzt.TabStop = True
        Me.LL_Hautarzt.Text = "Hautarzt"
        '
        'LL_Doku
        '
        Me.LL_Doku.AutoSize = True
        Me.LL_Doku.Location = New System.Drawing.Point(50, 280)
        Me.LL_Doku.Name = "LL_Doku"
        Me.LL_Doku.Size = New System.Drawing.Size(33, 13)
        Me.LL_Doku.TabIndex = 3
        Me.LL_Doku.TabStop = True
        Me.LL_Doku.Text = "Doku"
        '
        'B_öffne
        '
        Me.B_öffne.Location = New System.Drawing.Point(325, 174)
        Me.B_öffne.Name = "B_öffne"
        Me.B_öffne.Size = New System.Drawing.Size(107, 46)
        Me.B_öffne.TabIndex = 4
        Me.B_öffne.Text = "öffne"
        Me.B_öffne.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 546)
        Me.Controls.Add(Me.B_öffne)
        Me.Controls.Add(Me.LL_Doku)
        Me.Controls.Add(Me.LL_Hautarzt)
        Me.Controls.Add(Me.LL_Augenarzt)
        Me.Controls.Add(Me.LL_Schule)
        Me.Controls.Add(Me.LL_Krankenhaus)
        Me.Controls.Add(Me.LL_Hilfen)
        Me.Controls.Add(Me.LL_Eltern)
        Me.Controls.Add(Me.LL_Zahnarzt)
        Me.Controls.Add(Me.LL_HNO)
        Me.Controls.Add(Me.LL_Kinderarzt)
        Me.Controls.Add(Me.LL_Psycho)
        Me.Controls.Add(Me.LL_Kontakte)
        Me.Controls.Add(Me.LL_Stammdaten)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LB_Name)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LB_Name As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LL_Stammdaten As LinkLabel
    Friend WithEvents LL_Kontakte As LinkLabel
    Friend WithEvents LL_Eltern As LinkLabel
    Friend WithEvents LL_Schule As LinkLabel
    Friend WithEvents LL_Psycho As LinkLabel
    Friend WithEvents LL_Kinderarzt As LinkLabel
    Friend WithEvents LL_Hilfen As LinkLabel
    Friend WithEvents LL_Augenarzt As LinkLabel
    Friend WithEvents LL_HNO As LinkLabel
    Friend WithEvents LL_Zahnarzt As LinkLabel
    Friend WithEvents LL_Krankenhaus As LinkLabel
    Friend WithEvents LL_Hautarzt As LinkLabel
    Friend WithEvents LL_Doku As LinkLabel
    Friend WithEvents B_öffne As Button
End Class
