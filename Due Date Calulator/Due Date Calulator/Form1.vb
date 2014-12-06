Imports System.Globalization
Public Class CalcMD

    'Author : David Otero
    'Product Discription : This woman's health calculator is a high fidelity prototype
    'This prototype is close enough to the final product, in terms of detail and functionality
    'Examining usability functionality is built in

    Dim todaysDate As String = String.Format("{0:dd-MM-yyyy}", DateTime.Now)

    'Testing File creation 

    Dim csvFile As String = My.Application.Info.DirectoryPath & "\004 Test Results " + todaysDate + ".csv"
    'Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)
        'Form load time stamp to csv file
        outFile.WriteLine("TEST 5")
        outFile.WriteLine("Form Loaded" + "," + TimeOfDay)
        outFile.Close()

        ' on form load and interface elements are disabled
        ToolStrip1.Visible = False
        tsbtnDueDate.Visible = False
        tsbtnOvulation.Visible = False
        gbLastMP.Visible = False
        gbAppointment.Visible = False
        dtpLastMP.Visible = False
        dtpNextApp.Visible = False
        lblDisplayoutput.Visible = False
        btnCalDueDate.Visible = False
        btnTXTOut.Visible = False
        btnCalcOv.Visible = False
        gbFirstDayCycle.Visible = False
        txtAvgLength.Visible = False
        lblOvDisplay.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalDueDate.Click
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)
        'time stamp to csv file
        outFile.WriteLine("btnCalDueDate" + "," + TimeOfDay)
        outFile.Close()

        Dim CurrentDay As Date
        Dim birthday As Date
        Dim Weeks As Double
        Dim days As String
        Dim test As Integer


        CurrentDay = dtpLastMP.Value.ToShortDateString
        birthday = dtpLastMP.Value.AddDays(280).ToShortDateString
        days = dtpNextApp.Value.Date.Subtract _
            (dtpLastMP.Value.Date).Days

        'week conversion
        Weeks = CDbl(days / 7)
        Weeks.ToString("F2", CultureInfo.InvariantCulture)

        'one day is 0.142857 of a week

        'whole number weeks with days conversion 
        If (Integer.TryParse(Weeks, test)) Then
            lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks."
        Else

            'week & 1 day
            Weeks = (CDbl(days / 7) - 0.14285714285714285)
            If (Integer.TryParse(Weeks, test)) Then
                lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 1 day"
            Else

                'week & 2 day
                Weeks = (CDbl(days / 7) - 0.2857142857142857)
                If (Integer.TryParse(Weeks, test)) Then
                    lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 2 days"
                Else

                    'week & 3 day
                    Weeks = (CDbl(days / 7) - 0.42857142857142855)
                    If (Integer.TryParse(Weeks, test)) Then
                        lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 3 days"
                    Else

                        'week & 4 day
                        Weeks = (CDbl(days / 7) - 0.5714285714285714)
                        If (Integer.TryParse(Weeks, test)) Then
                            lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 4 days"
                        Else

                            'week & 5 day
                            Weeks = (CDbl(days / 7) - 0.7142857142857143)
                            If (Integer.TryParse(Weeks, test)) Then
                                lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 5 days"
                            Else

                                'week & 6 day
                                Weeks = (CDbl(days / 7) - 0.8571428571428571)
                                If (Integer.TryParse(Weeks, test)) Then
                                    lblDisplayoutput.Text = "Your due date is approximately: " + birthday & Environment.NewLine & "You have been prego for " + CStr(Weeks) + " weeks and 6 days"

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbtnDueDate.Click

        tsbtnDueDate.BackColor = Color.Azure
        'Form interface change
        gbLastMP.Visible = True
        gbAppointment.Visible = True
        dtpLastMP.Visible = True
        dtpNextApp.Visible = True
        lblDisplayoutput.Visible = True
        btnCalDueDate.Visible = True
        btnTXTOut.Visible = True
        btnCalcOv.Visible = False
        gbFirstDayCycle.Visible = False
        txtAvgLength.Visible = False
        lblOvDisplay.Visible = False
    End Sub

    Private Sub btnPDFOut_Click(sender As Object, e As EventArgs) Handles btnTXTOut.Click
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)
        'time stamp to csv file
        outFile.WriteLine("btnTXTOut" + "," + TimeOfDay)
        outFile.Close()

        'output the data to txt file
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Appointment.txt"
        Dim writer As New System.IO.StreamWriter(path, True)
        writer.WriteLine(lblDisplayoutput.Text)
        writer.Close()

        Dim msg = "File has been saved to the MyDocuments Folder"
        Dim style = MsgBoxStyle.OkOnly

        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg, style)

        lblDisplayoutput.Text = ""

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDueDate.Click

        'Form interface change
        ToolStrip1.Visible = True
        tsbtnDueDate.Visible = True
        tsbtnOvulation.Visible = True
        gbLastMP.Visible = True
        gbAppointment.Visible = True
        dtpLastMP.Visible = True
        dtpNextApp.Visible = True
        lblDisplayoutput.Visible = True
        btnCalDueDate.Visible = True
        btnTXTOut.Visible = True
        btnDueDate.Visible = False
        btnOvulation.Visible = False
        btnCalcOv.Visible = False
        gbFirstDayCycle.Visible = False
        txtAvgLength.Visible = False
        lblOvDisplay.Visible = False

    End Sub

    Private Sub btnOvulation_Click(sender As Object, e As EventArgs) Handles btnOvulation.Click

        'Form interface change
        btnDueDate.Visible = False
        btnOvulation.Visible = False
        gbLastMP.Visible = False
        gbAppointment.Visible = False
        dtpLastMP.Visible = False
        dtpNextApp.Visible = False
        lblDisplayoutput.Visible = False
        btnCalDueDate.Visible = False
        btnTXTOut.Visible = False

        ToolStrip1.Visible = True
        tsbtnDueDate.Visible = True
        tsbtnOvulation.Visible = True
        btnCalcOv.Visible = True
        gbFirstDayCycle.Visible = True
        txtAvgLength.Visible = True
        lblOvDisplay.Visible = True

    End Sub

    Private Sub tsbtnOvulation_Click(sender As Object, e As EventArgs) Handles tsbtnOvulation.Click

        tsbtnOvulation.BackColor = Color.Azure

        'Form interface change
        btnDueDate.Visible = False
        btnOvulation.Visible = False
        gbLastMP.Visible = False
        gbAppointment.Visible = False
        dtpLastMP.Visible = False
        dtpNextApp.Visible = False
        lblDisplayoutput.Visible = False
        btnCalDueDate.Visible = False
        btnTXTOut.Visible = False

        ToolStrip1.Visible = True
        tsbtnDueDate.Visible = True
        tsbtnOvulation.Visible = True
        btnCalcOv.Visible = True
        gbFirstDayCycle.Visible = True
        txtAvgLength.Visible = True
        lblOvDisplay.Visible = True

    End Sub

    Private Sub btnCalcOv_Click(sender As Object, e As EventArgs) Handles btnCalcOv.Click
        Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, True)
        'time stamp to csv file
        outFile.WriteLine("btnCalcOv" + "," + TimeOfDay)
        outFile.Close()

        If String.IsNullOrEmpty(txtAvgLength.Text) Then
            'do nothing if input is empty
        Else

            Dim AvgCycle As Integer = txtAvgLength.Text
            Dim FollicularPhase As Integer = 14
            Dim Ovulation As Integer


            If AvgCycle <= 20 Or AvgCycle >= 38 Then
                Dim msg = "A normal menstrual cycle lasts for 22 to 36 days contact a Medical Professional if you are outside of those bounds"
                Dim style = MsgBoxStyle.OkOnly

                ' Display the message box and save the response, Yes or No. 
                Dim response = MsgBox(msg, style)

                txtAvgLength.Text = ""

            Else
                Ovulation = AvgCycle - FollicularPhase

                lblOvDisplay.Text = "Your day of ovulation is aproxamately within " + CStr(Ovulation) + " plus and minus 1 days of your cycle start day"
            End If
        End If
    End Sub

End Class
