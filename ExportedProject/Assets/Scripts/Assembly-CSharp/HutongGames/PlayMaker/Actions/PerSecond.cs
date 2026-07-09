using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001199")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8C84", Offset = "0x5A8C84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8C84", Offset = "0x5A8C84")]
	public class PerSecond : FsmStateAction
	{
		[Token(Token = "0x40053B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FAFD0", Offset = "0x5FAFD0")]
		[RequiredField]
		public FsmFloat floatValue;

		[Token(Token = "0x40053B5")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB01C", Offset = "0x5FB01C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FB01C", Offset = "0x5FB01C")]
		public FsmFloat storeResult;

		[Token(Token = "0x40053B6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB07C", Offset = "0x5FB07C")]
		public bool everyFrame;

		[Token(Token = "0x60067AC")]
		[Address(RVA = "0x8FD17C", Offset = "0x8FD17C", VA = "0x8FD17C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067AD")]
		[Address(RVA = "0x8FD188", Offset = "0x8FD188", VA = "0x8FD188", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067AE")]
		[Address(RVA = "0x8FD214", Offset = "0x8FD214", VA = "0x8FD214", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067AF")]
		[Address(RVA = "0x8FD1C4", Offset = "0x8FD1C4", VA = "0x8FD1C4")]
		private void DoPerSecond()
		{
		}

		[Token(Token = "0x60067B0")]
		[Address(RVA = "0x8FD218", Offset = "0x8FD218", VA = "0x8FD218")]
		public PerSecond()
		{
		}
	}
}
