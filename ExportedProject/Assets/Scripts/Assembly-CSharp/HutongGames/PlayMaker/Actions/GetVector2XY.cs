using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001257")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC4A4", Offset = "0x5AC4A4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC4A4", Offset = "0x5AC4A4")]
	public class GetVector2XY : FsmStateAction
	{
		[Token(Token = "0x40057D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609360", Offset = "0x609360")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609360", Offset = "0x609360")]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6093C0", Offset = "0x6093C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6093C0", Offset = "0x6093C0")]
		public FsmFloat storeX;

		[Token(Token = "0x40057D7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609410", Offset = "0x609410")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609410", Offset = "0x609410")]
		public FsmFloat storeY;

		[Token(Token = "0x40057D8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609460", Offset = "0x609460")]
		public bool everyFrame;

		[Token(Token = "0x6006B55")]
		[Address(RVA = "0xC80D18", Offset = "0xC80D18", VA = "0xC80D18", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B56")]
		[Address(RVA = "0xC80D28", Offset = "0xC80D28", VA = "0xC80D28", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B57")]
		[Address(RVA = "0xC80DA4", Offset = "0xC80DA4", VA = "0xC80DA4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B58")]
		[Address(RVA = "0xC80D64", Offset = "0xC80D64", VA = "0xC80D64")]
		private void DoGetVector2XYZ()
		{
		}

		[Token(Token = "0x6006B59")]
		[Address(RVA = "0xC80DA8", Offset = "0xC80DA8", VA = "0xC80DA8")]
		public GetVector2XY()
		{
		}
	}
}
