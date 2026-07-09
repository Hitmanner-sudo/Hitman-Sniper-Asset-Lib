using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001207")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AABE4", Offset = "0x5AABE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AABE4", Offset = "0x5AABE4")]
	public class UiSetAnimationTriggers : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005639")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602E88", Offset = "0x602E88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602E88", Offset = "0x602E88")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400563A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602F1C", Offset = "0x602F1C")]
		public FsmString normalTrigger;

		[Token(Token = "0x400563B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602F54", Offset = "0x602F54")]
		public FsmString highlightedTrigger;

		[Token(Token = "0x400563C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602F8C", Offset = "0x602F8C")]
		public FsmString pressedTrigger;

		[Token(Token = "0x400563D")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602FC4", Offset = "0x602FC4")]
		public FsmString disabledTrigger;

		[Token(Token = "0x400563E")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602FFC", Offset = "0x602FFC")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400563F")]
		[FieldOffset(Offset = "0x98")]
		private Selectable selectable;

		[Token(Token = "0x4005640")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationTriggers _animationTriggers;

		[Token(Token = "0x4005641")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationTriggers originalAnimationTriggers;

		[Token(Token = "0x60069C8")]
		[Address(RVA = "0xB972FC", Offset = "0xB972FC", VA = "0xB972FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069C9")]
		[Address(RVA = "0xB973D8", Offset = "0xB973D8", VA = "0xB973D8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069CA")]
		[Address(RVA = "0xB974DC", Offset = "0xB974DC", VA = "0xB974DC")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069CB")]
		[Address(RVA = "0xB97640", Offset = "0xB97640", VA = "0xB97640", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069CC")]
		[Address(RVA = "0xB976E8", Offset = "0xB976E8", VA = "0xB976E8")]
		public UiSetAnimationTriggers()
		{
		}
	}
}
