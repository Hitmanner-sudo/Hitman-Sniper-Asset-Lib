using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E8A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598F4C", Offset = "0x598F4C")]
	public class PlayMakerUiDropEvent : PlayMakerUiEventBase, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0xB7ECD8", Offset = "0xB7ECD8", VA = "0xB7ECD8", Slot = "5")]
		public void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005A28")]
		[Address(RVA = "0xB7EDA8", Offset = "0xB7EDA8", VA = "0xB7EDA8")]
		public PlayMakerUiDropEvent()
		{
		}
	}
}
