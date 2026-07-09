using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200120B")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAD24", Offset = "0x5AAD24")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAD24", Offset = "0x5AAD24")]
	public class UiTransitionSetType : ComponentAction<Selectable>
	{
		[Token(Token = "0x400565A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603538", Offset = "0x603538")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603538", Offset = "0x603538")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400565B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6035CC", Offset = "0x6035CC")]
		public Selectable.Transition transition;

		[Token(Token = "0x400565C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603604", Offset = "0x603604")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400565D")]
		[FieldOffset(Offset = "0x80")]
		private Selectable selectable;

		[Token(Token = "0x400565E")]
		[FieldOffset(Offset = "0x88")]
		private Selectable.Transition originalTransition;

		[Token(Token = "0x60069DC")]
		[Address(RVA = "0xB9A8E8", Offset = "0xB9A8E8", VA = "0xB9A8E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069DD")]
		[Address(RVA = "0xB9A920", Offset = "0xB9A920", VA = "0xB9A920", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069DE")]
		[Address(RVA = "0xB9AA24", Offset = "0xB9AA24", VA = "0xB9AA24")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069DF")]
		[Address(RVA = "0xB9AAB8", Offset = "0xB9AAB8", VA = "0xB9AAB8", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069E0")]
		[Address(RVA = "0xB9AB60", Offset = "0xB9AB60", VA = "0xB9AB60")]
		public UiTransitionSetType()
		{
		}
	}
}
