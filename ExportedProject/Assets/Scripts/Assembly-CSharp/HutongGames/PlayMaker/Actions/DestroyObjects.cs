using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EF90", Offset = "0x59EF90")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EF90", Offset = "0x59EF90")]
	public class DestroyObjects : FsmStateAction
	{
		[Token(Token = "0x4004A74")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D663C", Offset = "0x5D663C")]
		[Attribute(Name = "ArrayEditorAttribute", RVA = "0x5D663C", Offset = "0x5D663C")]
		public FsmArray gameObjects;

		[Token(Token = "0x4004A75")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D66BC", Offset = "0x5D66BC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5D66BC", Offset = "0x5D66BC")]
		public FsmFloat delay;

		[Token(Token = "0x4004A76")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6710", Offset = "0x5D6710")]
		public FsmBool detachChildren;

		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0xC1320C", Offset = "0xC1320C", VA = "0xC1320C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0xC1323C", Offset = "0xC1323C", VA = "0xC1323C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F80")]
		[Address(RVA = "0xC13420", Offset = "0xC13420", VA = "0xC13420")]
		public DestroyObjects()
		{
		}
	}
}
