using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011AF")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A92E8", Offset = "0x5A92E8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A92E8", Offset = "0x5A92E8")]
	public class SetPosition2d : FsmStateAction
	{
		[Token(Token = "0x400544D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCF28", Offset = "0x5FCF28")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400544E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCF74", Offset = "0x5FCF74")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FCF74", Offset = "0x5FCF74")]
		public FsmVector2 vector;

		[Token(Token = "0x400544F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCFC4", Offset = "0x5FCFC4")]
		public FsmFloat x;

		[Token(Token = "0x4005450")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FCFFC", Offset = "0x5FCFFC")]
		public FsmFloat y;

		[Token(Token = "0x4005451")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD034", Offset = "0x5FD034")]
		public Space space;

		[Token(Token = "0x4005452")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD06C", Offset = "0x5FD06C")]
		public bool everyFrame;

		[Token(Token = "0x4005453")]
		[FieldOffset(Offset = "0x75")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD0A4", Offset = "0x5FD0A4")]
		public bool lateUpdate;

		[Token(Token = "0x6006820")]
		[Address(RVA = "0x10418FC", Offset = "0x10418FC", VA = "0x10418FC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006821")]
		[Address(RVA = "0x104199C", Offset = "0x104199C", VA = "0x104199C", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x6006822")]
		[Address(RVA = "0x10419C8", Offset = "0x10419C8", VA = "0x10419C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006823")]
		[Address(RVA = "0x1041BAC", Offset = "0x1041BAC", VA = "0x1041BAC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006824")]
		[Address(RVA = "0x1041BBC", Offset = "0x1041BBC", VA = "0x1041BBC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006825")]
		[Address(RVA = "0x1041A10", Offset = "0x1041A10", VA = "0x1041A10")]
		private void DoSetPosition()
		{
		}

		[Token(Token = "0x6006826")]
		[Address(RVA = "0x1041C04", Offset = "0x1041C04", VA = "0x1041C04")]
		public SetPosition2d()
		{
		}
	}
}
