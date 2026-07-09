using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5C30", Offset = "0x5A5C30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5C30", Offset = "0x5A5C30")]
	public class AxisEvent : FsmStateAction
	{
		[Token(Token = "0x4005174")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F359C", Offset = "0x5F359C")]
		public FsmString horizontalAxis;

		[Token(Token = "0x4005175")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F35D4", Offset = "0x5F35D4")]
		public FsmString verticalAxis;

		[Token(Token = "0x4005176")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F360C", Offset = "0x5F360C")]
		public FsmEvent leftEvent;

		[Token(Token = "0x4005177")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3644", Offset = "0x5F3644")]
		public FsmEvent rightEvent;

		[Token(Token = "0x4005178")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F367C", Offset = "0x5F367C")]
		public FsmEvent upEvent;

		[Token(Token = "0x4005179")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F36B4", Offset = "0x5F36B4")]
		public FsmEvent downEvent;

		[Token(Token = "0x400517A")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F36EC", Offset = "0x5F36EC")]
		public FsmEvent anyDirection;

		[Token(Token = "0x400517B")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3724", Offset = "0x5F3724")]
		public FsmEvent noDirection;

		[Token(Token = "0x60065CC")]
		[Address(RVA = "0xC0BED8", Offset = "0xC0BED8", VA = "0xC0BED8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065CD")]
		[Address(RVA = "0xC0BF5C", Offset = "0xC0BF5C", VA = "0xC0BF5C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60065CE")]
		[Address(RVA = "0xC0C128", Offset = "0xC0C128", VA = "0xC0C128")]
		public AxisEvent()
		{
		}
	}
}
