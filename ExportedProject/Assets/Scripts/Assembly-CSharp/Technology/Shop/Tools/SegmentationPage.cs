using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B85")]
	public class SegmentationPage : BaseShopPage
	{
		[Token(Token = "0x4003A6A")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> _playersList;

		[Token(Token = "0x4003A6B")]
		[FieldOffset(Offset = "0xB8")]
		private List<ItemData> _itemsList;

		[Token(Token = "0x4003A6C")]
		[FieldOffset(Offset = "0xC0")]
		private string _newPlayerId;

		[Token(Token = "0x4003A6D")]
		[FieldOffset(Offset = "0xC8")]
		private string _removePlayerId;

		[Token(Token = "0x6004942")]
		[Address(RVA = "0xB6E35C", Offset = "0xB6E35C", VA = "0xB6E35C")]
		public SegmentationPage()
		{
		}

		[Token(Token = "0x6004943")]
		[Address(RVA = "0xB6E54C", Offset = "0xB6E54C", VA = "0xB6E54C", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x6004944")]
		[Address(RVA = "0xB6E550", Offset = "0xB6E550", VA = "0xB6E550")]
		private void OnGetSegmentList(List<SegmentData> list)
		{
		}

		[Token(Token = "0x6004945")]
		[Address(RVA = "0xB6E648", Offset = "0xB6E648", VA = "0xB6E648", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x6004946")]
		[Address(RVA = "0xB6E754", Offset = "0xB6E754", VA = "0xB6E754", Slot = "14")]
		protected override void SelectObject(int templateId)
		{
		}

		[Token(Token = "0x6004947")]
		[Address(RVA = "0xB6E858", Offset = "0xB6E858", VA = "0xB6E858")]
		private void OnSelectObject(SegmentData data, List<string> list)
		{
		}

		[Token(Token = "0x6004948")]
		[Address(RVA = "0xB6E8F4", Offset = "0xB6E8F4", VA = "0xB6E8F4", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}

		[Token(Token = "0x6004949")]
		[Address(RVA = "0xB6ECFC", Offset = "0xB6ECFC", VA = "0xB6ECFC")]
		private void DisplayPlayersSection()
		{
		}

		[Token(Token = "0x600494A")]
		[Address(RVA = "0xB6F454", Offset = "0xB6F454", VA = "0xB6F454")]
		private void OnCreate(PlayersToSegmentData data)
		{
		}

		[Token(Token = "0x600494B")]
		[Address(RVA = "0xB6F5B8", Offset = "0xB6F5B8", VA = "0xB6F5B8")]
		private void OnDelete(PlayersToSegmentData data)
		{
		}

		[Token(Token = "0x600494C")]
		[Address(RVA = "0xB6F6C0", Offset = "0xB6F6C0", VA = "0xB6F6C0")]
		private void RequestItemList()
		{
		}

		[Token(Token = "0x600494D")]
		[Address(RVA = "0xB6F7C0", Offset = "0xB6F7C0", VA = "0xB6F7C0", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x600494E")]
		[Address(RVA = "0xB6F948", Offset = "0xB6F948", VA = "0xB6F948", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x600494F")]
		[Address(RVA = "0xB6F9F8", Offset = "0xB6F9F8", VA = "0xB6F9F8", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}
	}
}
