using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599A30", Offset = "0x599A30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599A30", Offset = "0x599A30")]
	public class PlayAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045C6")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C2C30", Offset = "0x5C2C30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2C30", Offset = "0x5C2C30")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045C7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2CC4", Offset = "0x5C2CC4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2CC4", Offset = "0x5C2CC4")]
		public FsmString animName;

		[Token(Token = "0x40045C8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2D14", Offset = "0x5C2D14")]
		public PlayMode playMode;

		[Token(Token = "0x40045C9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2D4C", Offset = "0x5C2D4C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C2D4C", Offset = "0x5C2D4C")]
		public FsmFloat blendTime;

		[Token(Token = "0x40045CA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2DA0", Offset = "0x5C2DA0")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40045CB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2DD8", Offset = "0x5C2DD8")]
		public FsmEvent loopEvent;

		[Token(Token = "0x40045CC")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2E10", Offset = "0x5C2E10")]
		public bool stopOnExit;

		[Token(Token = "0x40045CD")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationState anim;

		[Token(Token = "0x40045CE")]
		[FieldOffset(Offset = "0xA8")]
		private float prevAnimtTime;

		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x90B3CC", Offset = "0x90B3CC", VA = "0x90B3CC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0x90B410", Offset = "0x90B410", VA = "0x90B410", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x90B414", Offset = "0x90B414", VA = "0x90B414")]
		private void DoPlayAnimation()
		{
		}

		[Token(Token = "0x6005B10")]
		[Address(RVA = "0x90B614", Offset = "0x90B614", VA = "0x90B614", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B11")]
		[Address(RVA = "0x90B7B8", Offset = "0x90B7B8", VA = "0x90B7B8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005B12")]
		[Address(RVA = "0x90B7C8", Offset = "0x90B7C8", VA = "0x90B7C8")]
		private void StopAnimation()
		{
		}

		[Token(Token = "0x6005B13")]
		[Address(RVA = "0x90B8B0", Offset = "0x90B8B0", VA = "0x90B8B0")]
		public PlayAnimation()
		{
		}
	}
}
