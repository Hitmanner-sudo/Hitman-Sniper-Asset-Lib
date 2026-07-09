using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000E9E")]
	[Attribute(Name = "HelpUrlAttribute", RVA = "0x599214", Offset = "0x599214")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x599214", Offset = "0x599214")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x599214", Offset = "0x599214")]
	public class SetAnimatorQuaternion : FsmStateAction
	{
		[Token(Token = "0x40044B8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0258", Offset = "0x5C0258")]
		[Attribute(Name = "CheckForComponentAttribute", RVA = "0x5C0258", Offset = "0x5C0258")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x40044B9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C02EC", Offset = "0x5C02EC")]
		public FsmString parameter;

		[Token(Token = "0x40044BA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C0324", Offset = "0x5C0324")]
		public FsmQuaternion Value;

		[Token(Token = "0x40044BB")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C035C", Offset = "0x5C035C")]
		public bool everyFrame;

		[Token(Token = "0x40044BC")]
		[FieldOffset(Offset = "0x70")]
		private PlayMakerAnimatorMoveProxy _animatorProxy;

		[Token(Token = "0x40044BD")]
		[FieldOffset(Offset = "0x78")]
		private Animator _animator;

		[Token(Token = "0x40044BE")]
		[FieldOffset(Offset = "0x80")]
		private int _paramID;

		[Token(Token = "0x6005A61")]
		[Address(RVA = "0x1036F4C", Offset = "0x1036F4C", VA = "0x1036F4C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005A62")]
		[Address(RVA = "0x1036F5C", Offset = "0x1036F5C", VA = "0x1036F5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005A63")]
		[Address(RVA = "0x10371E4", Offset = "0x10371E4", VA = "0x10371E4")]
		public void OnAnimatorMoveEvent()
		{
		}

		[Token(Token = "0x6005A64")]
		[Address(RVA = "0x1037268", Offset = "0x1037268", VA = "0x1037268", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005A65")]
		[Address(RVA = "0x1037140", Offset = "0x1037140", VA = "0x1037140")]
		private void SetParameter()
		{
		}

		[Token(Token = "0x6005A66")]
		[Address(RVA = "0x10372EC", Offset = "0x10372EC", VA = "0x10372EC", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x6005A67")]
		[Address(RVA = "0x10373D4", Offset = "0x10373D4", VA = "0x10373D4")]
		public SetAnimatorQuaternion()
		{
		}
	}
}
