using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F71")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D0D8", Offset = "0x59D0D8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D0D8", Offset = "0x59D0D8")]
	public class DebugLog : BaseLogAction
	{
		[Token(Token = "0x40048E0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D09B8", Offset = "0x5D09B8")]
		public LogLevel logLevel;

		[Token(Token = "0x40048E1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D09F0", Offset = "0x5D09F0")]
		public FsmString text;

		[Token(Token = "0x6005E33")]
		[Address(RVA = "0xAEA28C", Offset = "0xAEA28C", VA = "0xAEA28C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E34")]
		[Address(RVA = "0xAEA2EC", Offset = "0xAEA2EC", VA = "0xAEA2EC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E35")]
		[Address(RVA = "0xAEA368", Offset = "0xAEA368", VA = "0xAEA368")]
		public DebugLog()
		{
		}
	}
}
