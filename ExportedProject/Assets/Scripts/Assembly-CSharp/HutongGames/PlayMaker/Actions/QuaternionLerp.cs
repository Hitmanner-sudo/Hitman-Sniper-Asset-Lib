using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A420C", Offset = "0x5A420C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A420C", Offset = "0x5A420C")]
	public class QuaternionLerp : QuaternionBaseAction
	{
		[Token(Token = "0x4004F6B")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBA30", Offset = "0x5EBA30")]
		public FsmQuaternion fromQuaternion;

		[Token(Token = "0x4004F6C")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBA7C", Offset = "0x5EBA7C")]
		public FsmQuaternion toQuaternion;

		[Token(Token = "0x4004F6D")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBAC8", Offset = "0x5EBAC8")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5EBAC8", Offset = "0x5EBAC8")]
		public FsmFloat amount;

		[Token(Token = "0x4004F6E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBB2C", Offset = "0x5EBB2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBB2C", Offset = "0x5EBB2C")]
		[RequiredField]
		public FsmQuaternion storeResult;

		[Token(Token = "0x600643F")]
		[Address(RVA = "0xB3D368", Offset = "0xB3D368", VA = "0xB3D368", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006440")]
		[Address(RVA = "0xB3D414", Offset = "0xB3D414", VA = "0xB3D414", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006441")]
		[Address(RVA = "0xB3D504", Offset = "0xB3D504", VA = "0xB3D504", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006442")]
		[Address(RVA = "0xB3D514", Offset = "0xB3D514", VA = "0xB3D514", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006443")]
		[Address(RVA = "0xB3D528", Offset = "0xB3D528", VA = "0xB3D528", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006444")]
		[Address(RVA = "0xB3D450", Offset = "0xB3D450", VA = "0xB3D450")]
		private void DoQuatLerp()
		{
		}

		[Token(Token = "0x6006445")]
		[Address(RVA = "0xB3D53C", Offset = "0xB3D53C", VA = "0xB3D53C")]
		public QuaternionLerp()
		{
		}
	}
}
