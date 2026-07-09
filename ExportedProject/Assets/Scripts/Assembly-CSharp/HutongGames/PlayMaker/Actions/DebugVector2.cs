using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001255")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC404", Offset = "0x5AC404")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC404", Offset = "0x5AC404")]
	public class DebugVector2 : FsmStateAction
	{
		[Token(Token = "0x40057D0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609208", Offset = "0x609208")]
		public LogLevel logLevel;

		[Token(Token = "0x40057D1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609240", Offset = "0x609240")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609240", Offset = "0x609240")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x6006B4D")]
		[Address(RVA = "0xAEA66C", Offset = "0xAEA66C", VA = "0xAEA66C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0xAEA678", Offset = "0xAEA678", VA = "0xAEA678", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0xAEA754", Offset = "0xAEA754", VA = "0xAEA754")]
		public DebugVector2()
		{
		}
	}
}
