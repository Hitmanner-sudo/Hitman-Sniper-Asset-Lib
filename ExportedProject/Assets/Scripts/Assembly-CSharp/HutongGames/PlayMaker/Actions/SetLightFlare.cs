using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001011")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0330", Offset = "0x5A0330")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0330", Offset = "0x5A0330")]
	public class SetLightFlare : ComponentAction<Light>
	{
		[Token(Token = "0x4004B71")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA6B4", Offset = "0x5DA6B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA6B4", Offset = "0x5DA6B4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B72")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA748", Offset = "0x5DA748")]
		public Flare lightFlare;

		[Token(Token = "0x600607C")]
		[Address(RVA = "0x103EF68", Offset = "0x103EF68", VA = "0x103EF68", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600607D")]
		[Address(RVA = "0x103EF70", Offset = "0x103EF70", VA = "0x103EF70", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600607E")]
		[Address(RVA = "0x103EF98", Offset = "0x103EF98", VA = "0x103EF98")]
		private void DoSetLightRange()
		{
		}

		[Token(Token = "0x600607F")]
		[Address(RVA = "0x103F040", Offset = "0x103F040", VA = "0x103F040")]
		public SetLightFlare()
		{
		}
	}
}
