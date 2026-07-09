using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F950", Offset = "0x59F950")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F950", Offset = "0x59F950")]
	public class AnyKey : FsmStateAction
	{
		[Token(Token = "0x4004AE0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D83D4", Offset = "0x5D83D4")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4004AE1")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D840C", Offset = "0x5D840C")]
		public FsmEvent sendEvent;

		[Token(Token = "0x6006003")]
		[Address(RVA = "0xD47E04", Offset = "0xD47E04", VA = "0xD47E04", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006004")]
		[Address(RVA = "0xD47E0C", Offset = "0xD47E0C", VA = "0xD47E0C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006005")]
		[Address(RVA = "0xD47E54", Offset = "0xD47E54", VA = "0xD47E54")]
		public AnyKey()
		{
		}
	}
}
