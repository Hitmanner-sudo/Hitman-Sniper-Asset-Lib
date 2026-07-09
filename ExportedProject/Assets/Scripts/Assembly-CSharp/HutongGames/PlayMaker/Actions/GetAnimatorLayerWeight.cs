using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EE6")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59A6B0", Offset = "0x59A6B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59A6B0", Offset = "0x59A6B0")]
	public class GetAnimatorLayerWeight : FsmStateActionAnimatorBase
	{
		[Token(Token = "0x4004688")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C6AD4", Offset = "0x5C6AD4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6AD4", Offset = "0x5C6AD4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004689")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6B68", Offset = "0x5C6B68")]
		public FsmInt layerIndex;

		[Token(Token = "0x400468A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C6BB4", Offset = "0x5C6BB4")]
		[RequiredField]
		[Attribute(Name = "ActionSection", RVA = "0x5C6BB4", Offset = "0x5C6BB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C6BB4", Offset = "0x5C6BB4")]
		public FsmFloat layerWeight;

		[Token(Token = "0x17000C15")]
		private Animator animator
		{
			[Token(Token = "0x6005BD3")]
			[Address(RVA = "0x105B288", Offset = "0x105B288", VA = "0x105B288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x105B290", Offset = "0x105B290", VA = "0x105B290", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x105B2BC", Offset = "0x105B2BC", VA = "0x105B2BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x105B3B0", Offset = "0x105B3B0", VA = "0x105B3B0", Slot = "62")]
		public override void OnActionUpdate()
		{
		}

		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x105B2F8", Offset = "0x105B2F8", VA = "0x105B2F8")]
		private void GetLayerWeight()
		{
		}

		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x105B3B4", Offset = "0x105B3B4", VA = "0x105B3B4")]
		public GetAnimatorLayerWeight()
		{
		}
	}
}
