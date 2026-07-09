using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001016")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A04C0", Offset = "0x5A04C0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A04C0", Offset = "0x5A04C0")]
	public class SetShadowStrength : ComponentAction<Light>
	{
		[Token(Token = "0x4004B7E")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DABA4", Offset = "0x5DABA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DABA4", Offset = "0x5DABA4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B7F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAC38", Offset = "0x5DAC38")]
		public FsmFloat shadowStrength;

		[Token(Token = "0x4004B80")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAC70", Offset = "0x5DAC70")]
		public bool everyFrame;

		[Token(Token = "0x6006093")]
		[Address(RVA = "0x1044D64", Offset = "0x1044D64", VA = "0x1044D64", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006094")]
		[Address(RVA = "0x1044D9C", Offset = "0x1044D9C", VA = "0x1044D9C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006095")]
		[Address(RVA = "0x1044E98", Offset = "0x1044E98", VA = "0x1044E98", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006096")]
		[Address(RVA = "0x1044DD8", Offset = "0x1044DD8", VA = "0x1044DD8")]
		private void DoSetShadowStrength()
		{
		}

		[Token(Token = "0x6006097")]
		[Address(RVA = "0x1044E9C", Offset = "0x1044E9C", VA = "0x1044E9C")]
		public SetShadowStrength()
		{
		}
	}
}
