using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0290", Offset = "0x5A0290")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0290", Offset = "0x5A0290")]
	public class SetLightColor : ComponentAction<Light>
	{
		[Token(Token = "0x4004B6C")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA4D0", Offset = "0x5DA4D0")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA4D0", Offset = "0x5DA4D0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B6D")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA564", Offset = "0x5DA564")]
		public FsmColor lightColor;

		[Token(Token = "0x4004B6E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA5B0", Offset = "0x5DA5B0")]
		public bool everyFrame;

		[Token(Token = "0x6006073")]
		[Address(RVA = "0x103ECB0", Offset = "0x103ECB0", VA = "0x103ECB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006074")]
		[Address(RVA = "0x103ECE8", Offset = "0x103ECE8", VA = "0x103ECE8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006075")]
		[Address(RVA = "0x103EDD8", Offset = "0x103EDD8", VA = "0x103EDD8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006076")]
		[Address(RVA = "0x103ED24", Offset = "0x103ED24", VA = "0x103ED24")]
		private void DoSetLightColor()
		{
		}

		[Token(Token = "0x6006077")]
		[Address(RVA = "0x103EDDC", Offset = "0x103EDDC", VA = "0x103EDDC")]
		public SetLightColor()
		{
		}
	}
}
