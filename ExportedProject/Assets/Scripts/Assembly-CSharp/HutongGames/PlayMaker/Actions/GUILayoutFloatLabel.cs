using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FBB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E7F8", Offset = "0x59E7F8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E7F8", Offset = "0x59E7F8")]
	public class GUILayoutFloatLabel : GUILayoutAction
	{
		[Token(Token = "0x4004A10")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4F38", Offset = "0x5D4F38")]
		public FsmString prefix;

		[Token(Token = "0x4004A11")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4F70", Offset = "0x5D4F70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4F70", Offset = "0x5D4F70")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004A12")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4FD0", Offset = "0x5D4FD0")]
		public FsmString style;

		[Token(Token = "0x6005F27")]
		[Address(RVA = "0xD90D48", Offset = "0xD90D48", VA = "0xD90D48", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F28")]
		[Address(RVA = "0xD90DB4", Offset = "0xD90DB4", VA = "0xD90DB4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F29")]
		[Address(RVA = "0xD90F28", Offset = "0xD90F28", VA = "0xD90F28")]
		public GUILayoutFloatLabel()
		{
		}
	}
}
