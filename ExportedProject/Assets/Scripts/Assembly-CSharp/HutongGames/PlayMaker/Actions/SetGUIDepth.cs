using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DFB0", Offset = "0x59DFB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DFB0", Offset = "0x59DFB0")]
	public class SetGUIDepth : FsmStateAction
	{
		[Token(Token = "0x40049CC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3F84", Offset = "0x5D3F84")]
		[RequiredField]
		public FsmInt depth;

		[Token(Token = "0x6005EE0")]
		[Address(RVA = "0x103D5FC", Offset = "0x103D5FC", VA = "0x103D5FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x103D628", Offset = "0x103D628", VA = "0x103D628", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x103D648", Offset = "0x103D648", VA = "0x103D648", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x103D6C8", Offset = "0x103D6C8", VA = "0x103D6C8")]
		public SetGUIDepth()
		{
		}
	}
}
