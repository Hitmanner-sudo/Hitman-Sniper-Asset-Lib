using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2B10", Offset = "0x5A2B10")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2B10", Offset = "0x5A2B10")]
	public class AddRelativeForce2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004DDE")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4E60", Offset = "0x5E4E60")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4E60", Offset = "0x5E4E60")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DDF")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4EF4", Offset = "0x5E4EF4")]
		public ForceMode2D forceMode;

		[Token(Token = "0x4004DE0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4F2C", Offset = "0x5E4F2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4F2C", Offset = "0x5E4F2C")]
		public FsmVector2 vector;

		[Token(Token = "0x4004DE1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4F7C", Offset = "0x5E4F7C")]
		public FsmFloat x;

		[Token(Token = "0x4004DE2")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4FB4", Offset = "0x5E4FB4")]
		public FsmFloat y;

		[Token(Token = "0x4004DE3")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4FEC", Offset = "0x5E4FEC")]
		public FsmVector3 vector3;

		[Token(Token = "0x4004DE4")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E5024", Offset = "0x5E5024")]
		public bool everyFrame;

		[Token(Token = "0x60062DF")]
		[Address(RVA = "0xD5D0A4", Offset = "0xD5D0A4", VA = "0xD5D0A4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062E0")]
		[Address(RVA = "0xD5D180", Offset = "0xD5D180", VA = "0xD5D180", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062E1")]
		[Address(RVA = "0xD5D1A0", Offset = "0xD5D1A0", VA = "0xD5D1A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062E2")]
		[Address(RVA = "0xD5D370", Offset = "0xD5D370", VA = "0xD5D370", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60062E3")]
		[Address(RVA = "0xD5D1DC", Offset = "0xD5D1DC", VA = "0xD5D1DC")]
		private void DoAddRelativeForce()
		{
		}

		[Token(Token = "0x60062E4")]
		[Address(RVA = "0xD5D374", Offset = "0xD5D374", VA = "0xD5D374")]
		public AddRelativeForce2d()
		{
		}
	}
}
