using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200119B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8D24", Offset = "0x5A8D24")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8D24", Offset = "0x5A8D24")]
	public class ScaleTime : FsmStateAction
	{
		[Token(Token = "0x40053BE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB1BC", Offset = "0x5FB1BC")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FB1BC", Offset = "0x5FB1BC")]
		[RequiredField]
		public FsmFloat timeScale;

		[Token(Token = "0x40053BF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB220", Offset = "0x5FB220")]
		public FsmBool adjustFixedDeltaTime;

		[Token(Token = "0x40053C0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB258", Offset = "0x5FB258")]
		public bool everyFrame;

		[Token(Token = "0x60067B5")]
		[Address(RVA = "0xBB1E08", Offset = "0xBB1E08", VA = "0xBB1E08", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067B6")]
		[Address(RVA = "0xBB1E48", Offset = "0xBB1E48", VA = "0xBB1E48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067B7")]
		[Address(RVA = "0xBB1EF4", Offset = "0xBB1EF4", VA = "0xBB1EF4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067B8")]
		[Address(RVA = "0xBB1E84", Offset = "0xBB1E84", VA = "0xBB1E84")]
		private void DoTimeScale()
		{
		}

		[Token(Token = "0x60067B9")]
		[Address(RVA = "0xBB1EF8", Offset = "0xBB1EF8", VA = "0xBB1EF8")]
		public ScaleTime()
		{
		}
	}
}
