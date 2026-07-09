using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B86")]
	public class ShopGUI : ToolsGUI
	{
		[Token(Token = "0x6004950")]
		[Address(RVA = "0x844A54", Offset = "0x844A54", VA = "0x844A54", Slot = "4")]
		protected override void AddPageList()
		{
		}

		[Token(Token = "0x6004951")]
		[Address(RVA = "0x844C5C", Offset = "0x844C5C", VA = "0x844C5C", Slot = "5")]
		protected override string GetHistoryFileName()
		{
			return null;
		}

		[Token(Token = "0x6004952")]
		[Address(RVA = "0x844CA0", Offset = "0x844CA0", VA = "0x844CA0")]
		public ShopGUI()
		{
		}
	}
}
