using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001208")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAC34", Offset = "0x5AAC34")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAC34", Offset = "0x5AAC34")]
	public class UiSetColorBlock : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005642")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603034", Offset = "0x603034")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603034", Offset = "0x603034")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005643")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6030C8", Offset = "0x6030C8")]
		public FsmFloat fadeDuration;

		[Token(Token = "0x4005644")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603100", Offset = "0x603100")]
		public FsmFloat colorMultiplier;

		[Token(Token = "0x4005645")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603138", Offset = "0x603138")]
		public FsmColor normalColor;

		[Token(Token = "0x4005646")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603170", Offset = "0x603170")]
		public FsmColor pressedColor;

		[Token(Token = "0x4005647")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6031A8", Offset = "0x6031A8")]
		public FsmColor highlightedColor;

		[Token(Token = "0x4005648")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6031E0", Offset = "0x6031E0")]
		public FsmColor disabledColor;

		[Token(Token = "0x4005649")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603218", Offset = "0x603218")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400564A")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603250", Offset = "0x603250")]
		public bool everyFrame;

		[Token(Token = "0x400564B")]
		[FieldOffset(Offset = "0xB0")]
		private Selectable selectable;

		[Token(Token = "0x400564C")]
		[FieldOffset(Offset = "0xB8")]
		private ColorBlock _colorBlock;

		[Token(Token = "0x400564D")]
		[FieldOffset(Offset = "0x110")]
		private ColorBlock originalColorBlock;

		[Token(Token = "0x60069CD")]
		[Address(RVA = "0xB97734", Offset = "0xB97734", VA = "0xB97734", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069CE")]
		[Address(RVA = "0xB9786C", Offset = "0xB9786C", VA = "0xB9786C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069CF")]
		[Address(RVA = "0xB97B44", Offset = "0xB97B44", VA = "0xB97B44", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60069D0")]
		[Address(RVA = "0xB97990", Offset = "0xB97990", VA = "0xB97990")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069D1")]
		[Address(RVA = "0xB97B48", Offset = "0xB97B48", VA = "0xB97B48", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069D2")]
		[Address(RVA = "0xB97C14", Offset = "0xB97C14", VA = "0xB97C14")]
		public UiSetColorBlock()
		{
		}
	}
}
