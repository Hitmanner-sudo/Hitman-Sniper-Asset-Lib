using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001041")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A13E0", Offset = "0x5A13E0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A13E0", Offset = "0x5A13E0")]
	public class SetMaterialTexture : ComponentAction<Renderer>
	{
		[Token(Token = "0x4004C5C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DE7BC", Offset = "0x5DE7BC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE7BC", Offset = "0x5DE7BC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004C5D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE840", Offset = "0x5DE840")]
		public FsmInt materialIndex;

		[Token(Token = "0x4004C5E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE878", Offset = "0x5DE878")]
		public FsmMaterial material;

		[Token(Token = "0x4004C5F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DE8B0", Offset = "0x5DE8B0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE8B0", Offset = "0x5DE8B0")]
		public FsmString namedTexture;

		[Token(Token = "0x4004C60")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DE900", Offset = "0x5DE900")]
		public FsmTexture texture;

		[Token(Token = "0x6006164")]
		[Address(RVA = "0x10405B0", Offset = "0x10405B0", VA = "0x10405B0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006165")]
		[Address(RVA = "0x1040618", Offset = "0x1040618", VA = "0x1040618", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006166")]
		[Address(RVA = "0x1040640", Offset = "0x1040640", VA = "0x1040640")]
		private void DoSetMaterialTexture()
		{
		}

		[Token(Token = "0x6006167")]
		[Address(RVA = "0x104095C", Offset = "0x104095C", VA = "0x104095C")]
		public SetMaterialTexture()
		{
		}
	}
}
