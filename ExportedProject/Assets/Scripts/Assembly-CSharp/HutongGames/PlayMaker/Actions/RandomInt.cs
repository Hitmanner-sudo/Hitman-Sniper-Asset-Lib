using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1C00", Offset = "0x5A1C00")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1C00", Offset = "0x5A1C00")]
	public class RandomInt : FsmStateAction
	{
		[Token(Token = "0x4004CD1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0510", Offset = "0x5E0510")]
		[RequiredField]
		public FsmInt min;

		[Token(Token = "0x4004CD2")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E055C", Offset = "0x5E055C")]
		public FsmInt max;

		[Token(Token = "0x4004CD3")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E05A8", Offset = "0x5E05A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E05A8", Offset = "0x5E05A8")]
		public FsmInt storeResult;

		[Token(Token = "0x4004CD4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0608", Offset = "0x5E0608")]
		public bool inclusiveMax;

		[Token(Token = "0x4004CD5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E0640", Offset = "0x5E0640")]
		public FsmBool noRepeat;

		[Token(Token = "0x4004CD6")]
		[FieldOffset(Offset = "0x78")]
		private int randomIndex;

		[Token(Token = "0x4004CD7")]
		[FieldOffset(Offset = "0x7C")]
		private int lastIndex;

		[Token(Token = "0x60061D9")]
		[Address(RVA = "0xB3E71C", Offset = "0xB3E71C", VA = "0xB3E71C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061DA")]
		[Address(RVA = "0xB3E76C", Offset = "0xB3E76C", VA = "0xB3E76C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061DB")]
		[Address(RVA = "0xB3E794", Offset = "0xB3E794", VA = "0xB3E794")]
		private void PickRandom()
		{
		}

		[Token(Token = "0x60061DC")]
		[Address(RVA = "0xB3E8E8", Offset = "0xB3E8E8", VA = "0xB3E8E8")]
		public RandomInt()
		{
		}
	}
}
