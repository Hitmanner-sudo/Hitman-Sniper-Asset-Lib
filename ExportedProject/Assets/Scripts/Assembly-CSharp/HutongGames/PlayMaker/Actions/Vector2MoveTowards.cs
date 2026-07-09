using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001263")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC864", Offset = "0x5AC864")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC864", Offset = "0x5AC864")]
	public class Vector2MoveTowards : FsmStateAction
	{
		[Token(Token = "0x4005806")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A088", Offset = "0x60A088")]
		[RequiredField]
		public FsmVector2 source;

		[Token(Token = "0x4005807")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A0D4", Offset = "0x60A0D4")]
		public FsmVector2 target;

		[Token(Token = "0x4005808")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x60A10C", Offset = "0x60A10C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A10C", Offset = "0x60A10C")]
		public FsmFloat maxSpeed;

		[Token(Token = "0x4005809")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A160", Offset = "0x60A160")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x60A160", Offset = "0x60A160")]
		public FsmFloat finishDistance;

		[Token(Token = "0x400580A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A1B4", Offset = "0x60A1B4")]
		public FsmEvent finishEvent;

		[Token(Token = "0x6006B8B")]
		[Address(RVA = "0x13C67C4", Offset = "0x13C67C4", VA = "0x13C67C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B8C")]
		[Address(RVA = "0x13C6804", Offset = "0x13C6804", VA = "0x13C6804", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B8D")]
		[Address(RVA = "0x13C6808", Offset = "0x13C6808", VA = "0x13C6808")]
		private void DoMoveTowards()
		{
		}

		[Token(Token = "0x6006B8E")]
		[Address(RVA = "0x13C6900", Offset = "0x13C6900", VA = "0x13C6900")]
		public Vector2MoveTowards()
		{
		}
	}
}
