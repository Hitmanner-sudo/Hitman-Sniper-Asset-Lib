using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001256")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC454", Offset = "0x5AC454")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC454", Offset = "0x5AC454")]
	public class GetVector2Length : FsmStateAction
	{
		[Token(Token = "0x40057D2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609290", Offset = "0x609290")]
		public FsmVector2 vector2;

		[Token(Token = "0x40057D3")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x6092C8", Offset = "0x6092C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6092C8", Offset = "0x6092C8")]
		public FsmFloat storeLength;

		[Token(Token = "0x40057D4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609328", Offset = "0x609328")]
		public bool everyFrame;

		[Token(Token = "0x6006B50")]
		[Address(RVA = "0xC80C80", Offset = "0xC80C80", VA = "0xC80C80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B51")]
		[Address(RVA = "0xC80C8C", Offset = "0xC80C8C", VA = "0xC80C8C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B52")]
		[Address(RVA = "0xC80D0C", Offset = "0xC80D0C", VA = "0xC80D0C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B53")]
		[Address(RVA = "0xC80CC8", Offset = "0xC80CC8", VA = "0xC80CC8")]
		private void DoVectorLength()
		{
		}

		[Token(Token = "0x6006B54")]
		[Address(RVA = "0xC80D10", Offset = "0xC80D10", VA = "0xC80D10")]
		public GetVector2Length()
		{
		}
	}
}
