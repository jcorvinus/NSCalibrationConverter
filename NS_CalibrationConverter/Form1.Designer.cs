namespace NS_CalibrationConverter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.conversionInstructionsLabel = new System.Windows.Forms.Label();
			this.doConversionButton = new System.Windows.Forms.Button();
			this.helloWorldLabel = new System.Windows.Forms.Label();
			this.originalPathBox = new System.Windows.Forms.TextBox();
			this.inputLabel = new System.Windows.Forms.Label();
			this.inputBrowseButton = new System.Windows.Forms.Button();
			this.outputLabel = new System.Windows.Forms.Label();
			this.outputPathBox = new System.Windows.Forms.TextBox();
			this.outputBrowse = new System.Windows.Forms.Button();
			this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.exportFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// conversionInstructionsLabel
			// 
			this.conversionInstructionsLabel.AutoSize = true;
			this.conversionInstructionsLabel.Location = new System.Drawing.Point(13, 35);
			this.conversionInstructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.conversionInstructionsLabel.Name = "conversionInstructionsLabel";
			this.conversionInstructionsLabel.Size = new System.Drawing.Size(487, 13);
			this.conversionInstructionsLabel.TabIndex = 1;
			this.conversionInstructionsLabel.Text = "This program converts a North Star calibration file from the old launcher format " +
    "to the new driver format";
			// 
			// doConversionButton
			// 
			this.doConversionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.doConversionButton.Enabled = false;
			this.doConversionButton.Location = new System.Drawing.Point(220, 253);
			this.doConversionButton.Margin = new System.Windows.Forms.Padding(2);
			this.doConversionButton.Name = "doConversionButton";
			this.doConversionButton.Size = new System.Drawing.Size(97, 28);
			this.doConversionButton.TabIndex = 2;
			this.doConversionButton.Text = "Do Conversion";
			this.doConversionButton.UseVisualStyleBackColor = true;
			this.doConversionButton.Click += new System.EventHandler(this.doConversion_Click);
			// 
			// helloWorldLabel
			// 
			this.helloWorldLabel.AutoSize = true;
			this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.helloWorldLabel.Location = new System.Drawing.Point(11, 9);
			this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.helloWorldLabel.Name = "helloWorldLabel";
			this.helloWorldLabel.Size = new System.Drawing.Size(217, 26);
			this.helloWorldLabel.TabIndex = 3;
			this.helloWorldLabel.Text = "Calibration Converter";
			// 
			// originalPathBox
			// 
			this.originalPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.originalPathBox.Location = new System.Drawing.Point(16, 83);
			this.originalPathBox.Name = "originalPathBox";
			this.originalPathBox.Size = new System.Drawing.Size(424, 20);
			this.originalPathBox.TabIndex = 4;
			this.originalPathBox.TextChanged += new System.EventHandler(this.originalPathBox_TextChanged);
			// 
			// inputLabel
			// 
			this.inputLabel.AutoSize = true;
			this.inputLabel.Location = new System.Drawing.Point(12, 67);
			this.inputLabel.Name = "inputLabel";
			this.inputLabel.Size = new System.Drawing.Size(103, 13);
			this.inputLabel.TabIndex = 5;
			this.inputLabel.Text = "input calibration json";
			// 
			// inputBrowseButton
			// 
			this.inputBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.inputBrowseButton.Location = new System.Drawing.Point(446, 82);
			this.inputBrowseButton.Name = "inputBrowseButton";
			this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.inputBrowseButton.TabIndex = 6;
			this.inputBrowseButton.Text = "browse";
			this.inputBrowseButton.UseVisualStyleBackColor = true;
			this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
			// 
			// outputLabel
			// 
			this.outputLabel.AutoSize = true;
			this.outputLabel.Location = new System.Drawing.Point(12, 130);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(59, 13);
			this.outputLabel.TabIndex = 7;
			this.outputLabel.Text = "output json";
			// 
			// outputPathBox
			// 
			this.outputPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.outputPathBox.Location = new System.Drawing.Point(16, 147);
			this.outputPathBox.Name = "outputPathBox";
			this.outputPathBox.Size = new System.Drawing.Size(424, 20);
			this.outputPathBox.TabIndex = 8;
			// 
			// outputBrowse
			// 
			this.outputBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.outputBrowse.Location = new System.Drawing.Point(446, 145);
			this.outputBrowse.Name = "outputBrowse";
			this.outputBrowse.Size = new System.Drawing.Size(75, 23);
			this.outputBrowse.TabIndex = 9;
			this.outputBrowse.Text = "browse";
			this.outputBrowse.UseVisualStyleBackColor = true;
			this.outputBrowse.Click += new System.EventHandler(this.outputBrowse_Click);
			// 
			// importFileDialog
			// 
			this.importFileDialog.DefaultExt = "json";
			this.importFileDialog.FileName = "calibration.json";
			this.importFileDialog.Filter = "JSON files|*.json";
			// 
			// exportFileDialog
			// 
			this.exportFileDialog.DefaultExt = "json";
			this.exportFileDialog.FileName = "calibration-export";
			this.exportFileDialog.Filter = "JSON Files|*.json";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 292);
			this.Controls.Add(this.outputBrowse);
			this.Controls.Add(this.outputPathBox);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.inputBrowseButton);
			this.Controls.Add(this.inputLabel);
			this.Controls.Add(this.originalPathBox);
			this.Controls.Add(this.helloWorldLabel);
			this.Controls.Add(this.doConversionButton);
			this.Controls.Add(this.conversionInstructionsLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "North Star Calibration Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label conversionInstructionsLabel;
		private System.Windows.Forms.Button doConversionButton;
		private System.Windows.Forms.Label helloWorldLabel;
		private System.Windows.Forms.TextBox originalPathBox;
		private System.Windows.Forms.Label inputLabel;
		private System.Windows.Forms.Button inputBrowseButton;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.TextBox outputPathBox;
		private System.Windows.Forms.Button outputBrowse;
		private System.Windows.Forms.OpenFileDialog importFileDialog;
		private System.Windows.Forms.SaveFileDialog exportFileDialog;
	}
}

