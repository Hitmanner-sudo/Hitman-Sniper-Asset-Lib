using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F6E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CFE8", Offset = "0x59CFE8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CFE8", Offset = "0x59CFE8")]
	public class DebugFsmVariable : BaseLogAction
	{
		[Token(Token = "0x40048DA")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0820", Offset = "0x5D0820")]
		public LogLevel logLevel;

		[Token(Token = "0x40048DB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0858", Offset = "0x5D0858")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0858", Offset = "0x5D0858")]
		public FsmVar variable;

		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0xAE8C1C", Offset = "0xAE8C1C", VA = "0xAE8C1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0xAE8C2C", Offset = "0xAE8C2C", VA = "0xAE8C2C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0xAE8C8C", Offset = "0xAE8C8C", VA = "0xAE8C8C")]
		public DebugFsmVariable()
		{
		}
	}
}
