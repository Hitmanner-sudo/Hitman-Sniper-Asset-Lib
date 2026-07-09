using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F6D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CF98", Offset = "0x59CF98")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CF98", Offset = "0x59CF98")]
	public class DebugFloat : BaseLogAction
	{
		[Token(Token = "0x40048D8")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0798", Offset = "0x5D0798")]
		public LogLevel logLevel;

		[Token(Token = "0x40048D9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D07D0", Offset = "0x5D07D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D07D0", Offset = "0x5D07D0")]
		public FsmFloat floatVariable;

		[Token(Token = "0x6005E27")]
		[Address(RVA = "0xAE8B24", Offset = "0xAE8B24", VA = "0xAE8B24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E28")]
		[Address(RVA = "0xAE8B34", Offset = "0xAE8B34", VA = "0xAE8B34", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E29")]
		[Address(RVA = "0xAE8C14", Offset = "0xAE8C14", VA = "0xAE8C14")]
		public DebugFloat()
		{
		}
	}
}
