using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A12A0", Offset = "0x5A12A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A12A0", Offset = "0x5A12A0")]
	public class GetMaterialTexture : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C48")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE140", Offset = "0x5DE140")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DE140", Offset = "0x5DE140")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C49")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE1D4", Offset = "0x5DE1D4")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C4A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE20C", Offset = "0x5DE20C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE20C", Offset = "0x5DE20C")]
		public FsmString namedTexture;

		[Token(Token = "0x4004C4B")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5DE25C", Offset = "0x5DE25C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE25C", Offset = "0x5DE25C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE25C", Offset = "0x5DE25C")]
		public FsmTexture storedTexture;

		[Token(Token = "0x4004C4C")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE2E0", Offset = "0x5DE2E0")]
		public bool getFromSharedMaterial;

		[Token(Token = "0x6006152")]
		[Address(RVA = "0x1064394", Offset = "0x1064394", VA = "0x1064394", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006153")]
		[Address(RVA = "0x1064400", Offset = "0x1064400", VA = "0x1064400", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006154")]
		[Address(RVA = "0x1064428", Offset = "0x1064428", VA = "0x1064428")]
		private void DoGetMaterialTexture()
		{
		}

		[Token(Token = "0x6006155")]
		[Address(RVA = "0x1064758", Offset = "0x1064758", VA = "0x1064758")]
		public GetMaterialTexture()
		{
		}
	}
}
