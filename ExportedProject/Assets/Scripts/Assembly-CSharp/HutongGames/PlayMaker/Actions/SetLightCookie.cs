using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001010")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A02E0", Offset = "0x5A02E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A02E0", Offset = "0x5A02E0")]
	public class SetLightCookie : ComponentAction<Light>
	{
		[Token(Token = "0x4004B6F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA5E8", Offset = "0x5DA5E8")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA5E8", Offset = "0x5DA5E8")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B70")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA67C", Offset = "0x5DA67C")]
		public FsmTexture lightCookie;

		[Token(Token = "0x6006078")]
		[Address(RVA = "0x103EE28", Offset = "0x103EE28", VA = "0x103EE28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006079")]
		[Address(RVA = "0x103EE30", Offset = "0x103EE30", VA = "0x103EE30", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600607A")]
		[Address(RVA = "0x103EE58", Offset = "0x103EE58", VA = "0x103EE58")]
		private void DoSetLightCookie()
		{
		}

		[Token(Token = "0x600607B")]
		[Address(RVA = "0x103EF1C", Offset = "0x103EF1C", VA = "0x103EF1C")]
		public SetLightCookie()
		{
		}
	}
}
