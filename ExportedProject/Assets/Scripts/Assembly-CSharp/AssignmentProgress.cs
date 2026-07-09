using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003E9")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593834", Offset = "0x593834")]
public class AssignmentProgress : FsmStateAction
{
	[Token(Token = "0x20003EA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x59386C", Offset = "0x59386C")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x40015C6")]
		[FieldOffset(Offset = "0x10")]
		public AssignmentData assignment;

		[Token(Token = "0x6001823")]
		[Address(RVA = "0x92516C", Offset = "0x92516C", VA = "0x92516C")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6001824")]
		[Address(RVA = "0x925174", Offset = "0x925174", VA = "0x925174")]
		internal void _003COnEnter_003Eb__0(int a)
		{
		}

		[Token(Token = "0x6001825")]
		[Address(RVA = "0x925190", Offset = "0x925190", VA = "0x925190")]
		internal void _003COnEnter_003Eb__1(int a)
		{
		}
	}

	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B51E0", Offset = "0x5B51E0")]
	public FsmInt ProgressIncrementVar;

	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B51F4", Offset = "0x5B51F4")]
	public FsmInt ProgressSetVar;

	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5208", Offset = "0x5B5208")]
	public FsmBool TrackProgress;

	[Token(Token = "0x40015C5")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B521C", Offset = "0x5B521C")]
	public FsmBool AffectMainProgress;

	[Token(Token = "0x6001820")]
	[Address(RVA = "0xC032BC", Offset = "0xC032BC", VA = "0xC032BC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001821")]
	[Address(RVA = "0xC03690", Offset = "0xC03690", VA = "0xC03690")]
	private int GetProgress(int previousProgress)
	{
		return default(int);
	}

	[Token(Token = "0x6001822")]
	[Address(RVA = "0xC03724", Offset = "0xC03724", VA = "0xC03724")]
	public AssignmentProgress()
	{
	}
}
