using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001012")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0380", Offset = "0x5A0380")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0380", Offset = "0x5A0380")]
	public class SetLightIntensity : ComponentAction<Light>
	{
		[Token(Token = "0x4004B73")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA780", Offset = "0x5DA780")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5DA780", Offset = "0x5DA780")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004B74")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA814", Offset = "0x5DA814")]
		public FsmFloat lightIntensity;

		[Token(Token = "0x4004B75")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA84C", Offset = "0x5DA84C")]
		public bool everyFrame;

		[Token(Token = "0x6006080")]
		[Address(RVA = "0x103F08C", Offset = "0x103F08C", VA = "0x103F08C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006081")]
		[Address(RVA = "0x103F0C0", Offset = "0x103F0C0", VA = "0x103F0C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006082")]
		[Address(RVA = "0x103F1BC", Offset = "0x103F1BC", VA = "0x103F1BC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006083")]
		[Address(RVA = "0x103F0FC", Offset = "0x103F0FC", VA = "0x103F0FC")]
		private void DoSetLightIntensity()
		{
		}

		[Token(Token = "0x6006084")]
		[Address(RVA = "0x103F1C0", Offset = "0x103F1C0", VA = "0x103F1C0")]
		public SetLightIntensity()
		{
		}
	}
}
