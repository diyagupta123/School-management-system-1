Public Class Form1
    Private Sub SchoolTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SchoolTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SchoolTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.School_DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School_DataSet.SchoolTable' table. You can move, or remove it, as needed.
        Me.SchoolTableTableAdapter.Fill(Me.School_DataSet.SchoolTable)
        Me.WindowState = FormWindowState.Normal
        If ComboBox1.Text = Nothing Then
            Try
                Me.SchoolTableBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Student_IDLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("confirm if you want exit", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.SchoolTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.School_DataSet)
            MessageBox.Show("Data saved on school management system", "SMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.SchoolTableBindingSource.AddNew()
            First_nameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click
        Try

            Me.SchoolTableBindingSource.MoveFirst()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        Try

            Me.SchoolTableBindingSource.MoveLast()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try

            Me.SchoolTableBindingSource.MovePrevious()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try

            Me.SchoolTableBindingSource.MoveNext()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Me.SchoolTableBindingSource.AddNew()
            First_nameTextBox.Select()
        Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim iDelete As DialogResult
        iDelete = MessageBox.Show("confirm if you want delete this data", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iDelete = DialogResult.Yes Then
            Try
                Me.SchoolTableBindingSource.RemoveCurrent()
            Catch ex As Exception

            End Try
        ElseIf iDelete = DialogResult.no Then
            'nothing
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
                a.Text = ""
            End If
        Next
    End Sub
End Class
