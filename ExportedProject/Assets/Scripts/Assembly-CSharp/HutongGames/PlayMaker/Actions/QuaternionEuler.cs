using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A416C", Offset = "0x5A416C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A416C", Offset = "0x5A416C")]
	public class QuaternionEuler : QuaternionBaseAction
	{
		[Token(Token = "0x4004F67")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB8D8", Offset = "0x5EB8D8")]
		public FsmVector3 eulerAngles;

		[Token(Token = "0x4004F68")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB924", Offset = "0x5EB924")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB924", Offset = "0x5EB924")]
		public FsmQuaternion result;

		[Token(Token = "0x6006431")]
		[Address(RVA = "0xB3D1BC", Offset = "0xB3D1BC", VA = "0xB3D1BC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006432")]
		[Address(RVA = "0xB3D1D0", Offset = "0xB3D1D0", VA = "0xB3D1D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006433")]
		[Address(RVA = "0xB3D254", Offset = "0xB3D254", VA = "0xB3D254", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006434")]
		[Address(RVA = "0xB3D264", Offset = "0xB3D264", VA = "0xB3D264", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x6006435")]
		[Address(RVA = "0xB3D278", Offset = "0xB3D278", VA = "0xB3D278", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x6006436")]
		[Address(RVA = "0xB3D20C", Offset = "0xB3D20C", VA = "0xB3D20C")]
		private void DoQuatEuler()
		{
		}

		[Token(Token = "0x6006437")]
		[Address(RVA = "0xB3D28C", Offset = "0xB3D28C", VA = "0xB3D28C")]
		public QuaternionEuler()
		{
		}
	}
}
