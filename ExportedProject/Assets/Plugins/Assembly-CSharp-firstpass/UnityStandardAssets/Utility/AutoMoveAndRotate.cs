using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000021")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000022")]
		public class Vector3andSpace
		{
			[Token(Token = "0x40000B4")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x40000B5")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x18BEFB8", Offset = "0x18BEFB8", VA = "0x18BEFB8")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x10DC538", Offset = "0x10DC538", VA = "0x10DC538")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x10DC560", Offset = "0x10DC560", VA = "0x10DC560")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x10DC630", Offset = "0x10DC630", VA = "0x10DC630")]
		public AutoMoveAndRotate()
		{
		}
	}
}
