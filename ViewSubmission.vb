Public Class Slidely

    Private Sub Slidely_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Slidely_KeyDown
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CreateButton_Click.Click
        MessageBox.Show("Creating new submission")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewButton_Click.Click
        MessageBox.Show("Viewing submissions")
    End Sub



    Private Sub Slidely_KeyDown(sender As Object, e As KeyEventArgs)

        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button2_Click(Me, EventArgs.Empty)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub


End Class
