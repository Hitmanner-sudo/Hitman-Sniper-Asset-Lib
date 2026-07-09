using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E90")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x599064", Offset = "0x599064")]
	public class PlayMakerUiVector2ValueChangedEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004479")]
		[FieldOffset(Offset = "0x28")]
		public ScrollRect scrollRect;

		[Token(Token = "0x6005A42")]
		[Address(RVA = "0xB7FF9C", Offset = "0xB7FF9C", VA = "0xB7FF9C", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A43")]
		[Address(RVA = "0xB80120", Offset = "0xB80120", VA = "0xB80120")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A44")]
		[Address(RVA = "0xB8023C", Offset = "0xB8023C", VA = "0xB8023C")]
		private void OnValueChanged(Vector2 value)
		{
		}

		[Token(Token = "0x6005A45")]
		[Address(RVA = "0xB8033C", Offset = "0xB8033C", VA = "0xB8033C")]
		public PlayMakerUiVector2ValueChangedEvent()
		{
		}
	}
}
