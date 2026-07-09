using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F20")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B840", Offset = "0x59B840")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B840", Offset = "0x59B840")]
	public class ArraySort : FsmStateAction
	{
		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CADB4", Offset = "0x5CADB4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CADB4", Offset = "0x5CADB4")]
		public FsmArray array;

		[Token(Token = "0x6005CDB")]
		[Address(RVA = "0xBFDD90", Offset = "0xBFDD90", VA = "0xBFDD90", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CDC")]
		[Address(RVA = "0xBFDD98", Offset = "0xBFDD98", VA = "0xBFDD98", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0xBFDE90", Offset = "0xBFDE90", VA = "0xBFDE90")]
		public ArraySort()
		{
		}
	}
}
