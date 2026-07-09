using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001175")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A7B7C", Offset = "0x5A7B7C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A7B7C", Offset = "0x5A7B7C")]
	public class SequenceEvent : FsmStateAction
	{
		[Token(Token = "0x40052E4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F8598", Offset = "0x5F8598")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8598", Offset = "0x5F8598")]
		public FsmFloat delay;

		[Token(Token = "0x40052E5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F85EC", Offset = "0x5F85EC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F85EC", Offset = "0x5F85EC")]
		public FsmBool reset;

		[Token(Token = "0x40052E6")]
		[FieldOffset(Offset = "0x60")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x40052E7")]
		[FieldOffset(Offset = "0x68")]
		private int eventIndex;

		[Token(Token = "0x600670D")]
		[Address(RVA = "0xB721E8", Offset = "0xB721E8", VA = "0xB721E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600670E")]
		[Address(RVA = "0xB721F0", Offset = "0xB721F0", VA = "0xB721F0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600670F")]
		[Address(RVA = "0xB72304", Offset = "0xB72304", VA = "0xB72304", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006710")]
		[Address(RVA = "0xB72344", Offset = "0xB72344", VA = "0xB72344")]
		public SequenceEvent()
		{
		}
	}
}
