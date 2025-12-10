Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=root; database=employee_db;"
        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtPosition.Text) Then
            MessageBox.Show("Please enter a position.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtSalary.Text) Then
            MessageBox.Show("Please enter a salary.")
        End If
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            MessageBox.Show("Please enter a department.")
            Return
        End If

        Dim salaryValue As Integer
        If Not Integer.TryParse(txtSalary.Text, salaryValue) Then
            MessageBox.Show("Please enter a valid numeric value for salary.")
            Return
        End If

        Dim query As String = "INSERT INTO employees (name, position, salary, department) VALUES (@name, @position, @salary, @department)"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_db")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", CInt(txtSalary.Text))
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record insert succeessfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim query As String = "SELECT * FROM employee_db.employees WHERE is_deleted=0;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_db;")
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                DataGridView1.Columns("id").Visible = False
                DataGridView1.Columns("is_deleted").Visible = False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtId.Text) Then
            MessageBox.Show("Please enter an ID.")
            Return
        End If

        Dim idValue As Integer
        If Not Integer.TryParse(txtId.Text, idValue) Then
            MessageBox.Show("Please enter a valid numeric value for ID.")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter a name.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtPosition.Text) Then
            MessageBox.Show("Please enter a position.")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtSalary.Text) Then
            MessageBox.Show("Please enter a salary.")
        End If
        If String.IsNullOrWhiteSpace(txtDepartment.Text) Then
            MessageBox.Show("Please enter a department.")
            Return
        End If

        Dim salaryValue As Integer
        If Not Integer.TryParse(txtSalary.Text, salaryValue) Then
            MessageBox.Show("Please enter a valid numeric value for salary.")
            Return
        End If

        Dim query As String = "UPDATE `employee_db`.`employees` " & "SET `name` = @name, `position` = @position, `salary` = @salary, `department` = @department " &
                      "WHERE `id` = @id;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtId.Text))
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", CInt(txtSalary.Text))
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "UPDATE `employee_db`.`employees` SET `is_deleted` = 1 WHERE `id` = @id;"
        Try
            Using conn As New MySqlConnection("server=localhost; userid=root; password=root; database=employee_db;")
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txtHiddenID.Text))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                    txtId.Clear()
                    txtName.Clear()
                    txtPosition.Clear()
                    txtSalary.Clear()
                    txtDepartment.Clear()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtName.Text = selectedRow.Cells("name").Value.ToString()
            txtPosition.Text = selectedRow.Cells("position").Value.ToString()
            txtSalary.Text = selectedRow.Cells("salary").Value.ToString()
            txtDepartment.Text = selectedRow.Cells("department").Value.ToString()
            txtHiddenID.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub
End Class
