using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200126D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ACB34", Offset = "0x5ACB34")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ACB34", Offset = "0x5ACB34")]
	public class GetVector3XYZ : FsmStateAction
	{
		[Token(Token = "0x4005831")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A938", Offset = "0x60A938")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A938", Offset = "0x60A938")]
		public FsmVector3 vector3Variable;

		[Token(Token = "0x4005832")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A998", Offset = "0x60A998")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A998", Offset = "0x60A998")]
		public FsmFloat storeX;

		[Token(Token = "0x4005833")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60A9E8", Offset = "0x60A9E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60A9E8", Offset = "0x60A9E8")]
		public FsmFloat storeY;

		[Token(Token = "0x4005834")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AA38", Offset = "0x60AA38")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60AA38", Offset = "0x60AA38")]
		public FsmFloat storeZ;

		[Token(Token = "0x4005835")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60AA88", Offset = "0x60AA88")]
		public bool everyFrame;

		[Token(Token = "0x6006BB2")]
		[Address(RVA = "0xC80DB0", Offset = "0xC80DB0", VA = "0xC80DB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006BB3")]
		[Address(RVA = "0xC80DC0", Offset = "0xC80DC0", VA = "0xC80DC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006BB4")]
		[Address(RVA = "0xC80E70", Offset = "0xC80E70", VA = "0xC80E70", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006BB5")]
		[Address(RVA = "0xC80DFC", Offset = "0xC80DFC", VA = "0xC80DFC")]
		private void DoGetVector3XYZ()
		{
		}

		[Token(Token = "0x6006BB6")]
		[Address(RVA = "0xC80E74", Offset = "0xC80E74", VA = "0xC80E74")]
		public GetVector3XYZ()
		{
		}
	}
}
