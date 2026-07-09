using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8964", Offset = "0x5A8964")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8964", Offset = "0x5A8964")]
	public class GetStringRight : FsmStateAction
	{
		[Token(Token = "0x4005387")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA4CC", Offset = "0x5FA4CC")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA4CC", Offset = "0x5FA4CC")]
		public FsmString stringVariable;

		[Token(Token = "0x4005388")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA52C", Offset = "0x5FA52C")]
		public FsmInt charCount;

		[Token(Token = "0x4005389")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA564", Offset = "0x5FA564")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA564", Offset = "0x5FA564")]
		public FsmString storeResult;

		[Token(Token = "0x400538A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA5C4", Offset = "0x5FA5C4")]
		public bool everyFrame;

		[Token(Token = "0x6006783")]
		[Address(RVA = "0xC7FC14", Offset = "0xC7FC14", VA = "0xC7FC14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006784")]
		[Address(RVA = "0xC7FC48", Offset = "0xC7FC48", VA = "0xC7FC48", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006785")]
		[Address(RVA = "0xC7FD2C", Offset = "0xC7FD2C", VA = "0xC7FD2C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006786")]
		[Address(RVA = "0xC7FC84", Offset = "0xC7FC84", VA = "0xC7FC84")]
		private void DoGetStringRight()
		{
		}

		[Token(Token = "0x6006787")]
		[Address(RVA = "0xC7FD30", Offset = "0xC7FD30", VA = "0xC7FD30")]
		public GetStringRight()
		{
		}
	}
}
