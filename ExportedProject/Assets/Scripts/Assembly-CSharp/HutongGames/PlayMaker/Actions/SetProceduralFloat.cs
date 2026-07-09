using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3E00", Offset = "0x5A3E00")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3E00", Offset = "0x5A3E00")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3E00", Offset = "0x5A3E00")]
	public class SetProceduralFloat : FsmStateAction
	{
		[Token(Token = "0x4004F42")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAF48", Offset = "0x5EAF48")]
		[RequiredField]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F43")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAF94", Offset = "0x5EAF94")]
		public FsmString floatProperty;

		[Token(Token = "0x4004F44")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAFE0", Offset = "0x5EAFE0")]
		public FsmFloat floatValue;

		[Token(Token = "0x4004F45")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB02C", Offset = "0x5EB02C")]
		public bool everyFrame;

		[Token(Token = "0x60063F6")]
		[Address(RVA = "0x10429E4", Offset = "0x10429E4", VA = "0x10429E4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063F7")]
		[Address(RVA = "0x1042A50", Offset = "0x1042A50", VA = "0x1042A50", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063F8")]
		[Address(RVA = "0x1042A68", Offset = "0x1042A68", VA = "0x1042A68", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063F9")]
		[Address(RVA = "0x1042A64", Offset = "0x1042A64", VA = "0x1042A64")]
		private void DoSetProceduralFloat()
		{
		}

		[Token(Token = "0x60063FA")]
		[Address(RVA = "0x1042A6C", Offset = "0x1042A6C", VA = "0x1042A6C")]
		public SetProceduralFloat()
		{
		}
	}
}
