using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E8E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598FF4", Offset = "0x598FF4")]
	public class PlayMakerUiIntValueChangedEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004478")]
		[FieldOffset(Offset = "0x28")]
		public Dropdown dropdown;

		[Token(Token = "0x6005A38")]
		[Address(RVA = "0xB7F7F0", Offset = "0xB7F7F0", VA = "0xB7F7F0", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A39")]
		[Address(RVA = "0xB7F974", Offset = "0xB7F974", VA = "0xB7F974")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0xB7FA90", Offset = "0xB7FA90", VA = "0xB7FA90")]
		private void OnValueChanged(int value)
		{
		}

		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0xB7FB84", Offset = "0xB7FB84", VA = "0xB7FB84")]
		public PlayMakerUiIntValueChangedEvent()
		{
		}
	}
}
