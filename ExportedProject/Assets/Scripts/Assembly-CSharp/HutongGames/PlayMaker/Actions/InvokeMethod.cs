using Il2CppDummyDll;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200112F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A5D70", Offset = "0x5A5D70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A5D70", Offset = "0x5A5D70")]
	public class InvokeMethod : FsmStateAction
	{
		[Token(Token = "0x400519B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3BE0", Offset = "0x5F3BE0")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x400519C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3C2C", Offset = "0x5F3C2C")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3C2C", Offset = "0x5F3C2C")]
		public FsmString behaviour;

		[Token(Token = "0x400519D")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F3C8C", Offset = "0x5F3C8C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3C8C", Offset = "0x5F3C8C")]
		public FsmString methodName;

		[Token(Token = "0x400519E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F3CEC", Offset = "0x5F3CEC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3CEC", Offset = "0x5F3CEC")]
		public FsmFloat delay;

		[Token(Token = "0x400519F")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3D40", Offset = "0x5F3D40")]
		public FsmBool repeating;

		[Token(Token = "0x40051A0")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5F3D78", Offset = "0x5F3D78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3D78", Offset = "0x5F3D78")]
		public FsmFloat repeatDelay;

		[Token(Token = "0x40051A1")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F3DCC", Offset = "0x5F3DCC")]
		public FsmBool cancelOnExit;

		[Token(Token = "0x40051A2")]
		[FieldOffset(Offset = "0x88")]
		private MonoBehaviour component;

		[Token(Token = "0x60065E4")]
		[Address(RVA = "0x10BD32C", Offset = "0x10BD32C", VA = "0x10BD32C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60065E5")]
		[Address(RVA = "0x10BD3B4", Offset = "0x10BD3B4", VA = "0x10BD3B4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60065E6")]
		[Address(RVA = "0x10BD3FC", Offset = "0x10BD3FC", VA = "0x10BD3FC")]
		private void DoInvokeMethod(GameObject go)
		{
		}

		[Token(Token = "0x60065E7")]
		[Address(RVA = "0x10BD69C", Offset = "0x10BD69C", VA = "0x10BD69C", Slot = "37")]
		public override void OnExit()
		{
		}

		[Token(Token = "0x60065E8")]
		[Address(RVA = "0x10BD758", Offset = "0x10BD758", VA = "0x10BD758")]
		public InvokeMethod()
		{
		}
	}
}
