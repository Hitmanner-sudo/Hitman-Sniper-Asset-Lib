using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACB84", Offset = "0x5ACB84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACB84", Offset = "0x5ACB84")]
	public class GetVectorLength : FsmStateAction
	{
		[Token(Token = "0x4005836")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AAC0", Offset = "0x60AAC0")]
		public FsmVector3 vector3;

		[Token(Token = "0x4005837")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60AAF8", Offset = "0x60AAF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AAF8", Offset = "0x60AAF8")]
		public FsmFloat storeLength;

		[Token(Token = "0x4005838")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AB58", Offset = "0x60AB58")]
		public bool everyFrame;

		[Token(Token = "0x6006BB7")]
		[Address(RVA = "0xC80E7C", Offset = "0xC80E7C", VA = "0xC80E7C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BB8")]
		[Address(RVA = "0xC80E88", Offset = "0xC80E88", VA = "0xC80E88", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BB9")]
		[Address(RVA = "0xC80F20", Offset = "0xC80F20", VA = "0xC80F20", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BBA")]
		[Address(RVA = "0xC80EC4", Offset = "0xC80EC4", VA = "0xC80EC4")]
		private void DoVectorLength()
		{
		}

		[Token(Token = "0x6006BBB")]
		[Address(RVA = "0xC80F24", Offset = "0xC80F24", VA = "0xC80F24")]
		public GetVectorLength()
		{
		}
	}
}
