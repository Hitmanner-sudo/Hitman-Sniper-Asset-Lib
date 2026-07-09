using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003EC")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5938B4", Offset = "0x5938B4")]
public class AssignmentSetCompletionProgression : FsmStateAction
{
	[Token(Token = "0x20003ED")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5938EC", Offset = "0x5938EC")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40015CB")]
		[FieldOffset(Offset = "0x10")]
		public AssignmentData assignment;

		[Token(Token = "0x600182A")]
		[Address(RVA = "0x9251AC", Offset = "0x9251AC", VA = "0x9251AC")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600182B")]
		[Address(RVA = "0x9251B4", Offset = "0x9251B4", VA = "0x9251B4")]
		internal void _003COnEnter_003Eb__0(int a)
		{
		}

		[Token(Token = "0x600182C")]
		[Address(RVA = "0x9251D0", Offset = "0x9251D0", VA = "0x9251D0")]
		internal void _003COnEnter_003Eb__1(int a)
		{
		}
	}

	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5244", Offset = "0x5B5244")]
	public FsmInt Progression;

	[Token(Token = "0x40015C9")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5258", Offset = "0x5B5258")]
	public FsmInt Progression2;

	[Token(Token = "0x40015CA")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B526C", Offset = "0x5B526C")]
	public FsmBool AffectMainProgress;

	[Token(Token = "0x6001828")]
	[Address(RVA = "0xC039D0", Offset = "0xC039D0", VA = "0xC039D0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001829")]
	[Address(RVA = "0xC03CD8", Offset = "0xC03CD8", VA = "0xC03CD8")]
	public AssignmentSetCompletionProgression()
	{
	}
}
