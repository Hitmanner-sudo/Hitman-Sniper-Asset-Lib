using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200103C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1250", Offset = "0x5A1250")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1250", Offset = "0x5A1250")]
	public class GetMaterial : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C44")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DDFDC", Offset = "0x5DDFDC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDFDC", Offset = "0x5DDFDC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C45")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE070", Offset = "0x5DE070")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C46")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE0A8", Offset = "0x5DE0A8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE0A8", Offset = "0x5DE0A8")]
		public FsmMaterial material;

		[Token(Token = "0x4004C47")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE108", Offset = "0x5DE108")]
		public bool getSharedMaterial;

		[Token(Token = "0x600614E")]
		[Address(RVA = "0x1064018", Offset = "0x1064018", VA = "0x1064018", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600614F")]
		[Address(RVA = "0x1064050", Offset = "0x1064050", VA = "0x1064050", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006150")]
		[Address(RVA = "0x1064078", Offset = "0x1064078", VA = "0x1064078")]
		private void DoGetMaterial()
		{
		}

		[Token(Token = "0x6006151")]
		[Address(RVA = "0x1064348", Offset = "0x1064348", VA = "0x1064348")]
		public GetMaterial()
		{
		}
	}
}
