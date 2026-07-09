using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D9")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A43EC", Offset = "0x5A43EC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A43EC", Offset = "0x5A43EC")]
	public class RectContains : FsmStateAction
	{
		[Token(Token = "0x4004F87")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC2C0", Offset = "0x5EC2C0")]
		public FsmRect rectangle;

		[Token(Token = "0x4004F88")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC30C", Offset = "0x5EC30C")]
		public FsmVector3 point;

		[Token(Token = "0x4004F89")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC344", Offset = "0x5EC344")]
		public FsmFloat x;

		[Token(Token = "0x4004F8A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC37C", Offset = "0x5EC37C")]
		public FsmFloat y;

		[Token(Token = "0x4004F8B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC3B4", Offset = "0x5EC3B4")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004F8C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC3EC", Offset = "0x5EC3EC")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004F8D")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC424", Offset = "0x5EC424")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC424", Offset = "0x5EC424")]
		public FsmBool storeResult;

		[Token(Token = "0x4004F8E")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC474", Offset = "0x5EC474")]
		public bool everyFrame;

		[Token(Token = "0x6006467")]
		[Address(RVA = "0xB43E8C", Offset = "0xB43E8C", VA = "0xB43E8C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006468")]
		[Address(RVA = "0xB43F94", Offset = "0xB43F94", VA = "0xB43F94", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006469")]
		[Address(RVA = "0xB440EC", Offset = "0xB440EC", VA = "0xB440EC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600646A")]
		[Address(RVA = "0xB43FD0", Offset = "0xB43FD0", VA = "0xB43FD0")]
		private void DoRectContains()
		{
		}

		[Token(Token = "0x600646B")]
		[Address(RVA = "0xB440F0", Offset = "0xB440F0", VA = "0xB440F0")]
		public RectContains()
		{
		}
	}
}
