using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001042")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1430", Offset = "0x5A1430")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1430", Offset = "0x5A1430")]
	public class SetMaterialValue : FsmStateAction
	{
		[Token(Token = "0x4004C61")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE938", Offset = "0x5DE938")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE938", Offset = "0x5DE938")]
		public FsmMaterial materialVariable;

		[Token(Token = "0x4004C62")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE998", Offset = "0x5DE998")]
		public FsmMaterial materialValue;

		[Token(Token = "0x4004C63")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE9E4", Offset = "0x5DE9E4")]
		public bool everyFrame;

		[Token(Token = "0x6006168")]
		[Address(RVA = "0x10409A8", Offset = "0x10409A8", VA = "0x10409A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006169")]
		[Address(RVA = "0x10409B4", Offset = "0x10409B4", VA = "0x10409B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600616A")]
		[Address(RVA = "0x1040A18", Offset = "0x1040A18", VA = "0x1040A18", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600616B")]
		[Address(RVA = "0x1040A5C", Offset = "0x1040A5C", VA = "0x1040A5C")]
		public SetMaterialValue()
		{
		}
	}
}
