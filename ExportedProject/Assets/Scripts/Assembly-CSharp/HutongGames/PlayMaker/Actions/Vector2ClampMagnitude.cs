using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC684", Offset = "0x5AC684")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC684", Offset = "0x5AC684")]
	public class Vector2ClampMagnitude : FsmStateAction
	{
		[Token(Token = "0x40057ED")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609A74", Offset = "0x609A74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609A74", Offset = "0x609A74")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057EE")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609AD4", Offset = "0x609AD4")]
		public FsmFloat maxLength;

		[Token(Token = "0x40057EF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609B20", Offset = "0x609B20")]
		public bool everyFrame;

		[Token(Token = "0x6006B71")]
		[Address(RVA = "0x13C5EEC", Offset = "0x13C5EEC", VA = "0x13C5EEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B72")]
		[Address(RVA = "0x13C5EF8", Offset = "0x13C5EF8", VA = "0x13C5EF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B73")]
		[Address(RVA = "0x13C5F8C", Offset = "0x13C5F8C", VA = "0x13C5F8C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B74")]
		[Address(RVA = "0x13C5F34", Offset = "0x13C5F34", VA = "0x13C5F34")]
		private void DoVector2ClampMagnitude()
		{
		}

		[Token(Token = "0x6006B75")]
		[Address(RVA = "0x13C5F90", Offset = "0x13C5F90", VA = "0x13C5F90")]
		public Vector2ClampMagnitude()
		{
		}
	}
}
