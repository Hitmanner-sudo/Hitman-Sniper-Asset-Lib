using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA3")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E000", Offset = "0x59E000")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E000", Offset = "0x59E000")]
	public class SetGUISkin : FsmStateAction
	{
		[Token(Token = "0x40049CD")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3FD0", Offset = "0x5D3FD0")]
		public GUISkin skin;

		[Token(Token = "0x40049CE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D401C", Offset = "0x5D401C")]
		public FsmBool applyGlobally;

		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x103D6D0", Offset = "0x103D6D0", VA = "0x103D6D0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x103D700", Offset = "0x103D700", VA = "0x103D700", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x103D85C", Offset = "0x103D85C", VA = "0x103D85C")]
		public SetGUISkin()
		{
		}
	}
}
