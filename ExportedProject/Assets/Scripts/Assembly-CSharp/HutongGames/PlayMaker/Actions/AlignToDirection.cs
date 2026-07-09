using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200119D")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8DC4", Offset = "0x5A8DC4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8DC4", Offset = "0x5A8DC4")]
	public class AlignToDirection : ComponentAction<Transform>
	{
		[Token(Token = "0x200119E")]
		public enum AlignAxis
		{
			[Token(Token = "0x40053CD")]
			x = 0,
			[Token(Token = "0x40053CE")]
			y = 1,
			[Token(Token = "0x40053CF")]
			z = 2
		}

		[Token(Token = "0x40053C6")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB34C", Offset = "0x5FB34C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053C7")]
		[FieldOffset(Offset = "0x70")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB398", Offset = "0x5FB398")]
		public FsmVector3 targetDirection;

		[Token(Token = "0x40053C8")]
		[FieldOffset(Offset = "0x78")]
		[RequiredField]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5FB3E4", Offset = "0x5FB3E4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB3E4", Offset = "0x5FB3E4")]
		public FsmEnum alignAxis;

		[Token(Token = "0x40053C9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB478", Offset = "0x5FB478")]
		public FsmBool flipAxis;

		[Token(Token = "0x40053CA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB4B0", Offset = "0x5FB4B0")]
		public bool everyFrame;

		[Token(Token = "0x40053CB")]
		[FieldOffset(Offset = "0x89")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB4E8", Offset = "0x5FB4E8")]
		public bool lateUpdate;

		[Token(Token = "0x60067BE")]
		[Address(RVA = "0xD5F140", Offset = "0xD5F140", VA = "0xD5F140", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067BF")]
		[Address(RVA = "0xD5F1B8", Offset = "0xD5F1B8", VA = "0xD5F1B8", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60067C0")]
		[Address(RVA = "0xD5F1DC", Offset = "0xD5F1DC", VA = "0xD5F1DC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067C1")]
		[Address(RVA = "0xD5F424", Offset = "0xD5F424", VA = "0xD5F424", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067C2")]
		[Address(RVA = "0xD5F434", Offset = "0xD5F434", VA = "0xD5F434", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60067C3")]
		[Address(RVA = "0xD5F218", Offset = "0xD5F218", VA = "0xD5F218")]
		private void DoAlignToDirection()
		{
		}

		[Token(Token = "0x60067C4")]
		[Address(RVA = "0xD5F444", Offset = "0xD5F444", VA = "0xD5F444")]
		public AlignToDirection()
		{
		}
	}
}
