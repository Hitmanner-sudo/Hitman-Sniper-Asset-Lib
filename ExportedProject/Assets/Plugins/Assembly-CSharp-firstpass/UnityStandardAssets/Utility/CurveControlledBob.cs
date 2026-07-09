using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public class CurveControlledBob
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10DF43C", Offset = "0x10DF43C", VA = "0x10DF43C")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10DF4E0", Offset = "0x10DF4E0", VA = "0x10DF4E0")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10DF5DC", Offset = "0x10DF5DC", VA = "0x10DF5DC")]
		public CurveControlledBob()
		{
		}
	}
}
