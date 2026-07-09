using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001192")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8AA4", Offset = "0x5A8AA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8AA4", Offset = "0x5A8AA4")]
	public class StringAppend : FsmStateAction
	{
		[Token(Token = "0x4005396")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA9B8", Offset = "0x5FA9B8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA9B8", Offset = "0x5FA9B8")]
		public FsmString stringVariable;

		[Token(Token = "0x4005397")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAA18", Offset = "0x5FAA18")]
		public FsmString appendString;

		[Token(Token = "0x6006796")]
		[Address(RVA = "0xD2DB9C", Offset = "0xD2DB9C", VA = "0xD2DB9C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006797")]
		[Address(RVA = "0xD2DBA4", Offset = "0xD2DBA4", VA = "0xD2DBA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006798")]
		[Address(RVA = "0xD2DC14", Offset = "0xD2DC14", VA = "0xD2DC14")]
		public StringAppend()
		{
		}
	}
}
