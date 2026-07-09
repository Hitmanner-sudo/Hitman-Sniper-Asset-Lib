using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F6C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59CF48", Offset = "0x59CF48")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59CF48", Offset = "0x59CF48")]
	public class DebugEnum : BaseLogAction
	{
		[Token(Token = "0x40048D6")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0710", Offset = "0x5D0710")]
		public LogLevel logLevel;

		[Token(Token = "0x40048D7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0748", Offset = "0x5D0748")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0748", Offset = "0x5D0748")]
		public FsmEnum enumVariable;

		[Token(Token = "0x6005E24")]
		[Address(RVA = "0xAE8A28", Offset = "0xAE8A28", VA = "0xAE8A28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E25")]
		[Address(RVA = "0xAE8A38", Offset = "0xAE8A38", VA = "0xAE8A38", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E26")]
		[Address(RVA = "0xAE8B1C", Offset = "0xAE8B1C", VA = "0xAE8B1C")]
		public DebugEnum()
		{
		}
	}
}
