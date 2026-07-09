using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200100D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A01C4", Offset = "0x5A01C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A01C4", Offset = "0x5A01C4")]
	public class LoadLevelNum : FsmStateAction
	{
		[Token(Token = "0x4004B67")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA3A4", Offset = "0x5DA3A4")]
		public FsmInt levelIndex;

		[Token(Token = "0x4004B68")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA3F0", Offset = "0x5DA3F0")]
		public bool additive;

		[Token(Token = "0x4004B69")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA428", Offset = "0x5DA428")]
		public FsmEvent loadedEvent;

		[Token(Token = "0x4004B6A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA460", Offset = "0x5DA460")]
		public FsmBool dontDestroyOnLoad;

		[Token(Token = "0x4004B6B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DA498", Offset = "0x5DA498")]
		public FsmEvent failedEvent;

		[Token(Token = "0x600606E")]
		[Address(RVA = "0x9CA288", Offset = "0x9CA288", VA = "0x9CA288", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600606F")]
		[Address(RVA = "0x9CA2C0", Offset = "0x9CA2C0", VA = "0x9CA2C0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006070")]
		[Address(RVA = "0x9CA43C", Offset = "0x9CA43C", VA = "0x9CA43C")]
		public LoadLevelNum()
		{
		}
	}
}
