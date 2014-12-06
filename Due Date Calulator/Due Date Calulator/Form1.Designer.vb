<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalcMD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalcMD))
        Me.btnCalDueDate = New System.Windows.Forms.Button()
        Me.gbLastMP = New System.Windows.Forms.GroupBox()
        Me.dtpLastMP = New System.Windows.Forms.DateTimePicker()
        Me.gbAppointment = New System.Windows.Forms.GroupBox()
        Me.dtpNextApp = New System.Windows.Forms.DateTimePicker()
        Me.lblDisplayoutput = New System.Windows.Forms.Label()
        Me.btnTXTOut = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnDueDate = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnOvulation = New System.Windows.Forms.ToolStripButton()
        Me.btnDueDate = New System.Windows.Forms.Button()
        Me.btnOvulation = New System.Windows.Forms.Button()
        Me.btnCalcOv = New System.Windows.Forms.Button()
        Me.gbFirstDayCycle = New System.Windows.Forms.GroupBox()
        Me.txtAvgLength = New System.Windows.Forms.TextBox()
        Me.lblOvDisplay = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbLastMP.SuspendLayout()
        Me.gbAppointment.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbFirstDayCycle.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalDueDate
        '
        Me.btnCalDueDate.Location = New System.Drawing.Point(11, 245)
        Me.btnCalDueDate.Name = "btnCalDueDate"
        Me.btnCalDueDate.Size = New System.Drawing.Size(216, 44)
        Me.btnCalDueDate.TabIndex = 0
        Me.btnCalDueDate.Text = "Calculate"
        Me.btnCalDueDate.UseVisualStyleBackColor = True
        '
        'gbLastMP
        '
        Me.gbLastMP.Controls.Add(Me.dtpLastMP)
        Me.gbLastMP.Location = New System.Drawing.Point(12, 27)
        Me.gbLastMP.Name = "gbLastMP"
        Me.gbLastMP.Size = New System.Drawing.Size(215, 60)
        Me.gbLastMP.TabIndex = 1
        Me.gbLastMP.TabStop = False
        Me.gbLastMP.Text = "Last Menstral Period"
        '
        'dtpLastMP
        '
        Me.dtpLastMP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLastMP.Location = New System.Drawing.Point(6, 24)
        Me.dtpLastMP.Name = "dtpLastMP"
        Me.dtpLastMP.Size = New System.Drawing.Size(200, 20)
        Me.dtpLastMP.TabIndex = 5
        Me.dtpLastMP.Value = New Date(2014, 9, 8, 0, 28, 39, 0)
        '
        'gbAppointment
        '
        Me.gbAppointment.Controls.Add(Me.dtpNextApp)
        Me.gbAppointment.Location = New System.Drawing.Point(233, 27)
        Me.gbAppointment.Name = "gbAppointment"
        Me.gbAppointment.Size = New System.Drawing.Size(214, 60)
        Me.gbAppointment.TabIndex = 2
        Me.gbAppointment.TabStop = False
        Me.gbAppointment.Text = "Appointment Date"
        '
        'dtpNextApp
        '
        Me.dtpNextApp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNextApp.Location = New System.Drawing.Point(7, 23)
        Me.dtpNextApp.Name = "dtpNextApp"
        Me.dtpNextApp.Size = New System.Drawing.Size(200, 20)
        Me.dtpNextApp.TabIndex = 0
        '
        'lblDisplayoutput
        '
        Me.lblDisplayoutput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDisplayoutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplayoutput.Location = New System.Drawing.Point(12, 90)
        Me.lblDisplayoutput.Name = "lblDisplayoutput"
        Me.lblDisplayoutput.Size = New System.Drawing.Size(435, 152)
        Me.lblDisplayoutput.TabIndex = 3
        '
        'btnTXTOut
        '
        Me.btnTXTOut.Location = New System.Drawing.Point(233, 246)
        Me.btnTXTOut.Name = "btnTXTOut"
        Me.btnTXTOut.Size = New System.Drawing.Size(214, 43)
        Me.btnTXTOut.TabIndex = 4
        Me.btnTXTOut.Text = "Print To Text File"
        Me.btnTXTOut.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnDueDate, Me.tsbtnOvulation})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(456, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnDueDate
        '
        Me.tsbtnDueDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDueDate.Image = CType(resources.GetObject("tsbtnDueDate.Image"), System.Drawing.Image)
        Me.tsbtnDueDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDueDate.Name = "tsbtnDueDate"
        Me.tsbtnDueDate.Size = New System.Drawing.Size(59, 22)
        Me.tsbtnDueDate.Text = "Due Date"
        '
        'tsbtnOvulation
        '
        Me.tsbtnOvulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnOvulation.Image = CType(resources.GetObject("tsbtnOvulation.Image"), System.Drawing.Image)
        Me.tsbtnOvulation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOvulation.Name = "tsbtnOvulation"
        Me.tsbtnOvulation.Size = New System.Drawing.Size(63, 22)
        Me.tsbtnOvulation.Text = "Ovulation"
        '
        'btnDueDate
        '
        Me.btnDueDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDueDate.Location = New System.Drawing.Point(0, 25)
        Me.btnDueDate.Name = "btnDueDate"
        Me.btnDueDate.Size = New System.Drawing.Size(456, 161)
        Me.btnDueDate.TabIndex = 9
        Me.btnDueDate.Text = "Calculate Due Date"
        Me.btnDueDate.UseVisualStyleBackColor = True
        '
        'btnOvulation
        '
        Me.btnOvulation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOvulation.Location = New System.Drawing.Point(0, 154)
        Me.btnOvulation.Name = "btnOvulation"
        Me.btnOvulation.Size = New System.Drawing.Size(456, 148)
        Me.btnOvulation.TabIndex = 10
        Me.btnOvulation.Text = "Calculate Ovulation"
        Me.btnOvulation.UseVisualStyleBackColor = True
        '
        'btnCalcOv
        '
        Me.btnCalcOv.Location = New System.Drawing.Point(12, 246)
        Me.btnCalcOv.Name = "btnCalcOv"
        Me.btnCalcOv.Size = New System.Drawing.Size(435, 44)
        Me.btnCalcOv.TabIndex = 11
        Me.btnCalcOv.Text = "Calculate"
        Me.btnCalcOv.UseVisualStyleBackColor = True
        '
        'gbFirstDayCycle
        '
        Me.gbFirstDayCycle.Controls.Add(Me.txtAvgLength)
        Me.gbFirstDayCycle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbFirstDayCycle.Location = New System.Drawing.Point(12, 28)
        Me.gbFirstDayCycle.Name = "gbFirstDayCycle"
        Me.gbFirstDayCycle.Size = New System.Drawing.Size(215, 199)
        Me.gbFirstDayCycle.TabIndex = 6
        Me.gbFirstDayCycle.TabStop = False
        Me.gbFirstDayCycle.Text = "Average Length of Cycle "
        '
        'txtAvgLength
        '
        Me.txtAvgLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 112.0!, System.Drawing.FontStyle.Bold)
        Me.txtAvgLength.Location = New System.Drawing.Point(6, 18)
        Me.txtAvgLength.Name = "txtAvgLength"
        Me.txtAvgLength.Size = New System.Drawing.Size(203, 177)
        Me.txtAvgLength.TabIndex = 0
        Me.txtAvgLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOvDisplay
        '
        Me.lblOvDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblOvDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOvDisplay.Location = New System.Drawing.Point(233, 28)
        Me.lblOvDisplay.Name = "lblOvDisplay"
        Me.lblOvDisplay.Size = New System.Drawing.Size(213, 199)
        Me.lblOvDisplay.TabIndex = 12
        '
        'CalcMD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 302)
        Me.Controls.Add(Me.lblOvDisplay)
        Me.Controls.Add(Me.gbFirstDayCycle)
        Me.Controls.Add(Me.btnCalcOv)
        Me.Controls.Add(Me.btnTXTOut)
        Me.Controls.Add(Me.lblDisplayoutput)
        Me.Controls.Add(Me.gbAppointment)
        Me.Controls.Add(Me.gbLastMP)
        Me.Controls.Add(Me.btnCalDueDate)
        Me.Controls.Add(Me.btnDueDate)
        Me.Controls.Add(Me.btnOvulation)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CalcMD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbLastMP.ResumeLayout(False)
        Me.gbAppointment.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbFirstDayCycle.ResumeLayout(False)
        Me.gbFirstDayCycle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalDueDate As System.Windows.Forms.Button
    Friend WithEvents gbLastMP As System.Windows.Forms.GroupBox
    Friend WithEvents gbAppointment As System.Windows.Forms.GroupBox
    Friend WithEvents lblDisplayoutput As System.Windows.Forms.Label
    Friend WithEvents dtpLastMP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNextApp As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTXTOut As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnDueDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnOvulation As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDueDate As System.Windows.Forms.Button
    Friend WithEvents btnOvulation As System.Windows.Forms.Button
    Friend WithEvents btnCalcOv As System.Windows.Forms.Button
    Friend WithEvents gbFirstDayCycle As System.Windows.Forms.GroupBox
    Friend WithEvents lblOvDisplay As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtAvgLength As System.Windows.Forms.TextBox

End Class
