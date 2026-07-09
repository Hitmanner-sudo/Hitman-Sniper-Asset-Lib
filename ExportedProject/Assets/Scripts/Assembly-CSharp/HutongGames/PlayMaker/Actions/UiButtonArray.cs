using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200120C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAD74", Offset = "0x5AAD74")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAD74", Offset = "0x5AAD74")]
	public class UiButtonArray : FsmStateAction
	{
		[Token(Token = "0x200120D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AADC4", Offset = "0x5AADC4")]
		private sealed class _003C_003Ec__DisplayClass10_0
		{
			[Token(Token = "0x4005666")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x4005667")]
			[FieldOffset(Offset = "0x18")]
			public UiButtonArray _003C_003E4__this;

			[Token(Token = "0x60069E8")]
			[Address(RVA = "0xA3FE48", Offset = "0xA3FE48", VA = "0xA3FE48")]
			public _003C_003Ec__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60069E9")]
			[Address(RVA = "0xA3FE50", Offset = "0xA3FE50", VA = "0xA3FE50")]
			internal void _003COnEnter_003Eb__0()
			{
			}
		}

		[Token(Token = "0x400565F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60363C", Offset = "0x60363C")]
		public FsmEventTarget eventTarget;

		[Token(Token = "0x4005660")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x603674", Offset = "0x603674")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603674", Offset = "0x603674")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x603674", Offset = "0x603674")]
		public FsmGameObject[] gameObjects;

		[Token(Token = "0x4005661")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60374C", Offset = "0x60374C")]
		public FsmEvent[] clickEvents;

		[Token(Token = "0x4005662")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x603784", Offset = "0x603784")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x603784", Offset = "0x603784")]
		public FsmInt clickIndex;

		[Token(Token = "0x4005663")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button[] buttons;

		[Token(Token = "0x4005664")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] cachedGameObjects;

		[Token(Token = "0x4005665")]
		[FieldOffset(Offset = "0x80")]
		private UnityAction[] actions;

		[Token(Token = "0x60069E1")]
		[Address(RVA = "0x1176CD4", Offset = "0x1176CD4", VA = "0x1176CD4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069E2")]
		[Address(RVA = "0x1176D4C", Offset = "0x1176D4C", VA = "0x1176D4C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60069E3")]
		[Address(RVA = "0x1176E08", Offset = "0x1176E08", VA = "0x1176E08")]
		private void InitButtons()
		{
		}

		[Token(Token = "0x60069E4")]
		[Address(RVA = "0x1176FF0", Offset = "0x1176FF0", VA = "0x1176FF0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069E5")]
		[Address(RVA = "0x11771BC", Offset = "0x11771BC", VA = "0x11771BC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069E6")]
		[Address(RVA = "0x11772F8", Offset = "0x11772F8", VA = "0x11772F8")]
		public void OnClick(int index)
		{
		}

		[Token(Token = "0x60069E7")]
		[Address(RVA = "0x117739C", Offset = "0x117739C", VA = "0x117739C")]
		public UiButtonArray()
		{
		}
	}
}
