using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011FE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AA914", Offset = "0x5AA914")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AA914", Offset = "0x5AA914")]
	public class UiSetSelectedGameObject : FsmStateAction
	{
		[Token(Token = "0x40055F4")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x601AFC", Offset = "0x601AFC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x601AFC", Offset = "0x601AFC")]
		public FsmGameObject gameObject;

		[Token(Token = "0x600699E")]
		[Address(RVA = "0xB97F2C", Offset = "0xB97F2C", VA = "0xB97F2C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600699F")]
		[Address(RVA = "0xB97F34", Offset = "0xB97F34", VA = "0xB97F34", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069A0")]
		[Address(RVA = "0xB97F5C", Offset = "0xB97F5C", VA = "0xB97F5C")]
		private void DoSetSelectedGameObject()
		{
		}

		[Token(Token = "0x60069A1")]
		[Address(RVA = "0xB97FEC", Offset = "0xB97FEC", VA = "0xB97FEC")]
		public UiSetSelectedGameObject()
		{
		}
	}
}
