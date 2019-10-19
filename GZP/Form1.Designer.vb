<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LBL_CreaBat = New System.Windows.Forms.Label()
        Me.LBL_NomBat = New System.Windows.Forms.Label()
        Me.LBL_LongueurBat = New System.Windows.Forms.Label()
        Me.LBL_LargeurBat = New System.Windows.Forms.Label()
        Me.LBL_PointBat = New System.Windows.Forms.Label()
        Me.TXT_NomBat = New System.Windows.Forms.TextBox()
        Me.TXT_LongueurBat = New System.Windows.Forms.TextBox()
        Me.TXT_LargeurBat = New System.Windows.Forms.TextBox()
        Me.TXT_CoordonneesBat = New System.Windows.Forms.TextBox()
        Me.BTN_CreationBat = New System.Windows.Forms.Button()
        Me.BTN_AnnulerCreationBat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_CreaBat
        '
        Me.LBL_CreaBat.AutoSize = True
        Me.LBL_CreaBat.Location = New System.Drawing.Point(284, 19)
        Me.LBL_CreaBat.Name = "LBL_CreaBat"
        Me.LBL_CreaBat.Size = New System.Drawing.Size(112, 13)
        Me.LBL_CreaBat.TabIndex = 0
        Me.LBL_CreaBat.Text = "Création d'un batiment"
        '
        'LBL_NomBat
        '
        Me.LBL_NomBat.AutoSize = True
        Me.LBL_NomBat.Location = New System.Drawing.Point(42, 81)
        Me.LBL_NomBat.Name = "LBL_NomBat"
        Me.LBL_NomBat.Size = New System.Drawing.Size(78, 13)
        Me.LBL_NomBat.TabIndex = 1
        Me.LBL_NomBat.Text = "Denomination :"
        '
        'LBL_LongueurBat
        '
        Me.LBL_LongueurBat.AutoSize = True
        Me.LBL_LongueurBat.Location = New System.Drawing.Point(42, 174)
        Me.LBL_LongueurBat.Name = "LBL_LongueurBat"
        Me.LBL_LongueurBat.Size = New System.Drawing.Size(55, 13)
        Me.LBL_LongueurBat.TabIndex = 2
        Me.LBL_LongueurBat.Text = "Longueur:"
        '
        'LBL_LargeurBat
        '
        Me.LBL_LargeurBat.AutoSize = True
        Me.LBL_LargeurBat.Location = New System.Drawing.Point(350, 174)
        Me.LBL_LargeurBat.Name = "LBL_LargeurBat"
        Me.LBL_LargeurBat.Size = New System.Drawing.Size(46, 13)
        Me.LBL_LargeurBat.TabIndex = 3
        Me.LBL_LargeurBat.Text = "Largeur:"
        '
        'LBL_PointBat
        '
        Me.LBL_PointBat.AutoSize = True
        Me.LBL_PointBat.Location = New System.Drawing.Point(46, 287)
        Me.LBL_PointBat.Name = "LBL_PointBat"
        Me.LBL_PointBat.Size = New System.Drawing.Size(358, 13)
        Me.LBL_PointBat.TabIndex = 4
        Me.LBL_PointBat.Text = "Coordonnées du batiment : (4 points minimum au format : x y , x y, x y, x y) :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TXT_NomBat
        '
        Me.TXT_NomBat.Location = New System.Drawing.Point(126, 78)
        Me.TXT_NomBat.Name = "TXT_NomBat"
        Me.TXT_NomBat.Size = New System.Drawing.Size(100, 20)
        Me.TXT_NomBat.TabIndex = 5
        '
        'TXT_LongueurBat
        '
        Me.TXT_LongueurBat.Location = New System.Drawing.Point(103, 171)
        Me.TXT_LongueurBat.Name = "TXT_LongueurBat"
        Me.TXT_LongueurBat.Size = New System.Drawing.Size(100, 20)
        Me.TXT_LongueurBat.TabIndex = 6
        '
        'TXT_LargeurBat
        '
        Me.TXT_LargeurBat.Location = New System.Drawing.Point(402, 171)
        Me.TXT_LargeurBat.Name = "TXT_LargeurBat"
        Me.TXT_LargeurBat.Size = New System.Drawing.Size(100, 20)
        Me.TXT_LargeurBat.TabIndex = 7
        '
        'TXT_CoordonneesBat
        '
        Me.TXT_CoordonneesBat.Location = New System.Drawing.Point(49, 323)
        Me.TXT_CoordonneesBat.Name = "TXT_CoordonneesBat"
        Me.TXT_CoordonneesBat.Size = New System.Drawing.Size(514, 20)
        Me.TXT_CoordonneesBat.TabIndex = 8
        '
        'BTN_CreationBat
        '
        Me.BTN_CreationBat.BackColor = System.Drawing.Color.ForestGreen
        Me.BTN_CreationBat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_CreationBat.Location = New System.Drawing.Point(34, 613)
        Me.BTN_CreationBat.Name = "BTN_CreationBat"
        Me.BTN_CreationBat.Size = New System.Drawing.Size(411, 23)
        Me.BTN_CreationBat.TabIndex = 9
        Me.BTN_CreationBat.Text = "Valider la création"
        Me.BTN_CreationBat.UseVisualStyleBackColor = False
        '
        'BTN_AnnulerCreationBat
        '
        Me.BTN_AnnulerCreationBat.BackColor = System.Drawing.Color.Red
        Me.BTN_AnnulerCreationBat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_AnnulerCreationBat.Location = New System.Drawing.Point(478, 613)
        Me.BTN_AnnulerCreationBat.Name = "BTN_AnnulerCreationBat"
        Me.BTN_AnnulerCreationBat.Size = New System.Drawing.Size(168, 23)
        Me.BTN_AnnulerCreationBat.TabIndex = 10
        Me.BTN_AnnulerCreationBat.Text = "Annuler"
        Me.BTN_AnnulerCreationBat.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 657)
        Me.Controls.Add(Me.BTN_AnnulerCreationBat)
        Me.Controls.Add(Me.BTN_CreationBat)
        Me.Controls.Add(Me.TXT_CoordonneesBat)
        Me.Controls.Add(Me.TXT_LargeurBat)
        Me.Controls.Add(Me.TXT_LongueurBat)
        Me.Controls.Add(Me.TXT_NomBat)
        Me.Controls.Add(Me.LBL_PointBat)
        Me.Controls.Add(Me.LBL_LargeurBat)
        Me.Controls.Add(Me.LBL_LongueurBat)
        Me.Controls.Add(Me.LBL_NomBat)
        Me.Controls.Add(Me.LBL_CreaBat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_CreaBat As Label
    Friend WithEvents LBL_NomBat As Label
    Friend WithEvents LBL_LongueurBat As Label
    Friend WithEvents LBL_LargeurBat As Label
    Friend WithEvents LBL_PointBat As Label
    Friend WithEvents TXT_NomBat As TextBox
    Friend WithEvents TXT_LongueurBat As TextBox
    Friend WithEvents TXT_LargeurBat As TextBox
    Friend WithEvents TXT_CoordonneesBat As TextBox
    Friend WithEvents BTN_CreationBat As Button
    Friend WithEvents BTN_AnnulerCreationBat As Button
End Class
