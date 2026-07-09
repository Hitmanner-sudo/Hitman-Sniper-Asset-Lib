using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E8D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598FBC", Offset = "0x598FBC")]
	public class PlayMakerUiFloatValueChangedEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004476")]
		[FieldOffset(Offset = "0x28")]
		public Slider slider;

		[Token(Token = "0x4004477")]
		[FieldOffset(Offset = "0x30")]
		public Scrollbar scrollbar;

		[Token(Token = "0x6005A34")]
		[Address(RVA = "0xB7F2DC", Offset = "0xB7F2DC", VA = "0xB7F2DC", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A35")]
		[Address(RVA = "0xB7F548", Offset = "0xB7F548", VA = "0xB7F548")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A36")]
		[Address(RVA = "0xB7F6F0", Offset = "0xB7F6F0", VA = "0xB7F6F0")]
		private void OnValueChanged(float value)
		{
		}

		[Token(Token = "0x6005A37")]
		[Address(RVA = "0xB7F7EC", Offset = "0xB7F7EC", VA = "0xB7F7EC")]
		public PlayMakerUiFloatValueChangedEvent()
		{
		}
	}
}
