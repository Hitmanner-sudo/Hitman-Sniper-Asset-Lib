using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001205")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAB44", Offset = "0x5AAB44")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAB44", Offset = "0x5AAB44")]
	public class UiNavigationGetMode : ComponentAction<Selectable>
	{
		[Token(Token = "0x400562B")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602BA0", Offset = "0x602BA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602BA0", Offset = "0x602BA0")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400562C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602C34", Offset = "0x602C34")]
		public FsmString navigationMode;

		[Token(Token = "0x400562D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602C6C", Offset = "0x602C6C")]
		public FsmEvent automaticEvent;

		[Token(Token = "0x400562E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602CA4", Offset = "0x602CA4")]
		public FsmEvent horizontalEvent;

		[Token(Token = "0x400562F")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602CDC", Offset = "0x602CDC")]
		public FsmEvent verticalEvent;

		[Token(Token = "0x4005630")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602D14", Offset = "0x602D14")]
		public FsmEvent explicitEvent;

		[Token(Token = "0x4005631")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602D4C", Offset = "0x602D4C")]
		public FsmEvent noNavigationEvent;

		[Token(Token = "0x4005632")]
		[FieldOffset(Offset = "0xA0")]
		private Selectable selectable;

		[Token(Token = "0x60069BF")]
		[Address(RVA = "0xB93328", Offset = "0xB93328", VA = "0xB93328", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069C0")]
		[Address(RVA = "0xB93330", Offset = "0xB93330", VA = "0xB93330", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069C1")]
		[Address(RVA = "0xB933B8", Offset = "0xB933B8", VA = "0xB933B8")]
		private void DoGetValue()
		{
		}

		[Token(Token = "0x60069C2")]
		[Address(RVA = "0xB93524", Offset = "0xB93524", VA = "0xB93524")]
		public UiNavigationGetMode()
		{
		}
	}
}
