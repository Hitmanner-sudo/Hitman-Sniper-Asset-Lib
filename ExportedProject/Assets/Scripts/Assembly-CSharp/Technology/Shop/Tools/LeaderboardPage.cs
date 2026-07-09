using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B5F")]
	public class LeaderboardPage : BaseShopPage
	{
		[Token(Token = "0x40039D1")]
		private const string LEADERBOARD_ID_LABEL = "Leaderboard id:";

		[Token(Token = "0x40039D2")]
		private const string DISPLAY_LABEL = "Display";

		[Token(Token = "0x40039D3")]
		private const string RESET_LEADERBOARD_LABEL = "RESET THIS\nLEADERBOARD";

		[Token(Token = "0x40039D4")]
		private const string RESET_LEADERBOARD_CONFIRMATION_LABEL = "Are you sure you want to delete this leaderboard?";

		[Token(Token = "0x40039D5")]
		private const string CONFIRMATION_LABEL = "Confirm";

		[Token(Token = "0x40039D6")]
		private const string CANCEL_LABEL = "Cancel";

		[Token(Token = "0x40039D7")]
		private const string SELECT_ALL_LABEL = "Select all";

		[Token(Token = "0x40039D8")]
		private const string UNSELECTED_ALL_LABEL = "Unselected all";

		[Token(Token = "0x40039D9")]
		private const string RESET_SCORES_LABEL = "Reset the selected score(s)";

		[Token(Token = "0x40039DA")]
		private const string RESET_SCORES_CONFIRMATION_LABEL = "Are you sure you want to delete the selected scores?";

		[Token(Token = "0x40039DB")]
		private const string ID_LABEL = "Id";

		[Token(Token = "0x40039DC")]
		private const string SCORE_LABEL = "Score";

		[Token(Token = "0x40039DD")]
		private const string NO_RESULT_LABEL = "No result";

		[Token(Token = "0x40039DE")]
		private const string PREVIOUS_PAGE_LABEL = "Previous Page";

		[Token(Token = "0x40039DF")]
		private const string NEXT_PAGE_LABEL = "Next Page";

		[Token(Token = "0x40039E0")]
		private const int INVALID_VALUE = -1;

		[Token(Token = "0x40039E1")]
		private const int LEADERBOARD_DEFAULT_VALUE = 1;

		[Token(Token = "0x40039E2")]
		private const int RESULT_ROW_ORIGIN = 40;

		[Token(Token = "0x40039E3")]
		private const int RESULT_ROW_COUNT = 15;

		[Token(Token = "0x40039E4")]
		private const int RESULT_ROW_HEIGHT = 30;

		[Token(Token = "0x40039E5")]
		private const int RESULT_COLUMN_ORIGIN = 0;

		[Token(Token = "0x40039E6")]
		private const int RESULT_COLUMN_COUNT = 5;

		[Token(Token = "0x40039E7")]
		private const int RESULT_COLUMN_WIDTH = 250;

		[Token(Token = "0x40039E8")]
		[FieldOffset(Offset = "0xB0")]
		private bool _resetLeaderboardConfirmation;

		[Token(Token = "0x40039E9")]
		[FieldOffset(Offset = "0xB1")]
		private bool _resetSelectedConfirmation;

		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0xB2")]
		private bool _resetInProgress;

		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0xB3")]
		private bool _refreshList;

		[Token(Token = "0x40039EC")]
		[FieldOffset(Offset = "0xB4")]
		private int _currentLeaderboardType;

		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0xB8")]
		private int _currentLeaderboardId;

		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0xC0")]
		private string _currentLeaderboardField;

		[Token(Token = "0x40039EF")]
		[FieldOffset(Offset = "0xC8")]
		private string[] _leaderboardTypes;

		[Token(Token = "0x40039F0")]
		[FieldOffset(Offset = "0xD0")]
		private List<LeaderboardData> _resetList;

		[Token(Token = "0x6004806")]
		[Address(RVA = "0x9A45B0", Offset = "0x9A45B0", VA = "0x9A45B0")]
		public LeaderboardPage()
		{
		}

		[Token(Token = "0x6004807")]
		[Address(RVA = "0x9A4868", Offset = "0x9A4868", VA = "0x9A4868", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x6004808")]
		[Address(RVA = "0x9A495C", Offset = "0x9A495C", VA = "0x9A495C", Slot = "7")]
		public override void Exit()
		{
		}

		[Token(Token = "0x6004809")]
		[Address(RVA = "0x9A4A2C", Offset = "0x9A4A2C", VA = "0x9A4A2C")]
		public void OnGetEntryListRequest(List<LeaderboardData> list)
		{
		}

		[Token(Token = "0x600480A")]
		[Address(RVA = "0x9A4B34", Offset = "0x9A4B34", VA = "0x9A4B34")]
		public void OnResetThisWeekLeaderboardRequest()
		{
		}

		[Token(Token = "0x600480B")]
		[Address(RVA = "0x9A4B40", Offset = "0x9A4B40", VA = "0x9A4B40", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x600480C")]
		[Address(RVA = "0x9A4CA0", Offset = "0x9A4CA0", VA = "0x9A4CA0", Slot = "10")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x600480D")]
		[Address(RVA = "0x9A5AB0", Offset = "0x9A5AB0", VA = "0x9A5AB0")]
		private void SelectAllEntries(bool selected)
		{
		}

		[Token(Token = "0x600480E")]
		[Address(RVA = "0x9A4C7C", Offset = "0x9A4C7C", VA = "0x9A4C7C")]
		private SvcOpGetLeaderboard.LeaderBoardType GetCurrentLeaderboardType()
		{
			return default(SvcOpGetLeaderboard.LeaderBoardType);
		}

		[Token(Token = "0x600480F")]
		[Address(RVA = "0x9A4834", Offset = "0x9A4834", VA = "0x9A4834")]
		private void RefreshCurrentLeaderboard()
		{
		}

		[Token(Token = "0x6004810")]
		[Address(RVA = "0x9A5BA0", Offset = "0x9A5BA0", VA = "0x9A5BA0")]
		private void ResetSelectedEntries()
		{
		}

		[Token(Token = "0x6004811")]
		[Address(RVA = "0x9A5AA8", Offset = "0x9A5AA8", VA = "0x9A5AA8")]
		private void ResetCurrentLeaderboard()
		{
		}

		[Token(Token = "0x6004812")]
		[Address(RVA = "0x9A5CF0", Offset = "0x9A5CF0", VA = "0x9A5CF0")]
		private void OnResetScore(LeaderboardData data)
		{
		}

		[Token(Token = "0x6004813")]
		[Address(RVA = "0x9A5DD8", Offset = "0x9A5DD8", VA = "0x9A5DD8", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x6004814")]
		[Address(RVA = "0x9A5DDC", Offset = "0x9A5DDC", VA = "0x9A5DDC", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x6004815")]
		[Address(RVA = "0x9A5DE0", Offset = "0x9A5DE0", VA = "0x9A5DE0", Slot = "14")]
		protected override void SelectObject(int templateId)
		{
		}

		[Token(Token = "0x6004816")]
		[Address(RVA = "0x9A5DE4", Offset = "0x9A5DE4", VA = "0x9A5DE4", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x6004817")]
		[Address(RVA = "0x9A5DE8", Offset = "0x9A5DE8", VA = "0x9A5DE8", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x6004818")]
		[Address(RVA = "0x9A5DEC", Offset = "0x9A5DEC", VA = "0x9A5DEC", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}

		[Token(Token = "0x6004819")]
		[Address(RVA = "0x9A5DF0", Offset = "0x9A5DF0", VA = "0x9A5DF0", Slot = "23")]
		protected override void RevertObject()
		{
		}

		[Token(Token = "0x600481A")]
		[Address(RVA = "0x9A5DF4", Offset = "0x9A5DF4", VA = "0x9A5DF4", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}
	}
}
