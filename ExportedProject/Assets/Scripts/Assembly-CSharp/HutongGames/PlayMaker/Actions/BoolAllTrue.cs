using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001017")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0510", Offset = "0x5A0510")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0510", Offset = "0x5A0510")]
	public class BoolAllTrue : FsmStateAction
	{
		[Token(Token = "0x4004B81")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DACA8", Offset = "0x5DACA8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DACA8", Offset = "0x5DACA8")]
		[Readonly]
		public FsmBool[] boolVariables;

		[Token(Token = "0x4004B82")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAD18", Offset = "0x5DAD18")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B83")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DAD50", Offset = "0x5DAD50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAD50", Offset = "0x5DAD50")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B84")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DADA0", Offset = "0x5DADA0")]
		public bool everyFrame;

		[Token(Token = "0x6006098")]
		[Address(RVA = "0xA7F0F0", Offset = "0xA7F0F0", VA = "0xA7F0F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006099")]
		[Address(RVA = "0xA7F100", Offset = "0xA7F100", VA = "0xA7F100", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600609A")]
		[Address(RVA = "0xA7F20C", Offset = "0xA7F20C", VA = "0xA7F20C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600609B")]
		[Address(RVA = "0xA7F13C", Offset = "0xA7F13C", VA = "0xA7F13C")]
		private void DoAllTrue()
		{
		}

		[Token(Token = "0x600609C")]
		[Address(RVA = "0xA7F210", Offset = "0xA7F210", VA = "0xA7F210")]
		private void EndTutorialZombieMode(ref bool allTrue)
		{
		}

		[Token(Token = "0x600609D")]
		[Address(RVA = "0xA7F2B0", Offset = "0xA7F2B0", VA = "0xA7F2B0")]
		public BoolAllTrue()
		{
		}
	}
}
