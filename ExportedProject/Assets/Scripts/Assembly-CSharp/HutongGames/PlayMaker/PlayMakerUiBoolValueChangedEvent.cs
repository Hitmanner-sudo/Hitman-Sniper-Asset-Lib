using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E87")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598EA4", Offset = "0x598EA4")]
	public class PlayMakerUiBoolValueChangedEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004471")]
		[FieldOffset(Offset = "0x28")]
		public Toggle toggle;

		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0xB7E284", Offset = "0xB7E284", VA = "0xB7E284", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0xB7E408", Offset = "0xB7E408", VA = "0xB7E408")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0xB7E524", Offset = "0xB7E524", VA = "0xB7E524")]
		private void OnValueChanged(bool value)
		{
		}

		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0xB7E6E8", Offset = "0xB7E6E8", VA = "0xB7E6E8")]
		public PlayMakerUiBoolValueChangedEvent()
		{
		}
	}
}
