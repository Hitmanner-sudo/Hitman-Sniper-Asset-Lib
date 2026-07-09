using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9798", Offset = "0x5A9798")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9798", Offset = "0x5A9798")]
	public class GetAtan2FromVector2 : FsmStateAction
	{
		[Token(Token = "0x40054BB")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE8F4", Offset = "0x5FE8F4")]
		public FsmVector2 vector2;

		[Token(Token = "0x40054BC")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE940", Offset = "0x5FE940")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE940", Offset = "0x5FE940")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x40054BD")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE9A0", Offset = "0x5FE9A0")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054BE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE9D8", Offset = "0x5FE9D8")]
		public bool everyFrame;

		[Token(Token = "0x6006878")]
		[Address(RVA = "0x105D01C", Offset = "0x105D01C", VA = "0x105D01C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006879")]
		[Address(RVA = "0x105D050", Offset = "0x105D050", VA = "0x105D050", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600687A")]
		[Address(RVA = "0x105D0F8", Offset = "0x105D0F8", VA = "0x105D0F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600687B")]
		[Address(RVA = "0x105D08C", Offset = "0x105D08C", VA = "0x105D08C")]
		private void DoATan()
		{
		}

		[Token(Token = "0x600687C")]
		[Address(RVA = "0x105D0FC", Offset = "0x105D0FC", VA = "0x105D0FC")]
		public GetAtan2FromVector2()
		{
		}
	}
}
