using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200105B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1B60", Offset = "0x5A1B60")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1B60", Offset = "0x5A1B60")]
	public class RandomBool : FsmStateAction
	{
		[Token(Token = "0x4004CCD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E03C8", Offset = "0x5E03C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E03C8", Offset = "0x5E03C8")]
		public FsmBool storeResult;

		[Token(Token = "0x60061D3")]
		[Address(RVA = "0xB3E224", Offset = "0xB3E224", VA = "0xB3E224", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60061D4")]
		[Address(RVA = "0xB3E22C", Offset = "0xB3E22C", VA = "0xB3E22C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60061D5")]
		[Address(RVA = "0xB3E278", Offset = "0xB3E278", VA = "0xB3E278")]
		public RandomBool()
		{
		}
	}
}
