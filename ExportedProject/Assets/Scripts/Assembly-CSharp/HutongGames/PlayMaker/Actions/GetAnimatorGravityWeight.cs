using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EDC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A390", Offset = "0x59A390")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A390", Offset = "0x59A390")]
	public class GetAnimatorGravityWeight : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x400465E")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C5BC4", Offset = "0x5C5BC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5BC4", Offset = "0x5C5BC4")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400465F")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C5C58", Offset = "0x5C5C58")]
		[Attribute(Name = "ActionSection", RVA = "0x5C5C58", Offset = "0x5C5C58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C5C58", Offset = "0x5C5C58")]
		public FsmFloat gravityWeight;

		[Token(Token = "0x17000C10")]
		private Animator animator
		{
			[Token(Token = "0x6005BA6")]
			[Address(RVA = "0xDA36FC", Offset = "0xDA36FC", VA = "0xDA36FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0xDA3704", Offset = "0xDA3704", VA = "0xDA3704", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BA8")]
		[Address(RVA = "0xDA3730", Offset = "0xDA3730", VA = "0xDA3730", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BA9")]
		[Address(RVA = "0xDA380C", Offset = "0xDA380C", VA = "0xDA380C", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BAA")]
		[Address(RVA = "0xDA376C", Offset = "0xDA376C", VA = "0xDA376C")]
		private void DoGetGravityWeight()
		{
		}

		[Token(Token = "0x6005BAB")]
		[Address(RVA = "0xDA3810", Offset = "0xDA3810", VA = "0xDA3810")]
		public GetAnimatorGravityWeight()
		{
		}
	}
}
