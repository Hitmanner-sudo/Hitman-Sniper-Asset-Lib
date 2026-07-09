using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011BD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9748", Offset = "0x5A9748")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9748", Offset = "0x5A9748")]
	public class GetAtan2 : FsmStateAction
	{
		[Token(Token = "0x40054B6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE78C", Offset = "0x5FE78C")]
		[RequiredField]
		public FsmFloat xValue;

		[Token(Token = "0x40054B7")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE7D8", Offset = "0x5FE7D8")]
		public FsmFloat yValue;

		[Token(Token = "0x40054B8")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FE824", Offset = "0x5FE824")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE824", Offset = "0x5FE824")]
		public FsmFloat angle;

		[Token(Token = "0x40054B9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE884", Offset = "0x5FE884")]
		public FsmBool RadToDeg;

		[Token(Token = "0x40054BA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FE8BC", Offset = "0x5FE8BC")]
		public bool everyFrame;

		[Token(Token = "0x6006873")]
		[Address(RVA = "0x105CF14", Offset = "0x105CF14", VA = "0x105CF14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006874")]
		[Address(RVA = "0x105CF48", Offset = "0x105CF48", VA = "0x105CF48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006875")]
		[Address(RVA = "0x105D010", Offset = "0x105D010", VA = "0x105D010", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006876")]
		[Address(RVA = "0x105CF84", Offset = "0x105CF84", VA = "0x105CF84")]
		private void DoATan()
		{
		}

		[Token(Token = "0x6006877")]
		[Address(RVA = "0x105D014", Offset = "0x105D014", VA = "0x105D014")]
		public GetAtan2()
		{
		}
	}
}
