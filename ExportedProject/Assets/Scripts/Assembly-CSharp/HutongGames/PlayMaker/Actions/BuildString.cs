using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118A")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8824", Offset = "0x5A8824")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8824", Offset = "0x5A8824")]
	public class BuildString : FsmStateAction
	{
		[Token(Token = "0x4005375")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA034", Offset = "0x5FA034")]
		[RequiredField]
		public FsmString[] stringParts;

		[Token(Token = "0x4005376")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA080", Offset = "0x5FA080")]
		public FsmString separator;

		[Token(Token = "0x4005377")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA0B8", Offset = "0x5FA0B8")]
		public FsmBool addToEnd;

		[Token(Token = "0x4005378")]
		[FieldOffset(Offset = "0x68")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA0F0", Offset = "0x5FA0F0")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA0F0", Offset = "0x5FA0F0")]
		public FsmString storeResult;

		[Token(Token = "0x4005379")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA150", Offset = "0x5FA150")]
		public bool everyFrame;

		[Token(Token = "0x400537A")]
		[FieldOffset(Offset = "0x78")]
		private string result;

		[Token(Token = "0x600676F")]
		[Address(RVA = "0xA811A0", Offset = "0xA811A0", VA = "0xA811A0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006770")]
		[Address(RVA = "0xA81208", Offset = "0xA81208", VA = "0xA81208", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006771")]
		[Address(RVA = "0xA813F0", Offset = "0xA813F0", VA = "0xA813F0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006772")]
		[Address(RVA = "0xA81244", Offset = "0xA81244", VA = "0xA81244")]
		private void DoBuildString()
		{
		}

		[Token(Token = "0x6006773")]
		[Address(RVA = "0xA813F4", Offset = "0xA813F4", VA = "0xA813F4")]
		public BuildString()
		{
		}
	}
}
