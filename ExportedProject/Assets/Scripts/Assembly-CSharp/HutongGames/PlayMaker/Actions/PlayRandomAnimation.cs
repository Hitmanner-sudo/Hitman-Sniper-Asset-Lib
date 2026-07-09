using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EBD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599A80", Offset = "0x599A80")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599A80", Offset = "0x599A80")]
	public class PlayRandomAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045CF")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2E48", Offset = "0x5C2E48")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C2E48", Offset = "0x5C2E48")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045D0")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2EDC", Offset = "0x5C2EDC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2EDC", Offset = "0x5C2EDC")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5C2EDC", Offset = "0x5C2EDC")]
		public FsmString[] animations;

		[Token(Token = "0x40045D1")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2F80", Offset = "0x5C2F80")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C2F80", Offset = "0x5C2F80")]
		public FsmFloat[] weights;

		[Token(Token = "0x40045D2")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2FD4", Offset = "0x5C2FD4")]
		public PlayMode playMode;

		[Token(Token = "0x40045D3")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C300C", Offset = "0x5C300C")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C300C", Offset = "0x5C300C")]
		public FsmFloat blendTime;

		[Token(Token = "0x40045D4")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3060", Offset = "0x5C3060")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40045D5")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C3098", Offset = "0x5C3098")]
		public FsmEvent loopEvent;

		[Token(Token = "0x40045D6")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C30D0", Offset = "0x5C30D0")]
		public bool stopOnExit;

		[Token(Token = "0x40045D7")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationState anim;

		[Token(Token = "0x40045D8")]
		[FieldOffset(Offset = "0xB0")]
		private float prevAnimtTime;

		[Token(Token = "0x6005B14")]
		[Address(RVA = "0xB80720", Offset = "0xB80720", VA = "0xB80720", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005B15")]
		[Address(RVA = "0xB807C0", Offset = "0xB807C0", VA = "0xB807C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005B16")]
		[Address(RVA = "0xB807C4", Offset = "0xB807C4", VA = "0xB807C4")]
		private void DoPlayRandomAnimation()
		{
		}

		[Token(Token = "0x6005B17")]
		[Address(RVA = "0xB80850", Offset = "0xB80850", VA = "0xB80850")]
		private void DoPlayAnimation(string animName)
		{
		}

		[Token(Token = "0x6005B18")]
		[Address(RVA = "0xB809FC", Offset = "0xB809FC", VA = "0xB809FC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005B19")]
		[Address(RVA = "0xB80BA0", Offset = "0xB80BA0", VA = "0xB80BA0", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005B1A")]
		[Address(RVA = "0xB80BB0", Offset = "0xB80BB0", VA = "0xB80BB0")]
		private void StopAnimation()
		{
		}

		[Token(Token = "0x6005B1B")]
		[Address(RVA = "0xB80C98", Offset = "0xB80C98", VA = "0xB80C98")]
		public PlayRandomAnimation()
		{
		}
	}
}
