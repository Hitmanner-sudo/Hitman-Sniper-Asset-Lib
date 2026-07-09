using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20011B1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A9388", Offset = "0x5A9388")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A9388", Offset = "0x5A9388")]
	public class SetRotation : FsmStateAction
	{
		[Token(Token = "0x4005458")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD20C", Offset = "0x5FD20C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4005459")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD258", Offset = "0x5FD258")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FD258", Offset = "0x5FD258")]
		public FsmQuaternion quaternion;

		[Token(Token = "0x400545A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FD2A8", Offset = "0x5FD2A8")]
		[Attribute(Name = "TitleAttribute", RVA = "0x5FD2A8", Offset = "0x5FD2A8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD2A8", Offset = "0x5FD2A8")]
		public FsmVector3 vector;

		[Token(Token = "0x400545B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD31C", Offset = "0x5FD31C")]
		public FsmFloat xAngle;

		[Token(Token = "0x400545C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD354", Offset = "0x5FD354")]
		public FsmFloat yAngle;

		[Token(Token = "0x400545D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD38C", Offset = "0x5FD38C")]
		public FsmFloat zAngle;

		[Token(Token = "0x400545E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD3C4", Offset = "0x5FD3C4")]
		public Space space;

		[Token(Token = "0x400545F")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD3FC", Offset = "0x5FD3FC")]
		public bool everyFrame;

		[Token(Token = "0x4005460")]
		[FieldOffset(Offset = "0x85")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FD434", Offset = "0x5FD434")]
		public bool lateUpdate;

		[Token(Token = "0x600682B")]
		[Address(RVA = "0x1044368", Offset = "0x1044368", VA = "0x1044368", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600682C")]
		[Address(RVA = "0x1044430", Offset = "0x1044430", VA = "0x1044430", Slot = "29")]
		public override void OnPreprocess()
		{
		}

		[Token(Token = "0x600682D")]
		[Address(RVA = "0x104445C", Offset = "0x104445C", VA = "0x104445C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600682E")]
		[Address(RVA = "0x10446AC", Offset = "0x10446AC", VA = "0x10446AC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600682F")]
		[Address(RVA = "0x10446BC", Offset = "0x10446BC", VA = "0x10446BC", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006830")]
		[Address(RVA = "0x10444A4", Offset = "0x10444A4", VA = "0x10444A4")]
		private void DoSetRotation()
		{
		}

		[Token(Token = "0x6006831")]
		[Address(RVA = "0x1044704", Offset = "0x1044704", VA = "0x1044704")]
		public SetRotation()
		{
		}
	}
}
