using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FD18", Offset = "0x59FD18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FD18", Offset = "0x59FD18")]
	public class GetMouseButtonUp : FsmStateAction
	{
		[Token(Token = "0x4004B0B")]
		[FieldOffset(Offset = "0x4C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8E90", Offset = "0x5D8E90")]
		public MouseButton button;

		[Token(Token = "0x4004B0C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8EDC", Offset = "0x5D8EDC")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B0D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8F14", Offset = "0x5D8F14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8F14", Offset = "0x5D8F14")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B0E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8F64", Offset = "0x5D8F64")]
		public bool inUpdateOnly;

		[Token(Token = "0x600602E")]
		[Address(RVA = "0x1064A14", Offset = "0x1064A14", VA = "0x1064A14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600602F")]
		[Address(RVA = "0x1064A2C", Offset = "0x1064A2C", VA = "0x1064A2C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006030")]
		[Address(RVA = "0x1064A98", Offset = "0x1064A98", VA = "0x1064A98", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006031")]
		[Address(RVA = "0x1064A3C", Offset = "0x1064A3C", VA = "0x1064A3C")]
		public void DoGetMouseButtonUp()
		{
		}

		[Token(Token = "0x6006032")]
		[Address(RVA = "0x1064A9C", Offset = "0x1064A9C", VA = "0x1064A9C")]
		public GetMouseButtonUp()
		{
		}
	}
}
