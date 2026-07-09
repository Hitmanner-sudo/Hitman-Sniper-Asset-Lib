using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E89")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598F14", Offset = "0x598F14")]
	public class PlayMakerUiDragEvents : PlayMakerUiEventBase, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0xB7EA64", Offset = "0xB7EA64", VA = "0xB7EA64", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005A24")]
		[Address(RVA = "0xB7EB34", Offset = "0xB7EB34", VA = "0xB7EB34", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005A25")]
		[Address(RVA = "0xB7EC04", Offset = "0xB7EC04", VA = "0xB7EC04", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005A26")]
		[Address(RVA = "0xB7ECD4", Offset = "0xB7ECD4", VA = "0xB7ECD4")]
		public PlayMakerUiDragEvents()
		{
		}
	}
}
