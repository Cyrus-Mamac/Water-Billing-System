Public Class Form1

    Dim pipe_size, min_charge, previous_reading, present_reading, total_consumption, bill, discount, diffdate As Decimal
    Dim emf As Integer
    Dim discountText As String
    Dim commercial, residential, discounted As Boolean

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxPrevious.Text = ""
        txtBoxPresent.Text = ""
        lblDiscount.Text = 0
        lblMinCharge.Text = 0
        lblTotalConsumption.Text = 0

    End Sub

    Private Sub txtBoxPrevious_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBoxPrevious.MouseClick
        txtBoxPrevious.Text = ""
    End Sub

    Private Sub txtBoxPresent_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBoxPresent.MouseClick
        txtBoxPresent.Text = ""
    End Sub
    Private Sub ReadingDate_MouseLeave(sender As Object, e As EventArgs) Handles ReadingDate.MouseLeave
        lblDiscount.Text = DateDiff(DateInterval.Day, ReadingDate.Value.Date, PaymentDate.Value.Date)
        lblDiscount.Visible = True
    End Sub

    Private Sub PaymentDate_MouseLeave(sender As Object, e As EventArgs) Handles PaymentDate.MouseLeave
        lblDiscount.Text = DateDiff(DateInterval.Day, ReadingDate.Value.Date, PaymentDate.Value.Date)
        lblDiscount.Visible = True
    End Sub

    Private Sub btnCalculate_MouseHover(sender As Object, e As EventArgs) Handles btnCalculate.MouseHover
        lblDiscount.Text = DateDiff(DateInterval.Day, ReadingDate.Value.Date, PaymentDate.Value.Date)
        lblDiscount.Visible = True
        lblTotalConsumption.Visible = True
        If txtBoxPresent.Text = "" And txtBoxPrevious.Text = "" Then
            lblTotalConsumption.Text = ""
        End If
        If diffdate >= 0 And diffdate <= 10 Then
            discount = 0.1
            discountText = "10%"
            discounted = True

        ElseIf diffdate >= 11 And diffdate <= 15 Then
            discount = 0.05
            discounted = True
            discountText = "5%"

        Else
            discounted = False

        End If

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        emf = 10
        diffdate = DateDiff(DateInterval.Day, ReadingDate.Value.Date, PaymentDate.Value.Date)
        If diffdate >= 0 And diffdate <= 10 Then
            discount = 0.1
            discountText = "10%"
            discounted = True

        ElseIf diffdate >= 11 And diffdate <= 15 Then
            discount = 0.05
            discounted = True
            discountText = "5%"

        Else
            discounted = False

        End If

        If previous_reading > present_reading Then
            MessageBox.Show("Error, your previous reading can't be larger than present reading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf txtBoxPrevious.Text <> "" And txtBoxPresent.Text <> "" And cbPipeSize.Text <> "" And (commercial = True Or residential = True) Then
            If residential = True Then
                If total_consumption >= 0 And total_consumption <= 10 Then
                    bill = (min_charge) + emf
                ElseIf total_consumption > 10 And total_consumption <= 20 Then
                    bill = ((total_consumption - 10) * 18.9) + min_charge + emf

                ElseIf total_consumption > 20 And total_consumption <= 30 Then
                    bill = ((total_consumption - 20) * 21.4) + (18.9 * 10) + min_charge + emf

                ElseIf total_consumption > 30 And total_consumption <= 40 Then
                    bill = ((total_consumption - 30) * 24.6) + (21.4 * 10) + (18.9 * 10) + min_charge + emf

                ElseIf total_consumption > 40 Then
                    bill = ((total_consumption - 40) * 28.8) + (24.6 * 10) + (21.4 * 10) + (18.9 * 10) + min_charge + emf

                End If

            ElseIf commercial = True Then
                If total_consumption >= 0 And total_consumption <= 10 Then
                    bill = (min_charge) + emf

                ElseIf total_consumption > 10 And total_consumption <= 20 Then
                    bill = ((total_consumption - 10) * 37.8) + min_charge + emf

                ElseIf total_consumption > 20 And total_consumption <= 30 Then
                    bill = ((total_consumption - 20) * 42.8) + (27.8 * 10) + min_charge + emf

                ElseIf total_consumption > 30 And total_consumption <= 40 Then
                    bill = ((total_consumption - 30) * 49.3) + (42.8 * 10) + (37.8 * 10) + min_charge + emf

                ElseIf total_consumption > 40 Then
                    bill = ((total_consumption - 40) * 57.6) + (49.3 * 10) + (42.8 * 10) + (37.8 * 10) + min_charge + emf
                End If
            End If
            If discounted = True Then
                bill = bill - (bill * discount)
            Else
                discountText = "No Discount"
            End If

            If commercial = True Then
                Form2.btnClose.Select()
                Form2.Show()
                Form2.txtBoxClassification.Text = "Commercial"
                Form2.txtBoxPipeSize.Text = cbPipeSize.Text
                Form2.txtBoxF2PrevReading.Text = txtBoxPrevious.Text & " Cubic Meter"
                Form2.txtBoxF2PresentReading.Text = txtBoxPresent.Text & " Cubic Meter"
                Form2.txtBoxMinCharge.Text = lblMinCharge.Text
                Form2.txtBoxDiscount.Text = discountText
                Form2.txtBoxTotalBill.Text = bill & " Pesos"
                Form2.TextBox1.Text = 10
                Form2.txtBoxTotalConsumption.Text = lblTotalConsumption.Text

            ElseIf residential = True Then
                Form2.btnClose.Select()
                Form2.Show()
                Form2.txtBoxClassification.Text = "Residential"
                Form2.txtBoxPipeSize.Text = cbPipeSize.Text
                Form2.txtBoxF2PrevReading.Text = txtBoxPrevious.Text & " Cubic Meter"
                Form2.txtBoxF2PresentReading.Text = txtBoxPresent.Text & " Cubic Meter"
                Form2.txtBoxMinCharge.Text = lblMinCharge.Text
                Form2.txtBoxDiscount.Text = discountText
                Form2.txtBoxTotalBill.Text = bill & " Pesos"
                Form2.TextBox1.Text = 10
                Form2.txtBoxTotalConsumption.Text = lblTotalConsumption.Text
            End If

        Else
            MessageBox.Show("Incomplete Field, Check for missing information", "Incomplete Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub rbResidential_CheckedChanged(sender As Object, e As EventArgs) Handles rbResidential.CheckedChanged
        If rbResidential.Checked = True Then
            residential = True
            If cbPipeSize.SelectedIndex = 0 And residential = True Then
                pipe_size = 1 / 2
                min_charge = 172.5
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 1 And residential = True Then
                pipe_size = 3 / 4
                min_charge = 276.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 2 And residential = True Then
                pipe_size = 1
                min_charge = 552.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 3 And residential = True Then
                pipe_size = 1 + (1 / 2)
                min_charge = 1380.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 4 And residential = True Then
                pipe_size = 2
                min_charge = 3450.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 5 And residential = True Then
                pipe_size = 3
                min_charge = 6210.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 6 And residential = True Then
                pipe_size = 4
                min_charge = 12420.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True
            End If

        Else
            residential = False
        End If
    End Sub
    Private Sub txtBoxPresent_Leave(sender As Object, e As EventArgs) Handles txtBoxPresent.Leave
        Try
            Convert.ToDecimal(txtBoxPresent.Text)
            present_reading = txtBoxPresent.Text
            If txtBoxPresent.Text <> "" And txtBoxPrevious.Text <> "" Then
                total_consumption = present_reading - previous_reading
                lblTotalConsumption.Text = total_consumption & " Cubic Meter"
                lblTotalConsumption.Visible = True
            ElseIf txtBoxPresent.Text = "" Then
                txtBoxPresent.Text = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error, Only Numbers are Accepted. Don't leave empty data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBoxPresent.Text = 0
        End Try
    End Sub
    Private Sub txtBoxPrevious_Leave(sender As Object, e As EventArgs) Handles txtBoxPrevious.Leave
        Try
            Convert.ToDecimal(txtBoxPrevious.Text)
            previous_reading = txtBoxPrevious.Text

            If txtBoxPresent.Text <> "" And txtBoxPrevious.Text <> "" Then
                total_consumption = present_reading - previous_reading
                lblTotalConsumption.Text = total_consumption & " Cubic Meter"
                lblTotalConsumption.Visible = True
            ElseIf txtBoxPrevious.Text = vbEmpty Then
                txtBoxPresent.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Error, Only Numbers are Accepted in Reading. Don't leave empty data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBoxPrevious.Text = 0
        End Try
    End Sub

    Private Sub rbCommercial_CheckedChanged(sender As Object, e As EventArgs) Handles rbCommercial.CheckedChanged
        If rbCommercial.Checked = True Then
            commercial = True
            If cbPipeSize.SelectedIndex = 0 And commercial = True Then
                pipe_size = 1 / 2
                min_charge = 345.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 1 And commercial = True Then
                pipe_size = 3 / 4
                min_charge = 552.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 2 And commercial = True Then
                pipe_size = 1
                min_charge = 1104.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 3 And commercial = True Then
                pipe_size = 1 + (1 / 2)
                min_charge = 2760.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 4 And commercial = True Then
                pipe_size = 2
                min_charge = 6900.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 5 And commercial = True Then
                pipe_size = 3
                min_charge = 12420.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True

            ElseIf cbPipeSize.SelectedIndex = 6 And commercial = True Then
                pipe_size = 4
                min_charge = 24840.0
                lblMinCharge.Text = min_charge & " Pesos"
                lblMinCharge.Visible = True
            End If

        Else
            commercial = False
        End If
    End Sub

    Private Sub cbPipeSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPipeSize.SelectedIndexChanged
        If cbPipeSize.SelectedIndex = 0 And residential = True Then
            pipe_size = 1 / 2
            min_charge = 172.5
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 1 And residential = True Then
            pipe_size = 3 / 4
            min_charge = 276.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 2 And residential = True Then
            pipe_size = 1
            min_charge = 552.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 3 And residential = True Then
            pipe_size = 1 + (1 / 2)
            min_charge = 1380.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 4 And residential = True Then
            pipe_size = 2
            min_charge = 3450.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 5 And residential = True Then
            pipe_size = 3
            min_charge = 6210.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 6 And residential = True Then
            pipe_size = 4
            min_charge = 12420.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 0 And commercial = True Then
            pipe_size = 1 / 2
            min_charge = 345.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 1 And commercial = True Then
            pipe_size = 3 / 4
            min_charge = 552.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 2 And commercial = True Then
            pipe_size = 1
            min_charge = 1104.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 3 And commercial = True Then
            pipe_size = 1 + (1 / 2)
            min_charge = 2760.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 4 And commercial = True Then
            pipe_size = 2
            min_charge = 6900.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 5 And commercial = True Then
            pipe_size = 3
            min_charge = 12420.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        ElseIf cbPipeSize.SelectedIndex = 6 And commercial = True Then
            pipe_size = 4
            min_charge = 24840.0
            lblMinCharge.Text = min_charge & " Pesos"
            lblMinCharge.Visible = True

        End If
    End Sub

End Class
