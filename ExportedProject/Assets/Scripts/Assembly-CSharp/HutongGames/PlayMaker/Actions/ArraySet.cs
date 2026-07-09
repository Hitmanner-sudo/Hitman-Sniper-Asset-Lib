using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B7A0", Offset = "0x59B7A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B7A0", Offset = "0x59B7A0")]
	public class ArraySet : FsmStateAction
	{
		[Token(Token = "0x4004761")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CAB44", Offset = "0x5CAB44")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAB44", Offset = "0x5CAB44")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x4004762")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CABA4", Offset = "0x5CABA4")]
		public FsmInt index;

		[Token(Token = "0x4004763")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CABDC", Offset = "0x5CABDC")]
		[RequiredField]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CABDC", Offset = "0x5CABDC")]
		public FsmVar value;

		[Token(Token = "0x4004764")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAC4C", Offset = "0x5CAC4C")]
		public bool everyFrame;

		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAC84", Offset = "0x5CAC84")]
		[Attribute(Name = "ActionSection", RVA = "0x5CAC84", Offset = "0x5CAC84")]
		public FsmEvent indexOutOfRange;

		[Token(Token = "0x6005CD3")]
		[Address(RVA = "0xBFD970", Offset = "0xBFD970", VA = "0xBFD970", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CD4")]
		[Address(RVA = "0xBFD984", Offset = "0xBFD984", VA = "0xBFD984", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CD5")]
		[Address(RVA = "0xBFDAB0", Offset = "0xBFDAB0", VA = "0xBFDAB0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0xBFD9C0", Offset = "0xBFD9C0", VA = "0xBFD9C0")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6005CD7")]
		[Address(RVA = "0xBFDAB4", Offset = "0xBFDAB4", VA = "0xBFDAB4")]
		public ArraySet()
		{
		}
	}
}
