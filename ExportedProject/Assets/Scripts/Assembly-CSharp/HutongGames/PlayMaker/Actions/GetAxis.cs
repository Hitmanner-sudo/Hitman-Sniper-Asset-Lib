using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F9A0", Offset = "0x59F9A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F9A0", Offset = "0x59F9A0")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x59F9A0", Offset = "0x59F9A0")]
	public class GetAxis : FsmStateAction
	{
		[Token(Token = "0x4004AE2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8458", Offset = "0x5D8458")]
		[RequiredField]
		public FsmString axisName;

		[Token(Token = "0x4004AE3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D84A4", Offset = "0x5D84A4")]
		public FsmFloat multiplier;

		[Token(Token = "0x4004AE4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D84DC", Offset = "0x5D84DC")]
		public FsmBool invert;

		[Token(Token = "0x4004AE5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8514", Offset = "0x5D8514")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8514", Offset = "0x5D8514")]
		public FsmFloat store;

		[Token(Token = "0x4004AE6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8574", Offset = "0x5D8574")]
		public bool everyFrame;

		[Token(Token = "0x6006006")]
		[Address(RVA = "0x105D290", Offset = "0x105D290", VA = "0x105D290", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006007")]
		[Address(RVA = "0x105D300", Offset = "0x105D300", VA = "0x105D300", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006008")]
		[Address(RVA = "0x105D3E0", Offset = "0x105D3E0", VA = "0x105D3E0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006009")]
		[Address(RVA = "0x105D33C", Offset = "0x105D33C", VA = "0x105D33C")]
		private void DoGetAxis()
		{
		}

		[Token(Token = "0x600600A")]
		[Address(RVA = "0x105D3E4", Offset = "0x105D3E4", VA = "0x105D3E4")]
		public GetAxis()
		{
		}
	}
}
