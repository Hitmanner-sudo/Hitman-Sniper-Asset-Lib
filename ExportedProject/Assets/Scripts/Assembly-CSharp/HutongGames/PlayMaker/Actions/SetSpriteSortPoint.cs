using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200113F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6220", Offset = "0x5A6220")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6220", Offset = "0x5A6220")]
	public class SetSpriteSortPoint : ComponentAction<SpriteRenderer>
	{
		[Token(Token = "0x40051DD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5F50E4", Offset = "0x5F50E4")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F50E4", Offset = "0x5F50E4")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40051DE")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5178", Offset = "0x5F5178")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5F5178", Offset = "0x5F5178")]
		public FsmEnum spriteSortPoint;

		[Token(Token = "0x6006621")]
		[Address(RVA = "0x1045990", Offset = "0x1045990", VA = "0x1045990", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006622")]
		[Address(RVA = "0x1045A00", Offset = "0x1045A00", VA = "0x1045A00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006623")]
		[Address(RVA = "0x1045AE4", Offset = "0x1045AE4", VA = "0x1045AE4")]
		public SetSpriteSortPoint()
		{
		}
	}
}
