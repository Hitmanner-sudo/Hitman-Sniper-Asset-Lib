using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D088", Offset = "0x59D088")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D088", Offset = "0x59D088")]
	public class DebugInt : BaseLogAction
	{
		[Token(Token = "0x40048DE")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0930", Offset = "0x5D0930")]
		public LogLevel logLevel;

		[Token(Token = "0x40048DF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0968", Offset = "0x5D0968")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0968", Offset = "0x5D0968")]
		public FsmInt intVariable;

		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xAEA198", Offset = "0xAEA198", VA = "0xAEA198", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xAEA1A4", Offset = "0xAEA1A4", VA = "0xAEA1A4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E32")]
		[Address(RVA = "0xAEA284", Offset = "0xAEA284", VA = "0xAEA284")]
		public DebugInt()
		{
		}
	}
}
