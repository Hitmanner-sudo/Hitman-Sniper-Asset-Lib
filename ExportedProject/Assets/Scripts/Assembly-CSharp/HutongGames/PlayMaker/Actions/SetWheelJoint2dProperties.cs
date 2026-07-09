using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010B0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A35D4", Offset = "0x5A35D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A35D4", Offset = "0x5A35D4")]
	public class SetWheelJoint2dProperties : FsmStateAction
	{
		[Token(Token = "0x4004EED")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9720", Offset = "0x5E9720")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5E9720", Offset = "0x5E9720")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004EEE")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ActionSection", RVA = "0x5E97B4", Offset = "0x5E97B4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E97B4", Offset = "0x5E97B4")]
		public FsmBool useMotor;

		[Token(Token = "0x4004EEF")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9814", Offset = "0x5E9814")]
		public FsmFloat motorSpeed;

		[Token(Token = "0x4004EF0")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E984C", Offset = "0x5E984C")]
		public FsmFloat maxMotorTorque;

		[Token(Token = "0x4004EF1")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ActionSection", RVA = "0x5E9884", Offset = "0x5E9884")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9884", Offset = "0x5E9884")]
		public FsmFloat angle;

		[Token(Token = "0x4004EF2")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E98E4", Offset = "0x5E98E4")]
		public FsmFloat dampingRatio;

		[Token(Token = "0x4004EF3")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E991C", Offset = "0x5E991C")]
		public FsmFloat frequency;

		[Token(Token = "0x4004EF4")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5E9954", Offset = "0x5E9954")]
		public bool everyFrame;

		[Token(Token = "0x4004EF5")]
		[FieldOffset(Offset = "0x90")]
		private WheelJoint2D _wj2d;

		[Token(Token = "0x4004EF6")]
		[FieldOffset(Offset = "0x98")]
		private JointMotor2D _motor;

		[Token(Token = "0x4004EF7")]
		[FieldOffset(Offset = "0xA0")]
		private JointSuspension2D _suspension;

		[Token(Token = "0x6006393")]
		[Address(RVA = "0x83D130", Offset = "0x83D130", VA = "0x83D130", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006394")]
		[Address(RVA = "0x83D264", Offset = "0x83D264", VA = "0x83D264", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006395")]
		[Address(RVA = "0x83D5D8", Offset = "0x83D5D8", VA = "0x83D5D8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006396")]
		[Address(RVA = "0x83D3A8", Offset = "0x83D3A8", VA = "0x83D3A8")]
		private void SetProperties()
		{
		}

		[Token(Token = "0x6006397")]
		[Address(RVA = "0x83D5DC", Offset = "0x83D5DC", VA = "0x83D5DC")]
		public SetWheelJoint2dProperties()
		{
		}
	}
}
