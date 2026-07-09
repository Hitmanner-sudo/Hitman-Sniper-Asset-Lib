using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[Token(Token = "0x2000E8B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x598F84", Offset = "0x598F84")]
	public class PlayMakerUiEndEditEvent : PlayMakerUiEventBase
	{
		[Token(Token = "0x4004473")]
		[FieldOffset(Offset = "0x28")]
		public InputField inputField;

		[Token(Token = "0x6005A29")]
		[Address(RVA = "0xB7EDAC", Offset = "0xB7EDAC", VA = "0xB7EDAC", Slot = "4")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0xB7EF30", Offset = "0xB7EF30", VA = "0xB7EF30")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0xB7F04C", Offset = "0xB7F04C", VA = "0xB7F04C")]
		private void DoOnEndEdit(string value)
		{
		}

		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0xB7F140", Offset = "0xB7F140", VA = "0xB7F140")]
		public PlayMakerUiEndEditEvent()
		{
		}
	}
}
