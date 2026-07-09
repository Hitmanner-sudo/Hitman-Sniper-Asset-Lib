using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010A5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A3240", Offset = "0x5A3240")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A3240", Offset = "0x5A3240")]
	public class MovePosition2d : ComponentAction<Rigidbody2D>
	{
		[Token(Token = "0x4004EA7")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E8364", Offset = "0x5E8364")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8364", Offset = "0x5E8364")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EA8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5E83F8", Offset = "0x5E83F8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E83F8", Offset = "0x5E83F8")]
		public FsmVector2 vector;

		[Token(Token = "0x4004EA9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8448", Offset = "0x5E8448")]
		public FsmFloat x;

		[Token(Token = "0x4004EAA")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E8480", Offset = "0x5E8480")]
		public FsmFloat y;

		[Token(Token = "0x4004EAB")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E84B8", Offset = "0x5E84B8")]
		public Space space;

		[Token(Token = "0x4004EAC")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E84F0", Offset = "0x5E84F0")]
		public bool everyFrame;

		[Token(Token = "0x600635F")]
		[Address(RVA = "0xA30798", Offset = "0xA30798", VA = "0xA30798", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006360")]
		[Address(RVA = "0xA30838", Offset = "0xA30838", VA = "0xA30838", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006361")]
		[Address(RVA = "0xA30858", Offset = "0xA30858", VA = "0xA30858", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006362")]
		[Address(RVA = "0xA30894", Offset = "0xA30894", VA = "0xA30894")]
		private void DoMovePosition()
		{
		}

		[Token(Token = "0x6006363")]
		[Address(RVA = "0xA30AC4", Offset = "0xA30AC4", VA = "0xA30AC4")]
		public MovePosition2d()
		{
		}
	}
}
