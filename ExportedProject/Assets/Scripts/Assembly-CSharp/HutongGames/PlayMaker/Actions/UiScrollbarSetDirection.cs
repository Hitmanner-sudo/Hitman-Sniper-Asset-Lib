using Il2CppDummyDll;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200123D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5ABC84", Offset = "0x5ABC84")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5ABC84", Offset = "0x5ABC84")]
	public class UiScrollbarSetDirection : ComponentAction<Scrollbar>
	{
		[Token(Token = "0x4005759")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6075A0", Offset = "0x6075A0")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x6075A0", Offset = "0x6075A0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400575A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607634", Offset = "0x607634")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x607634", Offset = "0x607634")]
		public FsmEnum direction;

		[Token(Token = "0x400575B")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6076C8", Offset = "0x6076C8")]
		public FsmBool includeRectLayouts;

		[Token(Token = "0x400575C")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x607700", Offset = "0x607700")]
		public FsmBool resetOnExit;

		[Token(Token = "0x400575D")]
		[FieldOffset(Offset = "0x88")]
		private Scrollbar scrollbar;

		[Token(Token = "0x400575E")]
		[FieldOffset(Offset = "0x90")]
		private Scrollbar.Direction originalValue;

		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0xB967AC", Offset = "0xB967AC", VA = "0xB967AC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0xB96854", Offset = "0xB96854", VA = "0xB96854", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0xB96900", Offset = "0xB96900", VA = "0xB96900")]
		private void DoSetValue()
		{
		}

		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0xB96A78", Offset = "0xB96A78", VA = "0xB96A78", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0xB96B7C", Offset = "0xB96B7C", VA = "0xB96B7C")]
		public UiScrollbarSetDirection()
		{
		}
	}
}
