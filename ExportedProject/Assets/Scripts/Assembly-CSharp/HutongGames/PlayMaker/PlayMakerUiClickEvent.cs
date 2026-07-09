using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E88")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598EDC", Offset = "0x598EDC")]
	public class PlayMakerUiClickEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004472")]
		[FieldOffset(Offset = "0x28")]
		public Button button;

		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0xB7E764", Offset = "0xB7E764", VA = "0xB7E764", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A20")]
		[Address(RVA = "0xB7E8C0", Offset = "0xB7E8C0", VA = "0xB7E8C0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A21")]
		[Address(RVA = "0xB7E9B4", Offset = "0xB7E9B4", VA = "0xB7E9B4")]
		private void DoOnClick()
		{
		}

		[Token(Token = "0x6005A22")]
		[Address(RVA = "0xB7EA60", Offset = "0xB7EA60", VA = "0xB7EA60")]
		public PlayMakerUiClickEvent()
		{
		}
	}
}
