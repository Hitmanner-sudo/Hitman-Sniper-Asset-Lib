using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001034")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0FD0", Offset = "0x5A0FD0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0FD0", Offset = "0x5A0FD0")]
	public class ObjectCompare : FsmStateAction
	{
		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD3CC", Offset = "0x5DD3CC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD3CC", Offset = "0x5DD3CC")]
		[Readonly]
		public FsmObject objectVariable;

		[Token(Token = "0x4004C19")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD43C", Offset = "0x5DD43C")]
		public FsmObject compareTo;

		[Token(Token = "0x4004C1A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD488", Offset = "0x5DD488")]
		public FsmEvent equalEvent;

		[Token(Token = "0x4004C1B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD4C0", Offset = "0x5DD4C0")]
		public FsmEvent notEqualEvent;

		[Token(Token = "0x4004C1C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD4F8", Offset = "0x5DD4F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD4F8", Offset = "0x5DD4F8")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C1D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD548", Offset = "0x5DD548")]
		public bool everyFrame;

		[Token(Token = "0x6006124")]
		[Address(RVA = "0x9E9A28", Offset = "0x9E9A28", VA = "0x9E9A28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006125")]
		[Address(RVA = "0x9E9A3C", Offset = "0x9E9A3C", VA = "0x9E9A3C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006126")]
		[Address(RVA = "0x9E9B54", Offset = "0x9E9B54", VA = "0x9E9B54", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006127")]
		[Address(RVA = "0x9E9A78", Offset = "0x9E9A78", VA = "0x9E9A78")]
		private void DoObjectCompare()
		{
		}

		[Token(Token = "0x6006128")]
		[Address(RVA = "0x9E9B58", Offset = "0x9E9B58", VA = "0x9E9B58")]
		public ObjectCompare()
		{
		}
	}
}
