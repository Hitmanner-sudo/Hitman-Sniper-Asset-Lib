using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FA98", Offset = "0x59FA98")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FA98", Offset = "0x59FA98")]
	public class GetButton : FsmStateAction
	{
		[Token(Token = "0x4004AF2")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8788", Offset = "0x5D8788")]
		public FsmString buttonName;

		[Token(Token = "0x4004AF3")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D87D4", Offset = "0x5D87D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D87D4", Offset = "0x5D87D4")]
		public FsmBool storeResult;

		[Token(Token = "0x4004AF4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8834", Offset = "0x5D8834")]
		public bool everyFrame;

		[Token(Token = "0x600600E")]
		[Address(RVA = "0x105D8E0", Offset = "0x105D8E0", VA = "0x105D8E0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600600F")]
		[Address(RVA = "0x105D93C", Offset = "0x105D93C", VA = "0x105D93C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006010")]
		[Address(RVA = "0x105D9C0", Offset = "0x105D9C0", VA = "0x105D9C0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006011")]
		[Address(RVA = "0x105D978", Offset = "0x105D978", VA = "0x105D978")]
		private void DoGetButton()
		{
		}

		[Token(Token = "0x6006012")]
		[Address(RVA = "0x105D9C4", Offset = "0x105D9C4", VA = "0x105D9C4")]
		public GetButton()
		{
		}
	}
}
