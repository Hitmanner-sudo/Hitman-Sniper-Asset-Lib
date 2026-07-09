using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200125A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC594", Offset = "0x5AC594")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC594", Offset = "0x5AC594")]
	public class SetVector2XY : FsmStateAction
	{
		[Token(Token = "0x40057DF")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6096C0", Offset = "0x6096C0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6096C0", Offset = "0x6096C0")]
		public FsmVector2 vector2Variable;

		[Token(Token = "0x40057E0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609720", Offset = "0x609720")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609720", Offset = "0x609720")]
		public FsmVector2 vector2Value;

		[Token(Token = "0x40057E1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609770", Offset = "0x609770")]
		public FsmFloat x;

		[Token(Token = "0x40057E2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6097A8", Offset = "0x6097A8")]
		public FsmFloat y;

		[Token(Token = "0x40057E3")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6097E0", Offset = "0x6097E0")]
		public bool everyFrame;

		[Token(Token = "0x6006B62")]
		[Address(RVA = "0x83C2F0", Offset = "0x83C2F0", VA = "0x83C2F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B63")]
		[Address(RVA = "0x83C38C", Offset = "0x83C38C", VA = "0x83C38C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B64")]
		[Address(RVA = "0x83C478", Offset = "0x83C478", VA = "0x83C478", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B65")]
		[Address(RVA = "0x83C3C8", Offset = "0x83C3C8", VA = "0x83C3C8")]
		private void DoSetVector2XYZ()
		{
		}

		[Token(Token = "0x6006B66")]
		[Address(RVA = "0x83C47C", Offset = "0x83C47C", VA = "0x83C47C")]
		public SetVector2XY()
		{
		}
	}
}
