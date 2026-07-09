using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001202")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AAA54", Offset = "0x5AAA54")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AAA54", Offset = "0x5AAA54")]
	public class UiNavigationExplicitSetProperties : ComponentAction<Selectable>
	{
		[Token(Token = "0x4005614")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6024C4", Offset = "0x6024C4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6024C4", Offset = "0x6024C4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005615")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602558", Offset = "0x602558")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602558", Offset = "0x602558")]
		public FsmGameObject selectOnDown;

		[Token(Token = "0x4005616")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6025DC", Offset = "0x6025DC")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6025DC", Offset = "0x6025DC")]
		public FsmGameObject selectOnUp;

		[Token(Token = "0x4005617")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602660", Offset = "0x602660")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x602660", Offset = "0x602660")]
		public FsmGameObject selectOnLeft;

		[Token(Token = "0x4005618")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6026E4", Offset = "0x6026E4")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6026E4", Offset = "0x6026E4")]
		public FsmGameObject selectOnRight;

		[Token(Token = "0x4005619")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x602768", Offset = "0x602768")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400561A")]
		[FieldOffset(Offset = "0x98")]
		private Selectable selectable;

		[Token(Token = "0x400561B")]
		[FieldOffset(Offset = "0xA0")]
		private Navigation navigation;

		[Token(Token = "0x400561C")]
		[FieldOffset(Offset = "0xC8")]
		private Navigation originalState;

		[Token(Token = "0x60069B0")]
		[Address(RVA = "0xB92E80", Offset = "0xB92E80", VA = "0xB92E80", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60069B1")]
		[Address(RVA = "0xB92F6C", Offset = "0xB92F6C", VA = "0xB92F6C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60069B2")]
		[Address(RVA = "0xB9307C", Offset = "0xB9307C", VA = "0xB9307C")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x60069B3")]
		[Address(RVA = "0xB93208", Offset = "0xB93208", VA = "0xB93208", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60069B4")]
		private static T GetComponentFromFsmGameObject<T>(FsmGameObject variable) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60069B5")]
		[Address(RVA = "0xB932DC", Offset = "0xB932DC", VA = "0xB932DC")]
		public UiNavigationExplicitSetProperties()
		{
		}
	}
}
