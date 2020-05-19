using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS_CalibrationConverter
{
	[System.Serializable]
	public struct EyeData
	{
		public float ellipseMinorAxis;
		public float ellipseMajorAxis;

		public float screenForward_x, screenForward_y, screenForward_z;
		public float screenPosition_x, screenPosition_y, screenPosition_z;
		public float eyePosition_x, eyePosition_y, eyePosition_z;
		public float eyeRotation_x, eyeRotation_y, eyeRotation_z, eyeRotation_w;

		public float cameraProjection_x, cameraProjection_y, cameraProjection_z, cameraProjection_w;

		public float
			sphereToWorldSpace_e00, sphereToWorldSpace_e01, sphereToWorldSpace_e02, sphereToWorldSpace_e03,
			sphereToWorldSpace_e10, sphereToWorldSpace_e11, sphereToWorldSpace_e12, sphereToWorldSpace_e13,
			sphereToWorldSpace_e20, sphereToWorldSpace_e21, sphereToWorldSpace_e22, sphereToWorldSpace_e23,
			sphereToWorldSpace_e30, sphereToWorldSpace_e31, sphereToWorldSpace_e32, sphereToWorldSpace_e33;

		public float
			worldToScreenSpace_e00, worldToScreenSpace_e01, worldToScreenSpace_e02, worldToScreenSpace_e03,
			worldToScreenSpace_e10, worldToScreenSpace_e11, worldToScreenSpace_e12, worldToScreenSpace_e13,
			worldToScreenSpace_e20, worldToScreenSpace_e21, worldToScreenSpace_e22, worldToScreenSpace_e23,
			worldToScreenSpace_e30, worldToScreenSpace_e31, worldToScreenSpace_e32, worldToScreenSpace_e33;
	}

	[System.Serializable]
	public struct NewFormatCalibrationData
	{
		public EyeData leftEye;
		public EyeData rightEye;
	}
}
