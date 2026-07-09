using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B8E")]
	public class TemplatesPage : BaseShopPage
	{
		[Token(Token = "0x600497C")]
		[Address(RVA = "0xB5B740", Offset = "0xB5B740", VA = "0xB5B740")]
		public TemplatesPage()
		{
		}

		[Token(Token = "0x600497D")]
		[Address(RVA = "0xB5B880", Offset = "0xB5B880", VA = "0xB5B880", Slot = "13")]
		protected override void RequestObjectList()
		{
		}

		[Token(Token = "0x600497E")]
		[Address(RVA = "0xB5B884", Offset = "0xB5B884", VA = "0xB5B884")]
		private void OnGetTemplateList(List<TemplateData> list)
		{
		}

		[Token(Token = "0x600497F")]
		[Address(RVA = "0xB5B97C", Offset = "0xB5B97C", VA = "0xB5B97C", Slot = "18")]
		protected override void DisplayObjectInfo()
		{
		}

		[Token(Token = "0x6004980")]
		[Address(RVA = "0xB5C8D8", Offset = "0xB5C8D8", VA = "0xB5C8D8")]
		public void ResultOfferListPopup(object sender, ResultListPopupEvent popupEvent)
		{
		}

		[Token(Token = "0x6004981")]
		[Address(RVA = "0xB5CA64", Offset = "0xB5CA64", VA = "0xB5CA64", Slot = "19")]
		protected override void CreateObject()
		{
		}

		[Token(Token = "0x6004982")]
		[Address(RVA = "0xB5CB5C", Offset = "0xB5CB5C", VA = "0xB5CB5C")]
		private void OnCreateObject(TemplateData data)
		{
		}

		[Token(Token = "0x6004983")]
		[Address(RVA = "0xB5CC5C", Offset = "0xB5CC5C", VA = "0xB5CC5C", Slot = "20")]
		public override void UpdateObject()
		{
		}

		[Token(Token = "0x6004984")]
		[Address(RVA = "0xB5CD58", Offset = "0xB5CD58", VA = "0xB5CD58")]
		private void OnUpdateObject(TemplateData data)
		{
		}

		[Token(Token = "0x6004985")]
		[Address(RVA = "0xB5CF00", Offset = "0xB5CF00", VA = "0xB5CF00", Slot = "21")]
		protected override void RemoveObject()
		{
		}

		[Token(Token = "0x6004986")]
		[Address(RVA = "0xB5CFFC", Offset = "0xB5CFFC", VA = "0xB5CFFC", Slot = "22")]
		protected override void CopyToServer(ToolsGUI.Servers server)
		{
		}

		[Token(Token = "0x6004987")]
		[Address(RVA = "0xB5D03C", Offset = "0xB5D03C", VA = "0xB5D03C")]
		private void OnRemoveObject(TemplateData data)
		{
		}
	}
}
