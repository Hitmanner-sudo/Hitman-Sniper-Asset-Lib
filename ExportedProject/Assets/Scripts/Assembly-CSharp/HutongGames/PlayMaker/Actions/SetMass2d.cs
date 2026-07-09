using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010AE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3534", Offset = "0x5A3534")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3534", Offset = "0x5A3534")]
	public class SetMass2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EE5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9478", Offset = "0x5E9478")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9478", Offset = "0x5E9478")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EE6")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5E950C", Offset = "0x5E950C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E950C", Offset = "0x5E950C")]
		public FsmFloat mass;

		[Token(Token = "0x6006389")]
		[Address(RVA = "0x103F9A4", Offset = "0x103F9A4", VA = "0x103F9A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600638A")]
		[Address(RVA = "0x103F9D4", Offset = "0x103F9D4", VA = "0x103F9D4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600638B")]
		[Address(RVA = "0x103F9FC", Offset = "0x103F9FC", VA = "0x103F9FC")]
		private void DoSetMass()
		{
		}

		[Token(Token = "0x600638C")]
		[Address(RVA = "0x103FABC", Offset = "0x103FABC", VA = "0x103FABC")]
		public SetMass2d()
		{
		}
	}
}
