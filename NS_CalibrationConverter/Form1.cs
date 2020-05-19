using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace NS_CalibrationConverter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// Click on the link below to continue learning how to build a desktop app using WinForms!
			System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

		}

		private void inputBrowseButton_Click(object sender, EventArgs e)
		{
			DialogResult result = importFileDialog.ShowDialog();
			originalPathBox.Text = importFileDialog.FileName;

			CheckValidity(true);
		}

		private void outputBrowse_Click(object sender, EventArgs e)
		{
			DialogResult result = exportFileDialog.ShowDialog();
			outputPathBox.Text = exportFileDialog.FileName;

			CheckValidity(true);
		}

		private void doConversion_Click(object sender, EventArgs e)
		{
			CheckValidity(true);

			if(doConversionButton.Enabled)
			{
				DoConversion(originalPathBox.Text, outputPathBox.Text);
			}
		}

		void DoConversion(string inputPath, string outputPath)
		{
			string inputFile = File.ReadAllText(inputPath);

			// convert to json
			HeadsetCalibration calibration = JsonConvert.DeserializeObject<HeadsetCalibration>(inputFile);

			EyeData leftEyeData = new EyeData()
			{
				ellipseMinorAxis = calibration.leftEye.ellipseMinorAxis,
				ellipseMajorAxis = calibration.leftEye.ellipseMajorAxis,
				screenForward_x = calibration.leftEye.screenForward.x,
				screenForward_y = calibration.leftEye.screenForward.y,
				screenForward_z = calibration.leftEye.screenForward.z,

				cameraProjection_w = calibration.leftEye.cameraProjection.w,
				cameraProjection_x = calibration.leftEye.cameraProjection.x,
				cameraProjection_y = calibration.leftEye.cameraProjection.y,
				cameraProjection_z = calibration.leftEye.cameraProjection.z,

				eyePosition_x = calibration.leftEye.eyePosition.x,
				eyePosition_y = calibration.leftEye.eyePosition.y,
				eyePosition_z = calibration.leftEye.eyePosition.z,

				eyeRotation_w = calibration.leftEye.eyeRotation.w,
				eyeRotation_x = calibration.leftEye.eyeRotation.x,
				eyeRotation_y = calibration.leftEye.eyeRotation.y,
				eyeRotation_z = calibration.leftEye.eyeRotation.z,

				screenPosition_x = calibration.leftEye.screenPosition.x,
				screenPosition_y = calibration.leftEye.screenPosition.y, 
				screenPosition_z = calibration.leftEye.screenPosition.z,

				sphereToWorldSpace_e00 = calibration.leftEye.sphereToWorldSpace.e00,
				sphereToWorldSpace_e01 = calibration.leftEye.sphereToWorldSpace.e01,
				sphereToWorldSpace_e02 = calibration.leftEye.sphereToWorldSpace.e02,
				sphereToWorldSpace_e03 = calibration.leftEye.sphereToWorldSpace.e03,

				sphereToWorldSpace_e10 = calibration.leftEye.sphereToWorldSpace.e10,
				sphereToWorldSpace_e11 = calibration.leftEye.sphereToWorldSpace.e11,
				sphereToWorldSpace_e12 = calibration.leftEye.sphereToWorldSpace.e12,
				sphereToWorldSpace_e13 = calibration.leftEye.sphereToWorldSpace.e13,

				sphereToWorldSpace_e20 = calibration.leftEye.sphereToWorldSpace.e20,
				sphereToWorldSpace_e21 = calibration.leftEye.sphereToWorldSpace.e21,
				sphereToWorldSpace_e22 = calibration.leftEye.sphereToWorldSpace.e22,
				sphereToWorldSpace_e23 = calibration.leftEye.sphereToWorldSpace.e23,

				sphereToWorldSpace_e30 = calibration.leftEye.sphereToWorldSpace.e30,
				sphereToWorldSpace_e31 = calibration.leftEye.sphereToWorldSpace.e31,
				sphereToWorldSpace_e32 = calibration.leftEye.sphereToWorldSpace.e32,
				sphereToWorldSpace_e33 = calibration.leftEye.sphereToWorldSpace.e33,



				worldToScreenSpace_e00 = calibration.leftEye.worldToScreenSpace.e00,
				worldToScreenSpace_e01 = calibration.leftEye.worldToScreenSpace.e01,
				worldToScreenSpace_e02 = calibration.leftEye.worldToScreenSpace.e02,
				worldToScreenSpace_e03 = calibration.leftEye.worldToScreenSpace.e03,

				worldToScreenSpace_e10 = calibration.leftEye.worldToScreenSpace.e10,
				worldToScreenSpace_e11 = calibration.leftEye.worldToScreenSpace.e11,
				worldToScreenSpace_e12 = calibration.leftEye.worldToScreenSpace.e12,
				worldToScreenSpace_e13 = calibration.leftEye.worldToScreenSpace.e13,

				worldToScreenSpace_e20 = calibration.leftEye.worldToScreenSpace.e20,
				worldToScreenSpace_e21 = calibration.leftEye.worldToScreenSpace.e21,
				worldToScreenSpace_e22 = calibration.leftEye.worldToScreenSpace.e22,
				worldToScreenSpace_e23 = calibration.leftEye.worldToScreenSpace.e23,

				worldToScreenSpace_e30 = calibration.leftEye.worldToScreenSpace.e30,
				worldToScreenSpace_e31 = calibration.leftEye.worldToScreenSpace.e31,
				worldToScreenSpace_e32 = calibration.leftEye.worldToScreenSpace.e32,
				worldToScreenSpace_e33 = calibration.leftEye.worldToScreenSpace.e33				
			};

			EyeData rightEyeData = new EyeData()
			{
				ellipseMinorAxis = calibration.rightEye.ellipseMinorAxis,
				ellipseMajorAxis = calibration.rightEye.ellipseMajorAxis,
				screenForward_x = calibration.rightEye.screenForward.x,
				screenForward_y = calibration.rightEye.screenForward.y,
				screenForward_z = calibration.rightEye.screenForward.z,

				cameraProjection_w = calibration.rightEye.cameraProjection.w,
				cameraProjection_x = calibration.rightEye.cameraProjection.x,
				cameraProjection_y = calibration.rightEye.cameraProjection.y,
				cameraProjection_z = calibration.rightEye.cameraProjection.z,

				eyePosition_x = calibration.rightEye.eyePosition.x,
				eyePosition_y = calibration.rightEye.eyePosition.y,
				eyePosition_z = calibration.rightEye.eyePosition.z,

				eyeRotation_w = calibration.rightEye.eyeRotation.w,
				eyeRotation_x = calibration.rightEye.eyeRotation.x,
				eyeRotation_y = calibration.rightEye.eyeRotation.y,
				eyeRotation_z = calibration.rightEye.eyeRotation.z,

				screenPosition_x = calibration.rightEye.screenPosition.x,
				screenPosition_y = calibration.rightEye.screenPosition.y,
				screenPosition_z = calibration.rightEye.screenPosition.z,

				sphereToWorldSpace_e00 = calibration.rightEye.sphereToWorldSpace.e00,
				sphereToWorldSpace_e01 = calibration.rightEye.sphereToWorldSpace.e01,
				sphereToWorldSpace_e02 = calibration.rightEye.sphereToWorldSpace.e02,
				sphereToWorldSpace_e03 = calibration.rightEye.sphereToWorldSpace.e03,

				sphereToWorldSpace_e10 = calibration.rightEye.sphereToWorldSpace.e10,
				sphereToWorldSpace_e11 = calibration.rightEye.sphereToWorldSpace.e11,
				sphereToWorldSpace_e12 = calibration.rightEye.sphereToWorldSpace.e12,
				sphereToWorldSpace_e13 = calibration.rightEye.sphereToWorldSpace.e13,

				sphereToWorldSpace_e20 = calibration.rightEye.sphereToWorldSpace.e20,
				sphereToWorldSpace_e21 = calibration.rightEye.sphereToWorldSpace.e21,
				sphereToWorldSpace_e22 = calibration.rightEye.sphereToWorldSpace.e22,
				sphereToWorldSpace_e23 = calibration.rightEye.sphereToWorldSpace.e23,

				sphereToWorldSpace_e30 = calibration.rightEye.sphereToWorldSpace.e30,
				sphereToWorldSpace_e31 = calibration.rightEye.sphereToWorldSpace.e31,
				sphereToWorldSpace_e32 = calibration.rightEye.sphereToWorldSpace.e32,
				sphereToWorldSpace_e33 = calibration.rightEye.sphereToWorldSpace.e33,



				worldToScreenSpace_e00 = calibration.rightEye.worldToScreenSpace.e00,
				worldToScreenSpace_e01 = calibration.rightEye.worldToScreenSpace.e01,
				worldToScreenSpace_e02 = calibration.rightEye.worldToScreenSpace.e02,
				worldToScreenSpace_e03 = calibration.rightEye.worldToScreenSpace.e03,

				worldToScreenSpace_e10 = calibration.rightEye.worldToScreenSpace.e10,
				worldToScreenSpace_e11 = calibration.rightEye.worldToScreenSpace.e11,
				worldToScreenSpace_e12 = calibration.rightEye.worldToScreenSpace.e12,
				worldToScreenSpace_e13 = calibration.rightEye.worldToScreenSpace.e13,

				worldToScreenSpace_e20 = calibration.rightEye.worldToScreenSpace.e20,
				worldToScreenSpace_e21 = calibration.rightEye.worldToScreenSpace.e21,
				worldToScreenSpace_e22 = calibration.rightEye.worldToScreenSpace.e22,
				worldToScreenSpace_e23 = calibration.rightEye.worldToScreenSpace.e23,

				worldToScreenSpace_e30 = calibration.rightEye.worldToScreenSpace.e30,
				worldToScreenSpace_e31 = calibration.rightEye.worldToScreenSpace.e31,
				worldToScreenSpace_e32 = calibration.rightEye.worldToScreenSpace.e32,
				worldToScreenSpace_e33 = calibration.rightEye.worldToScreenSpace.e33
			};

			NewFormatCalibrationData newCalibrationData = new NewFormatCalibrationData()
			{
				leftEye = leftEyeData,
				rightEye = rightEyeData
			};

			// save the file
			string output = JsonConvert.SerializeObject(newCalibrationData);
			File.WriteAllText(outputPath, output);

			MessageBox.Show("Export complete!");

			string directory = Path.GetDirectoryName(outputPathBox.Text);
			System.Diagnostics.Process.Start(directory);
		}

		void CheckValidity(bool showMsg)
		{
			// check our input path
			// check argument exception on path
			if (File.Exists(originalPathBox.Text))
			{
				doConversionButton.Enabled = true;
			}
			else
			{
				if(showMsg) MessageBox.Show("Could not find file: " + originalPathBox.Text);
				doConversionButton.Enabled = false;
				return;
			}

			// check our output path
			// get directory from output path
			// check argument exception on path
			if (outputPathBox.Text.Length > 0)
			{
				string directory = Path.GetDirectoryName(outputPathBox.Text);
				if (Directory.Exists(directory))
				{
					// does it exist?
					// do we have permission to save?
					doConversionButton.Enabled = true;
					return;
				}
				else
				{
					if (showMsg) MessageBox.Show("Output directory: " + directory + " could not be found");
					doConversionButton.Enabled = false;
					return;
				}
			}
			else
			{
				doConversionButton.Enabled = false;
				return;
			}
		}

		private void originalPathBox_TextChanged(object sender, EventArgs e)
		{
			CheckValidity(false);
		}
	}
}
