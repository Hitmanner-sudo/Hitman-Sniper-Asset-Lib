using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FCA")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59ECA8", Offset = "0x59ECA8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59ECA8", Offset = "0x59ECA8")]
	public class ActivateSolo : FsmStateAction
	{
		[Token(Token = "0x4004A53")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5E10", Offset = "0x5D5E10")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A54")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5E5C", Offset = "0x5D5E5C")]
		public FsmBool allowReactivate;

		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0xD59720", Offset = "0xD59720", VA = "0xD59720", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F60")]
		[Address(RVA = "0xD59790", Offset = "0xD59790", VA = "0xD59790", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F61")]
		[Address(RVA = "0xD597B8", Offset = "0xD597B8", VA = "0xD597B8")]
		private void DoActivateSolo()
		{
		}

		[Token(Token = "0x6005F62")]
		[Address(RVA = "0xD59BC4", Offset = "0xD59BC4", VA = "0xD59BC4")]
		public ActivateSolo()
		{
		}
	}
}
