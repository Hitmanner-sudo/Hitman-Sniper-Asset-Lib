using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200108D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A2A9C", Offset = "0x5A2A9C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A2A9C", Offset = "0x5A2A9C")]
	[Attribute(Name = "SeeAlsoAttribute", RVA = "0x5A2A9C", Offset = "0x5A2A9C")]
	public class AddForce2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004DD6")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E4C14", Offset = "0x5E4C14")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4C14", Offset = "0x5E4C14")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004DD7")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4CA8", Offset = "0x5E4CA8")]
		public ForceMode2D forceMode;

		[Token(Token = "0x4004DD8")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4CE0", Offset = "0x5E4CE0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4CE0", Offset = "0x5E4CE0")]
		public FsmVector2 atPosition;

		[Token(Token = "0x4004DD9")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E4D30", Offset = "0x5E4D30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4D30", Offset = "0x5E4D30")]
		public FsmVector2 vector;

		[Token(Token = "0x4004DDA")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4D80", Offset = "0x5E4D80")]
		public FsmFloat x;

		[Token(Token = "0x4004DDB")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4DB8", Offset = "0x5E4DB8")]
		public FsmFloat y;

		[Token(Token = "0x4004DDC")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4DF0", Offset = "0x5E4DF0")]
		public FsmVector3 vector3;

		[Token(Token = "0x4004DDD")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E4E28", Offset = "0x5E4E28")]
		public bool everyFrame;

		[Token(Token = "0x60062D9")]
		[Address(RVA = "0xD5CB14", Offset = "0xD5CB14", VA = "0xD5CB14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60062DA")]
		[Address(RVA = "0xD5CC20", Offset = "0xD5CC20", VA = "0xD5CC20", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60062DB")]
		[Address(RVA = "0xD5CC40", Offset = "0xD5CC40", VA = "0xD5CC40", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60062DC")]
		[Address(RVA = "0xD5CE58", Offset = "0xD5CE58", VA = "0xD5CE58", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x60062DD")]
		[Address(RVA = "0xD5CC7C", Offset = "0xD5CC7C", VA = "0xD5CC7C")]
		private void DoAddForce()
		{
		}

		[Token(Token = "0x60062DE")]
		[Address(RVA = "0xD5CE5C", Offset = "0xD5CE5C", VA = "0xD5CE5C")]
		public AddForce2d()
		{
		}
	}
}
