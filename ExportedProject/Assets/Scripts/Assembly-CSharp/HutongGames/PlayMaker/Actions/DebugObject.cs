using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F72")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D128", Offset = "0x59D128")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D128", Offset = "0x59D128")]
	public class DebugObject : BaseLogAction
	{
		[Token(Token = "0x40048E2")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0A28", Offset = "0x5D0A28")]
		public LogLevel logLevel;

		[Token(Token = "0x40048E3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0A60", Offset = "0x5D0A60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0A60", Offset = "0x5D0A60")]
		public FsmObject fsmObject;

		[Token(Token = "0x6005E36")]
		[Address(RVA = "0xAEA370", Offset = "0xAEA370", VA = "0xAEA370", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xAEA380", Offset = "0xAEA380", VA = "0xAEA380", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xAEA450", Offset = "0xAEA450", VA = "0xAEA450")]
		public DebugObject()
		{
		}
	}
}
