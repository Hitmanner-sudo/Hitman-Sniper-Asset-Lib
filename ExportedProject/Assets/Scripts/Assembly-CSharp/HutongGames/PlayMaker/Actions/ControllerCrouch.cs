using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C4B0", Offset = "0x59C4B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C4B0", Offset = "0x59C4B0")]
	public class ControllerCrouch : ComponentAction<CharacterController>
	{
		[Token(Token = "0x2000F45")]
		private enum CrouchState
		{
			[Token(Token = "0x400481E")]
			stand = 0,
			[Token(Token = "0x400481F")]
			standToCrouch = 1,
			[Token(Token = "0x4004820")]
			crouch = 2,
			[Token(Token = "0x4004821")]
			crouchToStand = 3
		}

		[Token(Token = "0x400480E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5CD664", Offset = "0x5CD664")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD664", Offset = "0x5CD664")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400480F")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD6F8", Offset = "0x5CD6F8")]
		public FsmBool isCrouching;

		[Token(Token = "0x4004810")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD744", Offset = "0x5CD744")]
		public FsmFloat crouchHeight;

		[Token(Token = "0x4004811")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD790", Offset = "0x5CD790")]
		public FsmBool adjustChildren;

		[Token(Token = "0x4004812")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD7C8", Offset = "0x5CD7C8")]
		[RequiredField]
		public FsmFloat transitionTime;

		[Token(Token = "0x4004813")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD814", Offset = "0x5CD814")]
		public FsmBool completeTransition;

		[Token(Token = "0x4004814")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD84C", Offset = "0x5CD84C")]
		public FsmBool canStand;

		[Token(Token = "0x4004815")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CD884", Offset = "0x5CD884")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD884", Offset = "0x5CD884")]
		public FsmBool standToggle;

		[Token(Token = "0x4004816")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD8D4", Offset = "0x5CD8D4")]
		public FsmEvent standEvent;

		[Token(Token = "0x4004817")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CD90C", Offset = "0x5CD90C")]
		public FsmBool resetHeightOnExit;

		[Token(Token = "0x4004818")]
		[FieldOffset(Offset = "0xB8")]
		private float originalHeight;

		[Token(Token = "0x4004819")]
		[FieldOffset(Offset = "0xBC")]
		private float startTransitionHeight;

		[Token(Token = "0x400481A")]
		[FieldOffset(Offset = "0xC0")]
		private float transitionTimeElapsed;

		[Token(Token = "0x400481B")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<Transform, float> childOffsets;

		[Token(Token = "0x400481C")]
		[FieldOffset(Offset = "0xD0")]
		private CrouchState crouchState;

		[Token(Token = "0x17000C25")]
		private CharacterController controller
		{
			[Token(Token = "0x6005D6E")]
			[Address(RVA = "0xD7CA64", Offset = "0xD7CA64", VA = "0xD7CA64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D6F")]
		[Address(RVA = "0xD7CA6C", Offset = "0xD7CA6C", VA = "0xD7CA6C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D70")]
		[Address(RVA = "0xD7CBB0", Offset = "0xD7CBB0", VA = "0xD7CBB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D71")]
		[Address(RVA = "0xD7CF2C", Offset = "0xD7CF2C", VA = "0xD7CF2C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005D72")]
		[Address(RVA = "0xD7D1D4", Offset = "0xD7D1D4", VA = "0xD7D1D4")]
		private void SetHeight(float newHeight)
		{
		}

		[Token(Token = "0x6005D73")]
		[Address(RVA = "0xD7D3CC", Offset = "0xD7D3CC", VA = "0xD7D3CC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005D74")]
		[Address(RVA = "0xD7D560", Offset = "0xD7D560", VA = "0xD7D560")]
		public ControllerCrouch()
		{
		}
	}
}
