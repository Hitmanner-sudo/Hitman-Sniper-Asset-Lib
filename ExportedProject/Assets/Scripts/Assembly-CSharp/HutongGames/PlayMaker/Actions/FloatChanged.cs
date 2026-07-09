using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001021")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A07E0", Offset = "0x5A07E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A07E0", Offset = "0x5A07E0")]
	public class FloatChanged : FsmStateAction
	{
		[Token(Token = "0x4004BAF")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB848", Offset = "0x5DB848")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB848", Offset = "0x5DB848")]
		public FsmFloat floatVariable;

		[Token(Token = "0x4004BB0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB8A8", Offset = "0x5DB8A8")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004BB1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB8E0", Offset = "0x5DB8E0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB8E0", Offset = "0x5DB8E0")]
		public FsmBool storeResult;

		[Token(Token = "0x4004BB2")]
		[FieldOffset(Offset = "0x68")]
		private float previousValue;

		[Token(Token = "0x60060C5")]
		[Address(RVA = "0x958BEC", Offset = "0x958BEC", VA = "0x958BEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060C6")]
		[Address(RVA = "0x958BF8", Offset = "0x958BF8", VA = "0x958BF8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060C7")]
		[Address(RVA = "0x958C54", Offset = "0x958C54", VA = "0x958C54", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060C8")]
		[Address(RVA = "0x958CDC", Offset = "0x958CDC", VA = "0x958CDC")]
		public FloatChanged()
		{
		}
	}
}
