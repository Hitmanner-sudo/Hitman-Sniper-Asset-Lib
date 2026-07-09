using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001239")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABB44", Offset = "0x5ABB44")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABB44", Offset = "0x5ABB44")]
	public class UiScrollRectSetVertical : ComponentAction<ScrollRect>
	{
		[Token(Token = "0x4005746")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x607070", Offset = "0x607070")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607070", Offset = "0x607070")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005747")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607104", Offset = "0x607104")]
		public FsmBool vertical;

		[Token(Token = "0x4005748")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60713C", Offset = "0x60713C")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005749")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607174", Offset = "0x607174")]
		public bool everyFrame;

		[Token(Token = "0x400574A")]
		[FieldOffset(Offset = "0x88")]
		private ScrollRect scrollRect;

		[Token(Token = "0x400574B")]
		[FieldOffset(Offset = "0x90")]
		private bool originalValue;

		[Token(Token = "0x6006ABB")]
		[Address(RVA = "0xB95EA0", Offset = "0xB95EA0", VA = "0xB95EA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006ABC")]
		[Address(RVA = "0xB95EB0", Offset = "0xB95EB0", VA = "0xB95EB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006ABD")]
		[Address(RVA = "0xB95FFC", Offset = "0xB95FFC", VA = "0xB95FFC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006ABE")]
		[Address(RVA = "0xB95F64", Offset = "0xB95F64", VA = "0xB95F64")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006ABF")]
		[Address(RVA = "0xB96000", Offset = "0xB96000", VA = "0xB96000", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AC0")]
		[Address(RVA = "0xB9609C", Offset = "0xB9609C", VA = "0xB9609C")]
		public UiScrollRectSetVertical()
		{
		}
	}
}
