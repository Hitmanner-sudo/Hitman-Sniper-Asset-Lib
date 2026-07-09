using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F77")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D2B8", Offset = "0x59D2B8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D2B8", Offset = "0x59D2B8")]
	public class DeviceOrientationEvent : FsmStateAction
	{
		[Token(Token = "0x40048F0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0D7C", Offset = "0x5D0D7C")]
		public DeviceOrientation orientation;

		[Token(Token = "0x40048F1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0DB4", Offset = "0x5D0DB4")]
		public FsmEvent sendEvent;

		[Token(Token = "0x40048F2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0DEC", Offset = "0x5D0DEC")]
		public bool everyFrame;

		[Token(Token = "0x6005E49")]
		[Address(RVA = "0xC14164", Offset = "0xC14164", VA = "0xC14164", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xC14178", Offset = "0xC14178", VA = "0xC14178", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0xC14204", Offset = "0xC14204", VA = "0xC14204", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0xC141B4", Offset = "0xC141B4", VA = "0xC141B4")]
		private void DoDetectDeviceOrientation()
		{
		}

		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xC14208", Offset = "0xC14208", VA = "0xC14208")]
		public DeviceOrientationEvent()
		{
		}
	}
}
