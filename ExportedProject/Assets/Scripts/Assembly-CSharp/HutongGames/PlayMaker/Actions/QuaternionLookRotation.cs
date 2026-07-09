using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A425C", Offset = "0x5A425C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A425C", Offset = "0x5A425C")]
	public class QuaternionLookRotation : QuaternionBaseAction
	{
		[Token(Token = "0x4004F6F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBB8C", Offset = "0x5EBB8C")]
		public FsmVector3 direction;

		[Token(Token = "0x4004F70")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBBD8", Offset = "0x5EBBD8")]
		public FsmVector3 upVector;

		[Token(Token = "0x4004F71")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EBC10", Offset = "0x5EBC10")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EBC10", Offset = "0x5EBC10")]
		public FsmQuaternion result;

		[Token(Token = "0x6006446")]
		[Address(RVA = "0xB3D544", Offset = "0xB3D544", VA = "0xB3D544", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006447")]
		[Address(RVA = "0xB3D5BC", Offset = "0xB3D5BC", VA = "0xB3D5BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006448")]
		[Address(RVA = "0xB3D6C4", Offset = "0xB3D6C4", VA = "0xB3D6C4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006449")]
		[Address(RVA = "0xB3D6D4", Offset = "0xB3D6D4", VA = "0xB3D6D4", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600644A")]
		[Address(RVA = "0xB3D6E8", Offset = "0xB3D6E8", VA = "0xB3D6E8", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600644B")]
		[Address(RVA = "0xB3D5F8", Offset = "0xB3D5F8", VA = "0xB3D5F8")]
		private void DoQuatLookRotation()
		{
		}

		[Token(Token = "0x600644C")]
		[Address(RVA = "0xB3D6FC", Offset = "0xB3D6FC", VA = "0xB3D6FC")]
		public QuaternionLookRotation()
		{
		}
	}
}
