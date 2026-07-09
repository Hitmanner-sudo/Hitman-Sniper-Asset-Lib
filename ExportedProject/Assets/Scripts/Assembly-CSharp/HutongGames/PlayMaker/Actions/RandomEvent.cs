using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200116E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A788C", Offset = "0x5A788C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A788C", Offset = "0x5A788C")]
	public class RandomEvent : FsmStateAction
	{
		[Token(Token = "0x40052C5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F7FB0", Offset = "0x5F7FB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F7FB0", Offset = "0x5F7FB0")]
		public FsmFloat delay;

		[Token(Token = "0x40052C6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F8004", Offset = "0x5F8004")]
		public FsmBool noRepeat;

		[Token(Token = "0x40052C7")]
		[FieldOffset(Offset = "0x60")]
		private DelayedEvent delayedEvent;

		[Token(Token = "0x40052C8")]
		[FieldOffset(Offset = "0x68")]
		private int randomEventIndex;

		[Token(Token = "0x40052C9")]
		[FieldOffset(Offset = "0x6C")]
		private int lastEventIndex;

		[Token(Token = "0x60066D7")]
		[Address(RVA = "0xB3E280", Offset = "0xB3E280", VA = "0xB3E280", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60066D8")]
		[Address(RVA = "0xB3E2B0", Offset = "0xB3E2B0", VA = "0xB3E2B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60066D9")]
		[Address(RVA = "0xB3E46C", Offset = "0xB3E46C", VA = "0xB3E46C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60066DA")]
		[Address(RVA = "0xB3E3A0", Offset = "0xB3E3A0", VA = "0xB3E3A0")]
		private FsmEvent GetRandomEvent()
		{
			return null;
		}

		[Token(Token = "0x60066DB")]
		[Address(RVA = "0xB3E4AC", Offset = "0xB3E4AC", VA = "0xB3E4AC")]
		public RandomEvent()
		{
		}
	}
}
