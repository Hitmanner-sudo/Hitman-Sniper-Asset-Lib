using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F7B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D3F8", Offset = "0x59D3F8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D3F8", Offset = "0x59D3F8")]
	public class GetDeviceAcceleration : FsmStateAction
	{
		[Token(Token = "0x40048F9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0FC4", Offset = "0x5D0FC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0FC4", Offset = "0x5D0FC4")]
		public FsmVector3 storeVector;

		[Token(Token = "0x40048FA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1014", Offset = "0x5D1014")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1014", Offset = "0x5D1014")]
		public FsmFloat storeX;

		[Token(Token = "0x40048FB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D1064", Offset = "0x5D1064")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1064", Offset = "0x5D1064")]
		public FsmFloat storeY;

		[Token(Token = "0x40048FC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D10B4", Offset = "0x5D10B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D10B4", Offset = "0x5D10B4")]
		public FsmFloat storeZ;

		[Token(Token = "0x40048FD")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D1104", Offset = "0x5D1104")]
		public FsmFloat multiplier;

		[Token(Token = "0x40048FE")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D113C", Offset = "0x5D113C")]
		public bool everyFrame;

		[Token(Token = "0x6005E57")]
		[Address(RVA = "0x105F1E8", Offset = "0x105F1E8", VA = "0x105F1E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E58")]
		[Address(RVA = "0x105F220", Offset = "0x105F220", VA = "0x105F220", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x105F304", Offset = "0x105F304", VA = "0x105F304", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0x105F25C", Offset = "0x105F25C", VA = "0x105F25C")]
		private void DoGetDeviceAcceleration()
		{
		}

		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0x105F308", Offset = "0x105F308", VA = "0x105F308")]
		public GetDeviceAcceleration()
		{
		}
	}
}
