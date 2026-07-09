using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F7E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D498", Offset = "0x59D498")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D498", Offset = "0x59D498")]
	public class GetIPhoneSettings : FsmStateAction
	{
		[Token(Token = "0x4004909")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D12A4", Offset = "0x5D12A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D12A4", Offset = "0x5D12A4")]
		public FsmBool getScreenCanDarken;

		[Token(Token = "0x400490A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D12F4", Offset = "0x5D12F4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D12F4", Offset = "0x5D12F4")]
		public FsmString getUniqueIdentifier;

		[Token(Token = "0x400490B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1344", Offset = "0x5D1344")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1344", Offset = "0x5D1344")]
		public FsmString getName;

		[Token(Token = "0x400490C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1394", Offset = "0x5D1394")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1394", Offset = "0x5D1394")]
		public FsmString getModel;

		[Token(Token = "0x400490D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D13E4", Offset = "0x5D13E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D13E4", Offset = "0x5D13E4")]
		public FsmString getSystemName;

		[Token(Token = "0x400490E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1434", Offset = "0x5D1434")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1434", Offset = "0x5D1434")]
		public FsmString getGeneration;

		[Token(Token = "0x6005E61")]
		[Address(RVA = "0x1063834", Offset = "0x1063834", VA = "0x1063834", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E62")]
		[Address(RVA = "0x1063844", Offset = "0x1063844", VA = "0x1063844", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E63")]
		[Address(RVA = "0x106384C", Offset = "0x106384C", VA = "0x106384C")]
		public GetIPhoneSettings()
		{
		}
	}
}
