using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000023")]
	public class CameraRefocus
	{
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10DD03C", Offset = "0x10DD03C", VA = "0x10DD03C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10DD09C", Offset = "0x10DD09C", VA = "0x10DD09C")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10DD0A4", Offset = "0x10DD0A4", VA = "0x10DD0A4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10DD0AC", Offset = "0x10DD0AC", VA = "0x10DD0AC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10DD1A8", Offset = "0x10DD1A8", VA = "0x10DD1A8")]
		public void SetFocusPoint()
		{
		}
	}
}
