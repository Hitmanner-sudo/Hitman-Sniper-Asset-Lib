using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B7D")]
	public class ItemsPage : BaseShopPage
	{
		[Token(Token = "0x4003A56")]
		[FieldOffset(Offset = "0xB0")]
		private int NO_SEGMENT;

		[Token(Token = "0x4003A57")]
		[FieldOffset(Offset = "0xB8")]
		private List<SegmentData> _segmentList;

		[Token(Token = "0x4003A58")]
		[FieldOffset(Offset = "0xC0")]
		private int _currentSegmentIndex;

		[Token(Token = "0x4003A59")]
		[FieldOffset(Offset = "0xC4")]
		private bool _forceOnEnter;

		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x10C5300", Offset = "0x10C5300", VA = "0x10C5300")]
		public ItemsPage()
		{
		}

		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x10C5530", Offset = "0x10C5530", VA = "0x10C5530", Slot = "5")]
		public override void Enter()
		{
		}

		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x10C554C", Offset = "0x10C554C", VA = "0x10C554C", Slot = "6")]
		public override void Execute()
		{
		}

		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x10C5594", Offset = "0x10C5594", VA = "0x10C5594")]
		private void OnGetSegmentList(List<SegmentData> list)
		{
		}

		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x10C5664", Offset = "0x10C5664", VA = "0x10C5664", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x60048E6")]
		[Address(RVA = "0x10C5668", Offset = "0x10C5668", VA = "0x10C5668")]
		private void OnRequestObjectList(List<ItemData> list)
		{
		}

		[Token(Token = "0x60048E7")]
		[Address(RVA = "0x10C5760", Offset = "0x10C5760", VA = "0x10C5760", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x60048E8")]
		[Address(RVA = "0x10C58C0", Offset = "0x10C58C0", VA = "0x10C58C0")]
		private void OnCreateObject(ItemData data)
		{
		}

		[Token(Token = "0x60048E9")]
		[Address(RVA = "0x10C59C4", Offset = "0x10C59C4", VA = "0x10C59C4", Slot = "14")]
		protected override void SelectObject(int templateId)
		{
		}

		[Token(Token = "0x60048EA")]
		[Address(RVA = "0x10C59F0", Offset = "0x10C59F0", VA = "0x10C59F0", Slot = "23")]
		protected override void RevertObject()
		{
		}

		[Token(Token = "0x60048EB")]
		[Address(RVA = "0x10C5A1C", Offset = "0x10C5A1C", VA = "0x10C5A1C", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}

		[Token(Token = "0x60048EC")]
		[Address(RVA = "0x10C8AE0", Offset = "0x10C8AE0", VA = "0x10C8AE0")]
		private void OnGetTemplateList(List<TemplateData> list)
		{
		}

		[Token(Token = "0x60048ED")]
		[Address(RVA = "0x10C8CC0", Offset = "0x10C8CC0", VA = "0x10C8CC0", Slot = "12")]
		protected override void DisplayConfirmationMessage()
		{
		}

		[Token(Token = "0x60048EE")]
		[Address(RVA = "0x10C9748", Offset = "0x10C9748", VA = "0x10C9748")]
		public void ResultOfferListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x60048EF")]
		[Address(RVA = "0x10C9880", Offset = "0x10C9880", VA = "0x10C9880")]
		public void ResultNewSegmentListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x10C99C4", Offset = "0x10C99C4", VA = "0x10C99C4")]
		private void OnCreateItemSegment(ItemData data, SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x10C9A78", Offset = "0x10C9A78", VA = "0x10C9A78")]
		public void ResultSelectSegmentListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x10C9A98", Offset = "0x10C9A98", VA = "0x10C9A98")]
		public void ResultTemplateListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x10C9B70", Offset = "0x10C9B70", VA = "0x10C9B70", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x60048F4")]
		[Address(RVA = "0x10C9D8C", Offset = "0x10C9D8C", VA = "0x10C9D8C")]
		private void OnUpdateObject(ItemData data)
		{
		}

		[Token(Token = "0x60048F5")]
		[Address(RVA = "0x10C9F4C", Offset = "0x10C9F4C", VA = "0x10C9F4C")]
		private void OnUpdateSegment(ItemData data, SegmentOverride segment)
		{
		}

		[Token(Token = "0x60048F6")]
		[Address(RVA = "0x10C9E30", Offset = "0x10C9E30", VA = "0x10C9E30")]
		private void ProcessUpdate(ItemData data)
		{
		}

		[Token(Token = "0x60048F7")]
		[Address(RVA = "0x10C9FF0", Offset = "0x10C9FF0", VA = "0x10C9FF0", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x60048F8")]
		[Address(RVA = "0x10CA1A4", Offset = "0x10CA1A4", VA = "0x10CA1A4", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}

		[Token(Token = "0x60048F9")]
		[Address(RVA = "0x10CA394", Offset = "0x10CA394", VA = "0x10CA394")]
		private void OnRemoveObject(ItemData data)
		{
		}

		[Token(Token = "0x60048FA")]
		[Address(RVA = "0x10CA430", Offset = "0x10CA430", VA = "0x10CA430")]
		private void OnRemoveSegment(ItemData data, SegmentOverride segment)
		{
		}
	}
}
