using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000EB9")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599940", Offset = "0x599940")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599940", Offset = "0x599940")]
	public class BlendAnimation : BaseAnimationAction
	{
		[Token(Token = "0x40045B6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C26E0", Offset = "0x5C26E0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C26E0", Offset = "0x5C26E0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40045B7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C2774", Offset = "0x5C2774")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2774", Offset = "0x5C2774")]
		[RequiredField]
		public FsmString animName;

		[Token(Token = "0x40045B8")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C27D4", Offset = "0x5C27D4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C27D4", Offset = "0x5C27D4")]
		public FsmFloat targetWeight;

		[Token(Token = "0x40045B9")]
		[FieldOffset(Offset = "0x80")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C2838", Offset = "0x5C2838")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5C2838", Offset = "0x5C2838")]
		public FsmFloat time;

		[Token(Token = "0x40045BA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C289C", Offset = "0x5C289C")]
		public FsmEvent finishEvent;

		[Token(Token = "0x40045BB")]
		[FieldOffset(Offset = "0x90")]
		private DelayedEvent delayedFinishEvent;

		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0xC66E80", Offset = "0xC66E80", VA = "0xC66E80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0xC66EC4", Offset = "0xC66EC4", VA = "0xC66EC4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0xC6713C", Offset = "0xC6713C", VA = "0xC6713C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0xC66F14", Offset = "0xC66F14", VA = "0xC66F14")]
		private void DoBlendAnimation(GameObject go)
		{
		}

		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0xC6717C", Offset = "0xC6717C", VA = "0xC6717C")]
		public BlendAnimation()
		{
		}
	}
}
