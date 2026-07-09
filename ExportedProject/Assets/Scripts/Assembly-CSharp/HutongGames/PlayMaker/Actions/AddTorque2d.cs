using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2B60", Offset = "0x5A2B60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2B60", Offset = "0x5A2B60")]
	public class AddTorque2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004DE5")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E505C", Offset = "0x5E505C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E505C", Offset = "0x5E505C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DE6")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E50F0", Offset = "0x5E50F0")]
		public ForceMode2D forceMode;

		[Token(Token = "0x4004DE7")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5128", Offset = "0x5E5128")]
		public FsmFloat torque;

		[Token(Token = "0x4004DE8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5160", Offset = "0x5E5160")]
		public bool everyFrame;

		[Token(Token = "0x60062E5")]
		[Address(RVA = "0xD5D978", Offset = "0xD5D978", VA = "0xD5D978", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062E6")]
		[Address(RVA = "0xD5D998", Offset = "0xD5D998", VA = "0xD5D998", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062E7")]
		[Address(RVA = "0xD5D9A8", Offset = "0xD5D9A8", VA = "0xD5D9A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062E8")]
		[Address(RVA = "0xD5DAA8", Offset = "0xD5DAA8", VA = "0xD5DAA8", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60062E9")]
		[Address(RVA = "0xD5D9E4", Offset = "0xD5D9E4", VA = "0xD5D9E4")]
		private void DoAddTorque()
		{
		}

		[Token(Token = "0x60062EA")]
		[Address(RVA = "0xD5DAAC", Offset = "0xD5DAAC", VA = "0xD5DAAC")]
		public AddTorque2d()
		{
		}
	}
}
