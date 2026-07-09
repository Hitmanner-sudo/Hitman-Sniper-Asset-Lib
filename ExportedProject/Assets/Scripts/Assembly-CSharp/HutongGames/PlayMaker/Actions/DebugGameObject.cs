using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F6F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D038", Offset = "0x59D038")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D038", Offset = "0x59D038")]
	public class DebugGameObject : BaseLogAction
	{
		[Token(Token = "0x40048DC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D08A8", Offset = "0x5D08A8")]
		public LogLevel logLevel;

		[Token(Token = "0x40048DD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D08E0", Offset = "0x5D08E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D08E0", Offset = "0x5D08E0")]
		public FsmGameObject gameObject;

		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0xAE8C94", Offset = "0xAE8C94", VA = "0xAE8C94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xAE8CA4", Offset = "0xAE8CA4", VA = "0xAE8CA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xAE8D74", Offset = "0xAE8D74", VA = "0xAE8D74")]
		public DebugGameObject()
		{
		}
	}
}
