using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F0E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B2E0", Offset = "0x59B2E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B2E0", Offset = "0x59B2E0")]
	public class ArrayAddSpawners : FsmStateAction
	{
		[Token(Token = "0x4004723")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9980", Offset = "0x5C9980")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9980", Offset = "0x5C9980")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x4004724")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C99E0", Offset = "0x5C99E0")]
		[RequiredField]
		public FsmGameObject value;

		[Token(Token = "0x4004725")]
		[FieldOffset(Offset = "0x60")]
		public FsmBool SearchInChildren;

		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0xD55FA8", Offset = "0xD55FA8", VA = "0xD55FA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0xD55FB0", Offset = "0xD55FB0", VA = "0xD55FB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0xD55FD8", Offset = "0xD55FD8", VA = "0xD55FD8")]
		private void DoAddValue()
		{
		}

		[Token(Token = "0x6005C90")]
		[Address(RVA = "0xD560A0", Offset = "0xD560A0", VA = "0xD560A0")]
		private void AddGameObject(Spawner[] spawnerObjectArray)
		{
		}

		[Token(Token = "0x6005C91")]
		[Address(RVA = "0xD56170", Offset = "0xD56170", VA = "0xD56170")]
		public ArrayAddSpawners()
		{
		}
	}
}
