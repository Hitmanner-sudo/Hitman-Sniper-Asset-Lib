using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010C3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3C74", Offset = "0x5A3C74")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3C74", Offset = "0x5A3C74")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x5A3C74", Offset = "0x5A3C74")]
	public class RebuildTextures : FsmStateAction
	{
		[Token(Token = "0x4004F37")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAC40", Offset = "0x5EAC40")]
		public FsmMaterial substanceMaterial;

		[Token(Token = "0x4004F38")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EAC8C", Offset = "0x5EAC8C")]
		public FsmBool immediately;

		[Token(Token = "0x4004F39")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EACD8", Offset = "0x5EACD8")]
		public bool everyFrame;

		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xB424B0", Offset = "0xB424B0", VA = "0xB424B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60063E8")]
		[Address(RVA = "0xB424E4", Offset = "0xB424E4", VA = "0xB424E4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xB424FC", Offset = "0xB424FC", VA = "0xB424FC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60063EA")]
		[Address(RVA = "0xB424F8", Offset = "0xB424F8", VA = "0xB424F8")]
		private void DoRebuildTextures()
		{
		}

		[Token(Token = "0x60063EB")]
		[Address(RVA = "0xB42500", Offset = "0xB42500", VA = "0xB42500")]
		public RebuildTextures()
		{
		}
	}
}
