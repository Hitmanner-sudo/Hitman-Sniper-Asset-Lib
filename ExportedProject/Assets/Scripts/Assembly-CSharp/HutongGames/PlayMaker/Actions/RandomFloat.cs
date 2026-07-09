using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1BB0", Offset = "0x5A1BB0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1BB0", Offset = "0x5A1BB0")]
	public class RandomFloat : FsmStateAction
	{
		[Token(Token = "0x4004CCE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0418", Offset = "0x5E0418")]
		public FsmFloat min;

		[Token(Token = "0x4004CCF")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0464", Offset = "0x5E0464")]
		public FsmFloat max;

		[Token(Token = "0x4004CD0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E04B0", Offset = "0x5E04B0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E04B0", Offset = "0x5E04B0")]
		[RequiredField]
		public FsmFloat storeResult;

		[Token(Token = "0x60061D6")]
		[Address(RVA = "0xB3E4BC", Offset = "0xB3E4BC", VA = "0xB3E4BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061D7")]
		[Address(RVA = "0xB3E4F8", Offset = "0xB3E4F8", VA = "0xB3E4F8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061D8")]
		[Address(RVA = "0xB3E568", Offset = "0xB3E568", VA = "0xB3E568")]
		public RandomFloat()
		{
		}
	}
}
