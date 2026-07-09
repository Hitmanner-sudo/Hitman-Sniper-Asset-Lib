using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.CrossPromotion;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B57")]
	public class CrossPromotionPage : BaseShopPage
	{
		[Token(Token = "0x40039C2")]
		[FieldOffset(Offset = "0xB0")]
		private List<SegmentData> _segmentList;

		[Token(Token = "0x60047D4")]
		[Address(RVA = "0xD85B10", Offset = "0xD85B10", VA = "0xD85B10")]
		public CrossPromotionPage()
		{
		}

		[Token(Token = "0x60047D5")]
		[Address(RVA = "0xD85C44", Offset = "0xD85C44", VA = "0xD85C44", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x60047D6")]
		[Address(RVA = "0xD85D34", Offset = "0xD85D34", VA = "0xD85D34")]
		private void RequestObjectListSucceed(Infocast[] infocasts)
		{
		}

		[Token(Token = "0x60047D7")]
		[Address(RVA = "0xD85F24", Offset = "0xD85F24", VA = "0xD85F24", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x60047D8")]
		[Address(RVA = "0xD8601C", Offset = "0xD8601C", VA = "0xD8601C")]
		private void CreateObjectSucceed(Infocast infocast)
		{
		}

		[Token(Token = "0x60047D9")]
		[Address(RVA = "0xD860BC", Offset = "0xD860BC", VA = "0xD860BC", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}

		[Token(Token = "0x60047DA")]
		[Address(RVA = "0xD87778", Offset = "0xD87778", VA = "0xD87778")]
		public void ResultNewSegmentListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x60047DB")]
		[Address(RVA = "0xD87894", Offset = "0xD87894", VA = "0xD87894", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x60047DC")]
		[Address(RVA = "0xD8798C", Offset = "0xD8798C", VA = "0xD8798C")]
		private void UpdateObjectSucceed(Infocast infocast)
		{
		}

		[Token(Token = "0x60047DD")]
		[Address(RVA = "0xD87994", Offset = "0xD87994", VA = "0xD87994", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x60047DE")]
		[Address(RVA = "0xD87A90", Offset = "0xD87A90", VA = "0xD87A90", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}

		[Token(Token = "0x60047DF")]
		[Address(RVA = "0xD87AD0", Offset = "0xD87AD0", VA = "0xD87AD0")]
		private void RemoveObjectSucceed(Infocast infocast)
		{
		}
	}
}
