' Calculates the total cable bill owed by the customer

Option Strict On
Public Class frmMain

    ' Data validation function
    Private Function Data_Validated_OK() As Boolean
        If radBusiness.Checked = False And radResidential.Checked = False Then
            MessageBox.Show("Customer type is required!")
            lstConnect.SelectedIndex = 0
            lstPremium.SelectedIndex = 0
            lblTotalDue.Text = String.Empty
            radBusiness.Focus()
            Return False
        End If
        If lstPremium.SelectedIndex = -1 Then
            MessageBox.Show("Premium channel(s) must be selected!")
            lstPremium.Focus()
            Return False
        End If
        If radBusiness.Checked = True And lstConnect.SelectedIndex = -1 Then
            MessageBox.Show("One or more connections must be selected!")
            lstConnect.Focus()
            Return False
        End If
        Return True
    End Function
    ' Calculate business bill total function
    Private Function GetBusinessBill(ByVal intNumPremuim As Integer, ByVal intNumConnect As Integer) As Double

        Dim dblBusProcessFee As Double = 16.5
        Dim dblServiceFee As Double
        Dim dblChanFee As Double
        Dim dblTotalFee As Double
        Integer.TryParse(lstPremium.SelectedItem.ToString, intNumPremuim)
        Integer.TryParse(lstConnect.SelectedItem.ToString, intNumConnect)

        If intNumConnect <= 10 Then
            dblServiceFee = 80.0
        ElseIf intNumConnect > 10 Then
            dblServiceFee = (intNumConnect - 10) * 4.0 + (80.0)
        End If
        dblChanFee = 50.0 * intNumPremuim
        dblTotalFee = dblBusProcessFee + dblChanFee + dblServiceFee
        Return dblTotalFee

    End Function

    ' Calculate residential bill total function
    Private Function GetResidentBill(ByVal intNumPremuim As Integer, ByVal intNumConnect As Integer) As Double
        Integer.TryParse(lstPremium.SelectedItem.ToString, intNumPremuim)
        Integer.TryParse(lstConnect.SelectedItem.ToString, intNumConnect)

        Dim dblBusProcessFee As Double = 4.5
        Dim dblServiceFee As Double = 30.0
        Dim dblChanFee As Double
        Dim dblTotalFee As Double
        dblChanFee = intNumPremuim * 5.0
        dblTotalFee = dblBusProcessFee + dblServiceFee + dblChanFee
        Return dblTotalFee
    End Function

    ' Prompting the user to confirm exit on form close
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgbutton As DialogResult
        dlgbutton = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        ' If NO button was selected, do not close the form
        If dlgbutton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fill listbox premium with values
        For intPreChan As Integer = 0 To 20 Step 1
            lstPremium.Items.Add(intPreChan.ToString("N0"))
        Next intPreChan
        ' Fill listbox connection with values
        For intNumConnect As Integer = 0 To 100 Step 1
            lstConnect.Items.Add(intNumConnect.ToString("N0"))
        Next intNumConnect
        ' Customer type not selected by default on form load event
        radBusiness.Checked = False
        radResidential.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intNumPremuim As Integer
        Dim intNumConnect As Integer

        ' call data validate function
        Call Data_Validated_OK()
        If Data_Validated_OK() = False Then
            MessageBox.Show("Error")

            Exit Sub
        End If

        ' Business function fires if business radio button is checked
        If radBusiness.Checked = True Then
            lblTotalDue.Text = GetBusinessBill(intNumPremuim, intNumConnect).ToString("C2")

            ' Residential function fires off if residential radio button is checked
        ElseIf radResidential.Checked = True Then
            ' Connection listbox is set to zero because connections are not used in the calculation for residential customers
            lstConnect.SelectedIndex = 0
            lblTotalDue.Text = GetResidentBill(intNumPremuim, intNumConnect).ToString("C2")

        End If
    End Sub
End Class
