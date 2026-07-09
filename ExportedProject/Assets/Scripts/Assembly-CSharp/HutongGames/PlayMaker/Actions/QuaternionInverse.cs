using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010D2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A41BC", Offset = "0x5A41BC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A41BC", Offset = "0x5A41BC")]
	public class QuaternionInverse : QuaternionBaseAction
	{
		[Token(Token = "0x4004F69")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB984", Offset = "0x5EB984")]
		public FsmQuaternion rotation;

		[Token(Token = "0x4004F6A")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EB9D0", Offset = "0x5EB9D0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EB9D0", Offset = "0x5EB9D0")]
		public FsmQuaternion result;

		[Token(Token = "0x6006438")]
		[Address(RVA = "0xB3D294", Offset = "0xB3D294", VA = "0xB3D294", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006439")]
		[Address(RVA = "0xB3D2A8", Offset = "0xB3D2A8", VA = "0xB3D2A8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600643A")]
		[Address(RVA = "0xB3D328", Offset = "0xB3D328", VA = "0xB3D328", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600643B")]
		[Address(RVA = "0xB3D338", Offset = "0xB3D338", VA = "0xB3D338", Slot = "36")]
		public override void OnLateUpdate()
		{
		}

		[Token(Token = "0x600643C")]
		[Address(RVA = "0xB3D34C", Offset = "0xB3D34C", VA = "0xB3D34C", Slot = "33")]
		public override void OnFixedUpdate()
		{
		}

		[Token(Token = "0x600643D")]
		[Address(RVA = "0xB3D2E4", Offset = "0xB3D2E4", VA = "0xB3D2E4")]
		private void DoQuatInverse()
		{
		}

		[Token(Token = "0x600643E")]
		[Address(RVA = "0xB3D360", Offset = "0xB3D360", VA = "0xB3D360")]
		public QuaternionInverse()
		{
		}
	}
}
