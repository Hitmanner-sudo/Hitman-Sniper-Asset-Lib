using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200119F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8E14", Offset = "0x5A8E14")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8E14", Offset = "0x5A8E14")]
	public class ClampPosition : ComponentAction<Transform>
	{
		[Token(Token = "0x40053D0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB520", Offset = "0x5FB520")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40053D1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB56C", Offset = "0x5FB56C")]
		public FsmFloat minX;

		[Token(Token = "0x40053D2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB5A4", Offset = "0x5FB5A4")]
		public FsmFloat maxX;

		[Token(Token = "0x40053D3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB5DC", Offset = "0x5FB5DC")]
		public FsmFloat minY;

		[Token(Token = "0x40053D4")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB614", Offset = "0x5FB614")]
		public FsmFloat maxY;

		[Token(Token = "0x40053D5")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB64C", Offset = "0x5FB64C")]
		public FsmFloat minZ;

		[Token(Token = "0x40053D6")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB684", Offset = "0x5FB684")]
		public FsmFloat maxZ;

		[Token(Token = "0x40053D7")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB6BC", Offset = "0x5FB6BC")]
		public Space space;

		[Token(Token = "0x40053D8")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB6F4", Offset = "0x5FB6F4")]
		public bool everyFrame;

		[Token(Token = "0x40053D9")]
		[FieldOffset(Offset = "0xA5")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FB72C", Offset = "0x5FB72C")]
		public bool lateUpdate;

		[Token(Token = "0x60067C5")]
		[Address(RVA = "0xB01510", Offset = "0xB01510", VA = "0xB01510", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60067C6")]
		[Address(RVA = "0xB01638", Offset = "0xB01638", VA = "0xB01638", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x60067C7")]
		[Address(RVA = "0xB01664", Offset = "0xB01664", VA = "0xB01664", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60067C8")]
		[Address(RVA = "0xB018F8", Offset = "0xB018F8", VA = "0xB018F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60067C9")]
		[Address(RVA = "0xB01908", Offset = "0xB01908", VA = "0xB01908", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x60067CA")]
		[Address(RVA = "0xB016AC", Offset = "0xB016AC", VA = "0xB016AC")]
		private void DoClampPosition()
		{
		}

		[Token(Token = "0x60067CB")]
		[Address(RVA = "0xB01954", Offset = "0xB01954", VA = "0xB01954")]
		public ClampPosition()
		{
		}
	}
}
