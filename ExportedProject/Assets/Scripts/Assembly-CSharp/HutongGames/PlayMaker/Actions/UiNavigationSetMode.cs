using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001206")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAB94", Offset = "0x5AAB94")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAB94", Offset = "0x5AAB94")]
	public class UiNavigationSetMode : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005633")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602D84", Offset = "0x602D84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602D84", Offset = "0x602D84")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005634")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602E18", Offset = "0x602E18")]
		public Navigation.Mode navigationMode;

		[Token(Token = "0x4005635")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602E50", Offset = "0x602E50")]
		public FsmBool resetOnExit;

		[Token(Token = "0x4005636")]
		[FieldOffset(Offset = "0x80")]
		private Selectable selectable;

		[Token(Token = "0x4005637")]
		[FieldOffset(Offset = "0x88")]
		private Navigation _navigation;

		[Token(Token = "0x4005638")]
		[FieldOffset(Offset = "0xB0")]
		private Navigation.Mode originalValue;

		[Token(Token = "0x60069C3")]
		[Address(RVA = "0xB93570", Offset = "0xB93570", VA = "0xB93570", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069C4")]
		[Address(RVA = "0xB935A8", Offset = "0xB935A8", VA = "0xB935A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069C5")]
		[Address(RVA = "0xB936AC", Offset = "0xB936AC", VA = "0xB936AC")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069C6")]
		[Address(RVA = "0xB93768", Offset = "0xB93768", VA = "0xB93768", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069C7")]
		[Address(RVA = "0xB93838", Offset = "0xB93838", VA = "0xB93838")]
		public UiNavigationSetMode()
		{
		}
	}
}
