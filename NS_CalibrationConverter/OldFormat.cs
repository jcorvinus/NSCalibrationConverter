using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS_CalibrationConverter
{
	[System.Serializable]
	public struct Vector3
	{
		public float x, y, z;
	}

	[System.Serializable]
	public struct Vector4
	{
		public float x, y, z, w;
	}

	[System.Serializable]
	public struct Quaternion
	{
		public float x, y, z, w;
	}

	[System.Serializable]
	public struct Matrix4x4
	{
		public float
			e00, e01, e02, e03,
			e10, e11, e12, e13,
			e20, e21, e22, e23,
			e30, e31, e32, e33;
	}

	[System.Serializable]
	public struct Pose
	{
		public Vector3 position;
		public Quaternion rotation;
	}

	[System.Serializable]
	public struct PhysicalComponent
	{
		public string name;
		public string serial;
		public Pose localPose;
		public PhysicalComponent(Pose localPose, string name = "", string serial = "")
		{
			this.name = name;
			this.serial = serial;
			this.localPose = localPose;
		}
	}

	[System.Serializable]
	public struct ReflectorOptics
	{
		public float ellipseMinorAxis;
		public float ellipseMajorAxis;
		public Vector3 screenForward;
		public Vector3 screenPosition;
		public Vector3 eyePosition;
		public Quaternion eyeRotation;
		public Vector4 cameraProjection;
		public Matrix4x4 sphereToWorldSpace;
		public Matrix4x4 worldToScreenSpace;
	}

	[System.Serializable]
	public struct HeadsetCalibration
	{
		public ReflectorOptics leftEye;
		public ReflectorOptics rightEye;
		public PhysicalComponent leapTracker;
	}
}
