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
		BtnShow = New Button()
		SuspendLayout()
		' 
		' BtnShow
		' 
		BtnShow.Location = New Point(237, 147)
		BtnShow.Name = "BtnShow"
		BtnShow.Size = New Size(112, 34)
		BtnShow.TabIndex = 0
		BtnShow.Text = "Button1"
		BtnShow.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(BtnShow)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
	End Sub

	Friend WithEvents BtnShow As Button
End Class
