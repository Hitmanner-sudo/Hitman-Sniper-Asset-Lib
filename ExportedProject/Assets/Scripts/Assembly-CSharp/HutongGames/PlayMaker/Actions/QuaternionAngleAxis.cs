using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010CD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A40CC", Offset = "0x5A40CC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A40CC", Offset = "0x5A40CC")]
	public class QuaternionAngleAxis : QuaternionBaseAction
	{
		[Token(Token = "0x4004F59")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB630", Offset = "0x5EB630")]
		[RequiredField]
		public FsmFloat angle;

		[Token(Token = "0x4004F5A")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB67C", Offset = "0x5EB67C")]
		public FsmVector3 axis;

		[Token(Token = "0x4004F5B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB6C8", Offset = "0x5EB6C8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB6C8", Offset = "0x5EB6C8")]
		[RequiredField]
		public FsmQuaternion result;

		[Token(Token = "0x6006421")]
		[Address(RVA = "0xB3CEA0", Offset = "0xB3CEA0", VA = "0xB3CEA0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006422")]
		[Address(RVA = "0xB3CEB8", Offset = "0xB3CEB8", VA = "0xB3CEB8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006423")]
		[Address(RVA = "0xB3CF74", Offset = "0xB3CF74", VA = "0xB3CF74", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006424")]
		[Address(RVA = "0xB3CF84", Offset = "0xB3CF84", VA = "0xB3CF84", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006425")]
		[Address(RVA = "0xB3CF98", Offset = "0xB3CF98", VA = "0xB3CF98", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006426")]
		[Address(RVA = "0xB3CEF4", Offset = "0xB3CEF4", VA = "0xB3CEF4")]
		private void DoQuatAngleAxis()
		{
		}

		[Token(Token = "0x6006427")]
		[Address(RVA = "0xB3CFAC", Offset = "0xB3CFAC", VA = "0xB3CFAC")]
		public QuaternionAngleAxis()
		{
		}
	}
}
