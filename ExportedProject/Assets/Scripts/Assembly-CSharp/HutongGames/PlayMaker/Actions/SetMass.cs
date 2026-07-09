using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001085")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A27D4", Offset = "0x5A27D4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A27D4", Offset = "0x5A27D4")]
	public class SetMass : ComponentAction<Rigidbody>
	{
		[Token(Token = "0x4004DB9")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4360", Offset = "0x5E4360")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4360", Offset = "0x5E4360")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DBA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E43F4", Offset = "0x5E43F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E43F4", Offset = "0x5E43F4")]
		[RequiredField]
		public FsmFloat mass;

		[Token(Token = "0x60062A8")]
		[Address(RVA = "0x103F840", Offset = "0x103F840", VA = "0x103F840", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062A9")]
		[Address(RVA = "0x103F870", Offset = "0x103F870", VA = "0x103F870", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062AA")]
		[Address(RVA = "0x103F898", Offset = "0x103F898", VA = "0x103F898")]
		private void DoSetMass()
		{
		}

		[Token(Token = "0x60062AB")]
		[Address(RVA = "0x103F958", Offset = "0x103F958", VA = "0x103F958")]
		public SetMass()
		{
		}
	}
}
