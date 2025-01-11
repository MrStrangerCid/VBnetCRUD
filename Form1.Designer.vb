<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnAdd = New Button()
        Label1 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        bday = New DateTimePicker()
        cmbProgram = New ComboBox()
        btnUpdate = New Button()
        btnClear = New Button()
        btnDetele = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtbxSearch = New TextBox()
        Label6 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(93, 257)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(91, 32)
        btnAdd.TabIndex = 1
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(775, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 32)
        Label1.TabIndex = 2
        Label1.Text = "x"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(95, 73)
        txtName.Name = "txtName"
        txtName.Size = New Size(192, 23)
        txtName.TabIndex = 3
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(95, 117)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(192, 23)
        txtAge.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(43, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 7
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 8
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 9
        Label4.Text = "Birthday"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 10
        Label5.Text = "Section"
        ' 
        ' bday
        ' 
        bday.Location = New Point(97, 163)
        bday.Name = "bday"
        bday.Size = New Size(190, 23)
        bday.TabIndex = 11
        ' 
        ' cmbProgram
        ' 
        cmbProgram.FormattingEnabled = True
        cmbProgram.Items.AddRange(New Object() {"BSIT", "BSHM", "BEED", "BSED", "BSAgri"})
        cmbProgram.Location = New Point(93, 208)
        cmbProgram.Name = "cmbProgram"
        cmbProgram.Size = New Size(192, 23)
        cmbProgram.TabIndex = 13
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(196, 257)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(91, 32)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(93, 295)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(194, 32)
        btnClear.TabIndex = 15
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDetele
        ' 
        btnDetele.Location = New Point(9, 257)
        btnDetele.Name = "btnDetele"
        btnDetele.Size = New Size(78, 70)
        btnDetele.TabIndex = 16
        btnDetele.Text = "Del"
        btnDetele.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(311, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(480, 254)
        DataGridView1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Student name"
        Column1.Name = "Column1"
        Column1.Width = 106
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Age"
        Column2.Name = "Column2"
        Column2.Width = 53
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Birthday"
        Column3.Name = "Column3"
        Column3.Width = 76
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Section"
        Column4.Name = "Column4"
        Column4.Width = 71
        ' 
        ' txtbxSearch
        ' 
        txtbxSearch.Location = New Point(359, 40)
        txtbxSearch.Name = "txtbxSearch"
        txtbxSearch.Size = New Size(192, 23)
        txtbxSearch.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(311, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 19
        Label6.Text = "Search"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(814, 389)
        ControlBox = False
        Controls.Add(Label6)
        Controls.Add(txtbxSearch)
        Controls.Add(DataGridView1)
        Controls.Add(btnDetele)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(cmbProgram)
        Controls.Add(bday)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bday As DateTimePicker
    Friend WithEvents cmbProgram As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDetele As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtbxSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn

End Class
