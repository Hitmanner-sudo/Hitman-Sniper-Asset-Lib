using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001015")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0470", Offset = "0x5A0470")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0470", Offset = "0x5A0470")]
	public class SetLightType : ComponentAction<Light>
	{
		[Token(Token = "0x4004B7C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAA8C", Offset = "0x5DAA8C")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DAA8C", Offset = "0x5DAA8C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B7D")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAB20", Offset = "0x5DAB20")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5DAB20", Offset = "0x5DAB20")]
		public FsmEnum lightType;

		[Token(Token = "0x600608F")]
		[Address(RVA = "0x103F50C", Offset = "0x103F50C", VA = "0x103F50C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006090")]
		[Address(RVA = "0x103F57C", Offset = "0x103F57C", VA = "0x103F57C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006091")]
		[Address(RVA = "0x103F5A4", Offset = "0x103F5A4", VA = "0x103F5A4")]
		private void DoSetLightType()
		{
		}

		[Token(Token = "0x6006092")]
		[Address(RVA = "0x103F6A0", Offset = "0x103F6A0", VA = "0x103F6A0")]
		public SetLightType()
		{
		}
	}
}
