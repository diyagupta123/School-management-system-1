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
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim Last_nameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Email_idLabel As System.Windows.Forms.Label
        Dim Student_mobile_no_Label As System.Windows.Forms.Label
        Dim Parent_gudian_detailsLabel As System.Windows.Forms.Label
        Dim PG_phone_no_Label As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Telephone_no_Label As System.Windows.Forms.Label
        Dim PG_email_idLabel As System.Windows.Forms.Label
        Dim PincodeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.School_DataSet = New VB_School_Management_System.School_DataSet()
        Me.SchoolTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolTableTableAdapter = New VB_School_Management_System.School_DataSetTableAdapters.SchoolTableTableAdapter()
        Me.TableAdapterManager = New VB_School_Management_System.School_DataSetTableAdapters.TableAdapterManager()
        Me.SchoolTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SchoolTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Email_idTextBox = New System.Windows.Forms.TextBox()
        Me.Student_mobile_no_TextBox = New System.Windows.Forms.TextBox()
        Me.Parent_gudian_detailsTextBox = New System.Windows.Forms.TextBox()
        Me.PG_phone_no_TextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Telephone_no_TextBox = New System.Windows.Forms.TextBox()
        Me.PG_email_idTextBox = New System.Windows.Forms.TextBox()
        Me.PincodeTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        Last_nameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Email_idLabel = New System.Windows.Forms.Label()
        Student_mobile_no_Label = New System.Windows.Forms.Label()
        Parent_gudian_detailsLabel = New System.Windows.Forms.Label()
        PG_phone_no_Label = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Telephone_no_Label = New System.Windows.Forms.Label()
        PG_email_idLabel = New System.Windows.Forms.Label()
        PincodeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.School_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolTableBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(70, 145)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(170, 33)
        Student_IDLabel.TabIndex = 1
        Student_IDLabel.Text = "Student ID:"
        AddHandler Student_IDLabel.Click, AddressOf Me.Student_IDLabel_Click
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_nameLabel.Location = New System.Drawing.Point(71, 193)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(173, 33)
        First_nameLabel.TabIndex = 3
        First_nameLabel.Text = "First name:"
        '
        'Last_nameLabel
        '
        Last_nameLabel.AutoSize = True
        Last_nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_nameLabel.Location = New System.Drawing.Point(71, 242)
        Last_nameLabel.Name = "Last_nameLabel"
        Last_nameLabel.Size = New System.Drawing.Size(169, 33)
        Last_nameLabel.TabIndex = 5
        Last_nameLabel.Text = "Last name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(71, 292)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(78, 33)
        AgeLabel.TabIndex = 7
        AgeLabel.Text = "Age:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(71, 343)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(127, 33)
        GenderLabel.TabIndex = 9
        GenderLabel.Text = "Gender:"
        '
        'Email_idLabel
        '
        Email_idLabel.AutoSize = True
        Email_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_idLabel.Location = New System.Drawing.Point(71, 394)
        Email_idLabel.Name = "Email_idLabel"
        Email_idLabel.Size = New System.Drawing.Size(134, 33)
        Email_idLabel.TabIndex = 11
        Email_idLabel.Text = "email id:"
        '
        'Student_mobile_no_Label
        '
        Student_mobile_no_Label.AutoSize = True
        Student_mobile_no_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_mobile_no_Label.Location = New System.Drawing.Point(71, 449)
        Student_mobile_no_Label.Name = "Student_mobile_no_Label"
        Student_mobile_no_Label.Size = New System.Drawing.Size(284, 33)
        Student_mobile_no_Label.TabIndex = 13
        Student_mobile_no_Label.Text = "Student mobile no :"
        '
        'Parent_gudian_detailsLabel
        '
        Parent_gudian_detailsLabel.AutoSize = True
        Parent_gudian_detailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_gudian_detailsLabel.Location = New System.Drawing.Point(712, 193)
        Parent_gudian_detailsLabel.Name = "Parent_gudian_detailsLabel"
        Parent_gudian_detailsLabel.Size = New System.Drawing.Size(318, 33)
        Parent_gudian_detailsLabel.TabIndex = 15
        Parent_gudian_detailsLabel.Text = "Parent/gudian details:"
        '
        'PG_phone_no_Label
        '
        PG_phone_no_Label.AutoSize = True
        PG_phone_no_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PG_phone_no_Label.Location = New System.Drawing.Point(712, 242)
        PG_phone_no_Label.Name = "PG_phone_no_Label"
        PG_phone_no_Label.Size = New System.Drawing.Size(214, 33)
        PG_phone_no_Label.TabIndex = 17
        PG_phone_no_Label.Text = "PG phone no :"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(712, 292)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(138, 33)
        AddressLabel.TabIndex = 19
        AddressLabel.Text = "Address:"
        '
        'Telephone_no_Label
        '
        Telephone_no_Label.AutoSize = True
        Telephone_no_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Telephone_no_Label.Location = New System.Drawing.Point(712, 343)
        Telephone_no_Label.Name = "Telephone_no_Label"
        Telephone_no_Label.Size = New System.Drawing.Size(222, 33)
        Telephone_no_Label.TabIndex = 21
        Telephone_no_Label.Text = "Telephone no :"
        '
        'PG_email_idLabel
        '
        PG_email_idLabel.AutoSize = True
        PG_email_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PG_email_idLabel.Location = New System.Drawing.Point(712, 394)
        PG_email_idLabel.Name = "PG_email_idLabel"
        PG_email_idLabel.Size = New System.Drawing.Size(187, 33)
        PG_email_idLabel.TabIndex = 23
        PG_email_idLabel.Text = "PG email id:"
        '
        'PincodeLabel
        '
        PincodeLabel.AutoSize = True
        PincodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PincodeLabel.Location = New System.Drawing.Point(712, 449)
        PincodeLabel.Name = "PincodeLabel"
        PincodeLabel.Size = New System.Drawing.Size(136, 33)
        PincodeLabel.TabIndex = 25
        PincodeLabel.Text = "Pincode:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(712, 145)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(122, 33)
        Label1.TabIndex = 28
        Label1.Text = "Search:"
        '
        'School_DataSet
        '
        Me.School_DataSet.DataSetName = "School_DataSet"
        Me.School_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolTableBindingSource
        '
        Me.SchoolTableBindingSource.DataMember = "SchoolTable"
        Me.SchoolTableBindingSource.DataSource = Me.School_DataSet
        '
        'SchoolTableTableAdapter
        '
        Me.SchoolTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SchoolTableTableAdapter = Me.SchoolTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = VB_School_Management_System.School_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SchoolTableBindingNavigator
        '
        Me.SchoolTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SchoolTableBindingNavigator.BindingSource = Me.SchoolTableBindingSource
        Me.SchoolTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SchoolTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SchoolTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SchoolTableBindingNavigatorSaveItem})
        Me.SchoolTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SchoolTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SchoolTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SchoolTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SchoolTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SchoolTableBindingNavigator.Name = "SchoolTableBindingNavigator"
        Me.SchoolTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SchoolTableBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.SchoolTableBindingNavigator.TabIndex = 0
        Me.SchoolTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SchoolTableBindingNavigatorSaveItem
        '
        Me.SchoolTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SchoolTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("SchoolTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SchoolTableBindingNavigatorSaveItem.Name = "SchoolTableBindingNavigatorSaveItem"
        Me.SchoolTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SchoolTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(383, 142)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(244, 40)
        Me.Student_IDTextBox.TabIndex = 2
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "First name", True))
        Me.First_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_nameTextBox.Location = New System.Drawing.Point(383, 190)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(244, 40)
        Me.First_nameTextBox.TabIndex = 4
        '
        'Last_nameTextBox
        '
        Me.Last_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Last name", True))
        Me.Last_nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_nameTextBox.Location = New System.Drawing.Point(383, 239)
        Me.Last_nameTextBox.Name = "Last_nameTextBox"
        Me.Last_nameTextBox.Size = New System.Drawing.Size(244, 40)
        Me.Last_nameTextBox.TabIndex = 6
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(383, 289)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(244, 40)
        Me.AgeTextBox.TabIndex = 8
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(383, 340)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(244, 40)
        Me.GenderTextBox.TabIndex = 10
        '
        'Email_idTextBox
        '
        Me.Email_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "email id", True))
        Me.Email_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_idTextBox.Location = New System.Drawing.Point(383, 391)
        Me.Email_idTextBox.Name = "Email_idTextBox"
        Me.Email_idTextBox.Size = New System.Drawing.Size(244, 40)
        Me.Email_idTextBox.TabIndex = 12
        '
        'Student_mobile_no_TextBox
        '
        Me.Student_mobile_no_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Student mobile no_", True))
        Me.Student_mobile_no_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_mobile_no_TextBox.Location = New System.Drawing.Point(383, 446)
        Me.Student_mobile_no_TextBox.Name = "Student_mobile_no_TextBox"
        Me.Student_mobile_no_TextBox.Size = New System.Drawing.Size(244, 40)
        Me.Student_mobile_no_TextBox.TabIndex = 14
        '
        'Parent_gudian_detailsTextBox
        '
        Me.Parent_gudian_detailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Parent/gudian details", True))
        Me.Parent_gudian_detailsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_gudian_detailsTextBox.Location = New System.Drawing.Point(1061, 190)
        Me.Parent_gudian_detailsTextBox.Name = "Parent_gudian_detailsTextBox"
        Me.Parent_gudian_detailsTextBox.Size = New System.Drawing.Size(244, 40)
        Me.Parent_gudian_detailsTextBox.TabIndex = 16
        '
        'PG_phone_no_TextBox
        '
        Me.PG_phone_no_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "PG phone no_", True))
        Me.PG_phone_no_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PG_phone_no_TextBox.Location = New System.Drawing.Point(1061, 239)
        Me.PG_phone_no_TextBox.Name = "PG_phone_no_TextBox"
        Me.PG_phone_no_TextBox.Size = New System.Drawing.Size(244, 40)
        Me.PG_phone_no_TextBox.TabIndex = 18
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(1061, 289)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(244, 40)
        Me.AddressTextBox.TabIndex = 20
        '
        'Telephone_no_TextBox
        '
        Me.Telephone_no_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Telephone no_", True))
        Me.Telephone_no_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone_no_TextBox.Location = New System.Drawing.Point(1061, 340)
        Me.Telephone_no_TextBox.Name = "Telephone_no_TextBox"
        Me.Telephone_no_TextBox.Size = New System.Drawing.Size(244, 40)
        Me.Telephone_no_TextBox.TabIndex = 22
        '
        'PG_email_idTextBox
        '
        Me.PG_email_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "PG email id", True))
        Me.PG_email_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PG_email_idTextBox.Location = New System.Drawing.Point(1061, 391)
        Me.PG_email_idTextBox.Name = "PG_email_idTextBox"
        Me.PG_email_idTextBox.Size = New System.Drawing.Size(244, 40)
        Me.PG_email_idTextBox.TabIndex = 24
        '
        'PincodeTextBox
        '
        Me.PincodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SchoolTableBindingSource, "Pincode", True))
        Me.PincodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PincodeTextBox.Location = New System.Drawing.Point(1061, 446)
        Me.PincodeTextBox.Name = "PincodeTextBox"
        Me.PincodeTextBox.Size = New System.Drawing.Size(244, 40)
        Me.PincodeTextBox.TabIndex = 26
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SchoolTableBindingSource
        Me.ComboBox1.DisplayMember = "First name"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1061, 142)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 41)
        Me.ComboBox1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button9)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.btnLastRecord)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnFirstRecord)
        Me.Panel2.Location = New System.Drawing.Point(67, 525)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1223, 168)
        Me.Panel2.TabIndex = 30
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DarkCyan
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button9.Location = New System.Drawing.Point(471, 100)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 47)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = ">"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkCyan
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button5.Location = New System.Drawing.Point(958, 100)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 47)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkCyan
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button6.Location = New System.Drawing.Point(662, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(202, 47)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkCyan
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button7.Location = New System.Drawing.Point(357, 100)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 47)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkCyan
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button8.Location = New System.Drawing.Point(61, 100)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(202, 47)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "AddNew"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button4.Location = New System.Drawing.Point(958, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(202, 47)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLastRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastRecord.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnLastRecord.Location = New System.Drawing.Point(662, 18)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(202, 47)
        Me.btnLastRecord.TabIndex = 2
        Me.btnLastRecord.Text = "Last Record"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Button2.Location = New System.Drawing.Point(357, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.DarkCyan
        Me.btnFirstRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstRecord.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.btnFirstRecord.Location = New System.Drawing.Point(61, 18)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(202, 47)
        Me.btnFirstRecord.TabIndex = 0
        Me.btnFirstRecord.Text = "First Record"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(530, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 55)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Registration"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(Last_nameLabel)
        Me.Controls.Add(Me.Last_nameTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Email_idLabel)
        Me.Controls.Add(Me.Email_idTextBox)
        Me.Controls.Add(Student_mobile_no_Label)
        Me.Controls.Add(Me.Student_mobile_no_TextBox)
        Me.Controls.Add(Parent_gudian_detailsLabel)
        Me.Controls.Add(Me.Parent_gudian_detailsTextBox)
        Me.Controls.Add(PG_phone_no_Label)
        Me.Controls.Add(Me.PG_phone_no_TextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Telephone_no_Label)
        Me.Controls.Add(Me.Telephone_no_TextBox)
        Me.Controls.Add(PG_email_idLabel)
        Me.Controls.Add(Me.PG_email_idTextBox)
        Me.Controls.Add(PincodeLabel)
        Me.Controls.Add(Me.PincodeTextBox)
        Me.Controls.Add(Me.SchoolTableBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.Menu
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.School_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolTableBindingNavigator.ResumeLayout(False)
        Me.SchoolTableBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents School_DataSet As School_DataSet
    Friend WithEvents SchoolTableBindingSource As BindingSource
    Friend WithEvents SchoolTableTableAdapter As School_DataSetTableAdapters.SchoolTableTableAdapter
    Friend WithEvents TableAdapterManager As School_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SchoolTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SchoolTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents Last_nameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents Email_idTextBox As TextBox
    Friend WithEvents Student_mobile_no_TextBox As TextBox
    Friend WithEvents Parent_gudian_detailsTextBox As TextBox
    Friend WithEvents PG_phone_no_TextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Telephone_no_TextBox As TextBox
    Friend WithEvents PG_email_idTextBox As TextBox
    Friend WithEvents PincodeTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents Label2 As Label
End Class
