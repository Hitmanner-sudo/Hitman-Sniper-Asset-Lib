using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FDB8", Offset = "0x59FDB8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FDB8", Offset = "0x59FDB8")]
	public class GetMouseY : FsmStateAction
	{
		[Token(Token = "0x4004B12")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D906C", Offset = "0x5D906C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D906C", Offset = "0x5D906C")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004B13")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D90CC", Offset = "0x5D90CC")]
		public bool normalize;

		[Token(Token = "0x4004B14")]
		[FieldOffset(Offset = "0x59")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9104", Offset = "0x5D9104")]
		public bool everyFrame;

		[Token(Token = "0x6006038")]
		[Address(RVA = "0x1064B5C", Offset = "0x1064B5C", VA = "0x1064B5C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006039")]
		[Address(RVA = "0x1064B6C", Offset = "0x1064B6C", VA = "0x1064B6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600603A")]
		[Address(RVA = "0x1064C08", Offset = "0x1064C08", VA = "0x1064C08", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600603B")]
		[Address(RVA = "0x1064BA8", Offset = "0x1064BA8", VA = "0x1064BA8")]
		private void DoGetMouseY()
		{
		}

		[Token(Token = "0x600603C")]
		[Address(RVA = "0x1064C0C", Offset = "0x1064C0C", VA = "0x1064C0C")]
		public GetMouseY()
		{
		}
	}
}
