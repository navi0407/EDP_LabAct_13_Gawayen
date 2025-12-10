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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtHiddenID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(249, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Records System"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(128, 106)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(276, 22)
        Me.txtId.TabIndex = 1
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(128, 242)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(276, 22)
        Me.txtSalary.TabIndex = 2
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(128, 194)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(276, 22)
        Me.txtPosition.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 149)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(276, 22)
        Me.txtName.TabIndex = 4
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(128, 286)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(276, 22)
        Me.txtDepartment.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Salary:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Position:"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Maroon
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCreate.Location = New System.Drawing.Point(138, 333)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(112, 46)
        Me.btnCreate.TabIndex = 9
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Maroon
        Me.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRead.Location = New System.Drawing.Point(280, 333)
        Me.btnRead.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(112, 46)
        Me.btnRead.TabIndex = 10
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Maroon
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(138, 394)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 46)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(280, 394)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 46)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(432, 65)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(427, 459)
        Me.DataGridView1.TabIndex = 13
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Maroon
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnConnect.Location = New System.Drawing.Point(211, 458)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(124, 51)
        Me.btnConnect.TabIndex = 14
        Me.btnConnect.Text = "Connect MySQL"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'txtHiddenID
        '
        Me.txtHiddenID.Location = New System.Drawing.Point(128, 65)
        Me.txtHiddenID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHiddenID.Name = "txtHiddenID"
        Me.txtHiddenID.Size = New System.Drawing.Size(276, 22)
        Me.txtHiddenID.TabIndex = 15
        Me.txtHiddenID.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(872, 592)
        Me.Controls.Add(Me.txtHiddenID)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtHiddenID As TextBox
End Class
