using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200120E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AADD4", Offset = "0x5AADD4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AADD4", Offset = "0x5AADD4")]
	public class UiButtonOnClickEvent : ComponentAction<Button>
	{
		[Token(Token = "0x4005668")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6037F4", Offset = "0x6037F4")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6037F4", Offset = "0x6037F4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005669")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603888", Offset = "0x603888")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x400566A")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6038C0", Offset = "0x6038C0")]
		public FsmEvent sendEvent;

		[Token(Token = "0x400566B")]
		[FieldOffset(Offset = "0x80")]
		private Button button;

		[Token(Token = "0x60069EA")]
		[Address(RVA = "0x11773A4", Offset = "0x11773A4", VA = "0x11773A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069EB")]
		[Address(RVA = "0x11773B0", Offset = "0x11773B0", VA = "0x11773B0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069EC")]
		[Address(RVA = "0x11775CC", Offset = "0x11775CC", VA = "0x11775CC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069ED")]
		[Address(RVA = "0x11776BC", Offset = "0x11776BC", VA = "0x11776BC")]
		public void DoOnClick()
		{
		}

		[Token(Token = "0x60069EE")]
		[Address(RVA = "0x117770C", Offset = "0x117770C", VA = "0x117770C")]
		public UiButtonOnClickEvent()
		{
		}
	}
}
