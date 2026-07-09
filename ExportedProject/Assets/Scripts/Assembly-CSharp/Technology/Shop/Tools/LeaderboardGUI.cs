using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B5E")]
	public class LeaderboardGUI : ToolsGUI
	{
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x99FB5C", Offset = "0x99FB5C", VA = "0x99FB5C", Slot = "4")]
		protected override void AddPageList()
		{
		}

		[Token(Token = "0x6004804")]
		[Address(RVA = "0x99FC68", Offset = "0x99FC68", VA = "0x99FC68", Slot = "5")]
		protected override string GetHistoryFileName()
		{
			return null;
		}

		[Token(Token = "0x6004805")]
		[Address(RVA = "0x99FCAC", Offset = "0x99FCAC", VA = "0x99FCAC")]
		public LeaderboardGUI()
		{
		}
	}
}
