using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6180", Offset = "0x5A6180")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6180", Offset = "0x5A6180")]
	public class SetSpriteMaskInteraction : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051D9")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4EEC", Offset = "0x5F4EEC")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F4EEC", Offset = "0x5F4EEC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051DA")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F4F80", Offset = "0x5F4F80")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F4F80", Offset = "0x5F4F80")]
		public FsmEnum spriteMaskInteraction;

		[Token(Token = "0x600661B")]
		[Address(RVA = "0x10456F0", Offset = "0x10456F0", VA = "0x10456F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600661C")]
		[Address(RVA = "0x1045760", Offset = "0x1045760", VA = "0x1045760", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600661D")]
		[Address(RVA = "0x1045844", Offset = "0x1045844", VA = "0x1045844")]
		public SetSpriteMaskInteraction()
		{
		}
	}
}
