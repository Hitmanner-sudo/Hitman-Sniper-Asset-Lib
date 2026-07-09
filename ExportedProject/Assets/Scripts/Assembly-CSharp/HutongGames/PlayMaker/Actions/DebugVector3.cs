using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F73")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D178", Offset = "0x59D178")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D178", Offset = "0x59D178")]
	public class DebugVector3 : BaseLogAction
	{
		[Token(Token = "0x40048E4")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0AB0", Offset = "0x5D0AB0")]
		public LogLevel logLevel;

		[Token(Token = "0x40048E5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0AE8", Offset = "0x5D0AE8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D0AE8", Offset = "0x5D0AE8")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xAEA75C", Offset = "0xAEA75C", VA = "0xAEA75C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0xAEA76C", Offset = "0xAEA76C", VA = "0xAEA76C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0xAEA854", Offset = "0xAEA854", VA = "0xAEA854")]
		public DebugVector3()
		{
		}
	}
}
