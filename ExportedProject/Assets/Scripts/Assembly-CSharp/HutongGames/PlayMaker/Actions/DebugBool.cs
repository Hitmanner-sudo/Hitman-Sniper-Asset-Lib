using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F69")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CEA8", Offset = "0x59CEA8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CEA8", Offset = "0x59CEA8")]
	public class DebugBool : BaseLogAction
	{
		[Token(Token = "0x40048CA")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D050C", Offset = "0x5D050C")]
		public LogLevel logLevel;

		[Token(Token = "0x40048CB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0544", Offset = "0x5D0544")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0544", Offset = "0x5D0544")]
		public FsmBool boolVariable;

		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0xAE7C88", Offset = "0xAE7C88", VA = "0xAE7C88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0xAE7C98", Offset = "0xAE7C98", VA = "0xAE7C98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0xAE7D7C", Offset = "0xAE7D7C", VA = "0xAE7D7C")]
		public DebugBool()
		{
		}
	}
}
