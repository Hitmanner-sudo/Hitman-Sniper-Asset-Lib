using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001014")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0420", Offset = "0x5A0420")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0420", Offset = "0x5A0420")]
	public class SetLightSpotAngle : ComponentAction<Light>
	{
		[Token(Token = "0x4004B79")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA988", Offset = "0x5DA988")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA988", Offset = "0x5DA988")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B7A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAA1C", Offset = "0x5DAA1C")]
		public FsmFloat lightSpotAngle;

		[Token(Token = "0x4004B7B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAA54", Offset = "0x5DAA54")]
		public bool everyFrame;

		[Token(Token = "0x600608A")]
		[Address(RVA = "0x103F38C", Offset = "0x103F38C", VA = "0x103F38C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600608B")]
		[Address(RVA = "0x103F3C0", Offset = "0x103F3C0", VA = "0x103F3C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600608C")]
		[Address(RVA = "0x103F4BC", Offset = "0x103F4BC", VA = "0x103F4BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600608D")]
		[Address(RVA = "0x103F3FC", Offset = "0x103F3FC", VA = "0x103F3FC")]
		private void DoSetLightRange()
		{
		}

		[Token(Token = "0x600608E")]
		[Address(RVA = "0x103F4C0", Offset = "0x103F4C0", VA = "0x103F4C0")]
		public SetLightSpotAngle()
		{
		}
	}
}
