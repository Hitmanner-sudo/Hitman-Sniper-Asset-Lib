using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B6B0", Offset = "0x59B6B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B6B0", Offset = "0x59B6B0")]
	public class ArrayRemoveAll : FsmStateAction
	{
		[Token(Token = "0x400475C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA9C4", Offset = "0x5CA9C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA9C4", Offset = "0x5CA9C4")]
		public FsmArray array;

		[Token(Token = "0x6005CCB")]
		[Address(RVA = "0xBFD720", Offset = "0xBFD720", VA = "0xBFD720", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CCC")]
		[Address(RVA = "0xBFD728", Offset = "0xBFD728", VA = "0xBFD728", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0xBFD760", Offset = "0xBFD760", VA = "0xBFD760")]
		public ArrayRemoveAll()
		{
		}
	}
}
