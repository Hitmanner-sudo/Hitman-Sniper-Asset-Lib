using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AA")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A33D0", Offset = "0x5A33D0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A33D0", Offset = "0x5A33D0")]
	public class SetGravity2dScale : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004ED3")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E8F34", Offset = "0x5E8F34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8F34", Offset = "0x5E8F34")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004ED4")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8FC8", Offset = "0x5E8FC8")]
		public FsmFloat gravityScale;

		[Token(Token = "0x6006377")]
		[Address(RVA = "0x103DD84", Offset = "0x103DD84", VA = "0x103DD84", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006378")]
		[Address(RVA = "0x103DDB4", Offset = "0x103DDB4", VA = "0x103DDB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006379")]
		[Address(RVA = "0x103DDDC", Offset = "0x103DDDC", VA = "0x103DDDC")]
		private void DoSetGravityScale()
		{
		}

		[Token(Token = "0x600637A")]
		[Address(RVA = "0x103DE9C", Offset = "0x103DE9C", VA = "0x103DE9C")]
		public SetGravity2dScale()
		{
		}
	}
}
