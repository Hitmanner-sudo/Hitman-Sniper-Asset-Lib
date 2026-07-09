using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F79")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D358", Offset = "0x59D358")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D358", Offset = "0x59D358")]
	public class DeviceShakeEvent : FsmStateAction
	{
		[Token(Token = "0x40048F7")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0F2C", Offset = "0x5D0F2C")]
		public FsmFloat shakeThreshold;

		[Token(Token = "0x40048F8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0F78", Offset = "0x5D0F78")]
		[RequiredField]
		public FsmEvent sendEvent;

		[Token(Token = "0x6005E51")]
		[Address(RVA = "0xC142D4", Offset = "0xC142D4", VA = "0xC142D4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E52")]
		[Address(RVA = "0xC14300", Offset = "0xC14300", VA = "0xC14300", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E53")]
		[Address(RVA = "0xC14394", Offset = "0xC14394", VA = "0xC14394")]
		public DeviceShakeEvent()
		{
		}
	}
}
