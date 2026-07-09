using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001022")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0830", Offset = "0x5A0830")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0830", Offset = "0x5A0830")]
	public class FloatCompare : FsmStateAction
	{
		[Token(Token = "0x4004BB3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB930", Offset = "0x5DB930")]
		[RequiredField]
		public FsmFloat float1;

		[Token(Token = "0x4004BB4")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB97C", Offset = "0x5DB97C")]
		public FsmFloat float2;

		[Token(Token = "0x4004BB5")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB9C8", Offset = "0x5DB9C8")]
		[RequiredField]
		public FsmFloat tolerance;

		[Token(Token = "0x4004BB6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBA14", Offset = "0x5DBA14")]
		public FsmEvent equal;

		[Token(Token = "0x4004BB7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBA4C", Offset = "0x5DBA4C")]
		public FsmEvent lessThan;

		[Token(Token = "0x4004BB8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBA84", Offset = "0x5DBA84")]
		public FsmEvent greaterThan;

		[Token(Token = "0x4004BB9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DBABC", Offset = "0x5DBABC")]
		public bool everyFrame;

		[Token(Token = "0x60060C9")]
		[Address(RVA = "0x958DB8", Offset = "0x958DB8", VA = "0x958DB8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060CA")]
		[Address(RVA = "0x958E0C", Offset = "0x958E0C", VA = "0x958E0C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060CB")]
		[Address(RVA = "0x958F48", Offset = "0x958F48", VA = "0x958F48", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060CC")]
		[Address(RVA = "0x958E48", Offset = "0x958E48", VA = "0x958E48")]
		private void DoCompare()
		{
		}

		[Token(Token = "0x60060CD")]
		[Address(RVA = "0x958F4C", Offset = "0x958F4C", VA = "0x958F4C", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x60060CE")]
		[Address(RVA = "0x95904C", Offset = "0x95904C", VA = "0x95904C")]
		public FloatCompare()
		{
		}
	}
}
