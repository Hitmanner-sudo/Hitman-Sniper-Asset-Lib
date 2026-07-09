using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200005C")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		public enum AxisOptions
		{
			[Token(Token = "0x40001B7")]
			ForwardAxis = 0,
			[Token(Token = "0x40001B8")]
			SidewaysAxis = 1
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class AxisMapping
		{
			[Token(Token = "0x200005F")]
			public enum MappingType
			{
				[Token(Token = "0x40001BC")]
				NamedAxis = 0,
				[Token(Token = "0x40001BD")]
				MousePositionX = 1,
				[Token(Token = "0x40001BE")]
				MousePositionY = 2,
				[Token(Token = "0x40001BF")]
				MousePositionZ = 3
			}

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x18C0D7C", Offset = "0x18C0D7C", VA = "0x18C0D7C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x18BB784", Offset = "0x18BB784", VA = "0x18BB784")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x18BB884", Offset = "0x18BB884", VA = "0x18BB884")]
		private void Update()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x18BBAAC", Offset = "0x18BBAAC", VA = "0x18BBAAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x18BBB2C", Offset = "0x18BBB2C", VA = "0x18BBB2C")]
		public TiltInput()
		{
		}
	}
}
