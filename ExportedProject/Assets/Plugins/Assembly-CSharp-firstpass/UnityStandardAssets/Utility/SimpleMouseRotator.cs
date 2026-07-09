using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000036")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10F1778", Offset = "0x10F1778", VA = "0x10F1778")]
		private void Start()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10F17B4", Offset = "0x10F17B4", VA = "0x10F17B4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10F1A84", Offset = "0x10F1A84", VA = "0x10F1A84")]
		public SimpleMouseRotator()
		{
		}
	}
}
