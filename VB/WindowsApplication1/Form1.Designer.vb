Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.IndicatorWidth = 30
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(740, 499)
            Me.treeList1.TabIndex = 0
            AddHandler Me.treeList1.CustomDrawNodeIndicator, New DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(AddressOf Me.treeList1_CustomDrawNodeIndicator)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(740, 499)
            Me.Controls.Add(Me.treeList1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.treeList1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private treeList1 As DevExpress.XtraTreeList.TreeList
    End Class
End Namespace
