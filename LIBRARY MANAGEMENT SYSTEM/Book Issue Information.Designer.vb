<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookIssueInformation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnIssueBook = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearchBorrower = New System.Windows.Forms.Button()
        Me.txtBorrower = New System.Windows.Forms.TextBox()
        Me.cboBorrower = New System.Windows.Forms.ComboBox()
        Me.dgvBookIssue = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvBookIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(172, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Issue "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ISBN :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchBook)
        Me.GroupBox1.Controls.Add(Me.txtBookTitle)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Controls.Add(Me.dtpDueDate)
        Me.GroupBox1.Controls.Add(Me.dtpIssueDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(31, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 147)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Details"
        '
        'btnSearchBook
        '
        Me.btnSearchBook.BackColor = System.Drawing.Color.White
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBook.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBook.Location = New System.Drawing.Point(378, 24)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(98, 43)
        Me.btnSearchBook.TabIndex = 9
        Me.btnSearchBook.Text = "Search"
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'txtBookTitle
        '
        Me.txtBookTitle.BackColor = System.Drawing.Color.Black
        Me.txtBookTitle.Enabled = False
        Me.txtBookTitle.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.ForeColor = System.Drawing.Color.White
        Me.txtBookTitle.Location = New System.Drawing.Point(95, 59)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(261, 22)
        Me.txtBookTitle.TabIndex = 8
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Black
        Me.txtISBN.Enabled = False
        Me.txtISBN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.ForeColor = System.Drawing.Color.White
        Me.txtISBN.Location = New System.Drawing.Point(95, 21)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(261, 22)
        Me.txtISBN.TabIndex = 7
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Location = New System.Drawing.Point(281, 118)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(218, 22)
        Me.dtpDueDate.TabIndex = 6
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpIssueDate.CalendarMonthBackground = System.Drawing.Color.Black
        Me.dtpIssueDate.CalendarTitleBackColor = System.Drawing.Color.Black
        Me.dtpIssueDate.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpIssueDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIssueDate.Location = New System.Drawing.Point(14, 118)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(218, 22)
        Me.dtpIssueDate.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(278, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Due Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Issue Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Book Tittle :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Borrower's Name :"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.Black
        Me.btnReturn.Location = New System.Drawing.Point(401, 473)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(129, 31)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnIssueBook
        '
        Me.btnIssueBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIssueBook.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssueBook.Location = New System.Drawing.Point(66, 473)
        Me.btnIssueBook.Name = "btnIssueBook"
        Me.btnIssueBook.Size = New System.Drawing.Size(129, 31)
        Me.btnIssueBook.TabIndex = 5
        Me.btnIssueBook.Text = "Issue Book"
        Me.btnIssueBook.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnSearchBorrower)
        Me.GroupBox2.Controls.Add(Me.txtBorrower)
        Me.GroupBox2.Controls.Add(Me.cboBorrower)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(31, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 91)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Borrower Details"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(378, 50)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(98, 33)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        Me.btnAdd.Visible = False
        '
        'btnSearchBorrower
        '
        Me.btnSearchBorrower.BackColor = System.Drawing.Color.White
        Me.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBorrower.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBorrower.ForeColor = System.Drawing.Color.Black
        Me.btnSearchBorrower.Location = New System.Drawing.Point(378, 12)
        Me.btnSearchBorrower.Name = "btnSearchBorrower"
        Me.btnSearchBorrower.Size = New System.Drawing.Size(98, 33)
        Me.btnSearchBorrower.TabIndex = 6
        Me.btnSearchBorrower.Text = "Search"
        Me.btnSearchBorrower.UseVisualStyleBackColor = False
        '
        'txtBorrower
        '
        Me.txtBorrower.BackColor = System.Drawing.Color.Black
        Me.txtBorrower.Enabled = False
        Me.txtBorrower.ForeColor = System.Drawing.Color.White
        Me.txtBorrower.Location = New System.Drawing.Point(136, 58)
        Me.txtBorrower.Name = "txtBorrower"
        Me.txtBorrower.Size = New System.Drawing.Size(220, 22)
        Me.txtBorrower.TabIndex = 5
        '
        'cboBorrower
        '
        Me.cboBorrower.BackColor = System.Drawing.Color.Black
        Me.cboBorrower.ForeColor = System.Drawing.Color.White
        Me.cboBorrower.FormattingEnabled = True
        Me.cboBorrower.Location = New System.Drawing.Point(19, 21)
        Me.cboBorrower.Name = "cboBorrower"
        Me.cboBorrower.Size = New System.Drawing.Size(337, 24)
        Me.cboBorrower.TabIndex = 4
        '
        'dgvBookIssue
        '
        Me.dgvBookIssue.AllowUserToAddRows = False
        Me.dgvBookIssue.AllowUserToDeleteRows = False
        Me.dgvBookIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookIssue.BackgroundColor = System.Drawing.Color.Black
        Me.dgvBookIssue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBookIssue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookIssue.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookIssue.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBookIssue.EnableHeadersVisualStyles = False
        Me.dgvBookIssue.Location = New System.Drawing.Point(31, 335)
        Me.dgvBookIssue.Name = "dgvBookIssue"
        Me.dgvBookIssue.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookIssue.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBookIssue.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvBookIssue.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBookIssue.Size = New System.Drawing.Size(515, 132)
        Me.dgvBookIssue.TabIndex = 9
        '
        'BookIssueInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(575, 507)
        Me.Controls.Add(Me.dgvBookIssue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnIssueBook)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BookIssueInformation"
        Me.Text = "Borrower Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvBookIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents dtpIssueDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnIssueBook As Button
    Friend WithEvents txtBookTitle As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBorrower As TextBox
    Friend WithEvents cboBorrower As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearchBorrower As Button
    Friend WithEvents dgvBookIssue As DataGridView
    Friend WithEvents btnSearchBook As Button
End Class