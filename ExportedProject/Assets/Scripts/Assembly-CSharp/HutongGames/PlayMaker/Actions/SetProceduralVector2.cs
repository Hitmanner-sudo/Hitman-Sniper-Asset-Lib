using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3E84", Offset = "0x5A3E84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3E84", Offset = "0x5A3E84")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3E84", Offset = "0x5A3E84")]
	public class SetProceduralVector2 : FsmStateAction
	{
		[Token(Token = "0x4004F46")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB064", Offset = "0x5EB064")]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F47")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB0B0", Offset = "0x5EB0B0")]
		public FsmString vector2Property;

		[Token(Token = "0x4004F48")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB0FC", Offset = "0x5EB0FC")]
		[RequiredField]
		public FsmVector2 vector2Value;

		[Token(Token = "0x4004F49")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB148", Offset = "0x5EB148")]
		public bool everyFrame;

		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x1042A74", Offset = "0x1042A74", VA = "0x1042A74", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x1042A84", Offset = "0x1042A84", VA = "0x1042A84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x1042A9C", Offset = "0x1042A9C", VA = "0x1042A9C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x1042A98", Offset = "0x1042A98", VA = "0x1042A98")]
		private void DoSetProceduralVector()
		{
		}

		[Token(Token = "0x60063FF")]
		[Address(RVA = "0x1042AA0", Offset = "0x1042AA0", VA = "0x1042AA0")]
		public SetProceduralVector2()
		{
		}
	}
}
