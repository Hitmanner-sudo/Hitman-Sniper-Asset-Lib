using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001104")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A525C", Offset = "0x5A525C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A525C", Offset = "0x5A525C")]
	public class SetFogDensity : FsmStateAction
	{
		[Token(Token = "0x400508D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0314", Offset = "0x5F0314")]
		public FsmFloat fogDensity;

		[Token(Token = "0x400508E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F0360", Offset = "0x5F0360")]
		public bool everyFrame;

		[Token(Token = "0x6006530")]
		[Address(RVA = "0x1039B60", Offset = "0x1039B60", VA = "0x1039B60", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006531")]
		[Address(RVA = "0x1039B90", Offset = "0x1039B90", VA = "0x1039B90", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006532")]
		[Address(RVA = "0x1039BF4", Offset = "0x1039BF4", VA = "0x1039BF4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006533")]
		[Address(RVA = "0x1039BCC", Offset = "0x1039BCC", VA = "0x1039BCC")]
		private void DoSetFogDensity()
		{
		}

		[Token(Token = "0x6006534")]
		[Address(RVA = "0x1039BF8", Offset = "0x1039BF8", VA = "0x1039BF8")]
		public SetFogDensity()
		{
		}
	}
}
