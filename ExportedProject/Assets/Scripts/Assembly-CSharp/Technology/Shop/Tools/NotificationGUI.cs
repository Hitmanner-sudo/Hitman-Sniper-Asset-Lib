using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B6C")]
	public class NotificationGUI : ToolsGUI
	{
		[Token(Token = "0x600485D")]
		[Address(RVA = "0xC60AF0", Offset = "0xC60AF0", VA = "0xC60AF0", Slot = "4")]
		protected override void AddPageList()
		{
		}

		[Token(Token = "0x600485E")]
		[Address(RVA = "0xC60C50", Offset = "0xC60C50", VA = "0xC60C50", Slot = "5")]
		protected override string GetHistoryFileName()
		{
			return null;
		}

		[Token(Token = "0x600485F")]
		[Address(RVA = "0xC60C94", Offset = "0xC60C94", VA = "0xC60C94")]
		public NotificationGUI()
		{
		}
	}
}
