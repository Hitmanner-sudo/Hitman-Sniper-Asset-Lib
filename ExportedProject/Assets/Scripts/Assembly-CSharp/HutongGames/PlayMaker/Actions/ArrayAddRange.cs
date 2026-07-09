using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F0D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B290", Offset = "0x59B290")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B290", Offset = "0x59B290")]
	public class ArrayAddRange : FsmStateAction
	{
		[Token(Token = "0x4004721")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C98B0", Offset = "0x5C98B0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C98B0", Offset = "0x5C98B0")]
		public FsmArray array;

		[Token(Token = "0x4004722")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9910", Offset = "0x5C9910")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5C9910", Offset = "0x5C9910")]
		public FsmVar[] variables;

		[Token(Token = "0x6005C89")]
		[Address(RVA = "0xD55E1C", Offset = "0xD55E1C", VA = "0xD55E1C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0xD55E74", Offset = "0xD55E74", VA = "0xD55E74", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0xD55E9C", Offset = "0xD55E9C", VA = "0xD55E9C")]
		private void DoAddRange()
		{
		}

		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0xD55FA0", Offset = "0xD55FA0", VA = "0xD55FA0")]
		public ArrayAddRange()
		{
		}
	}
}
