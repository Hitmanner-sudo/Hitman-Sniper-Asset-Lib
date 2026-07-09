using Il2CppDummyDll;

[Token(Token = "0x20008E6")]
public abstract class LazyReferenceUsageWrapperBase
{
	[Token(Token = "0x20008E7")]
	public enum DisposeAction
	{
		[Token(Token = "0x400312D")]
		Clear = 0,
		[Token(Token = "0x400312E")]
		Release = 1
	}

	[Token(Token = "0x400312B")]
	[FieldOffset(Offset = "0x10")]
	private readonly DisposeAction _disposeAction;

	[Token(Token = "0x17000729")]
	protected DisposeAction Action
	{
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x99770C", Offset = "0x99770C", VA = "0x99770C")]
		get
		{
			return default(DisposeAction);
		}
	}

	[Token(Token = "0x6003917")]
	[Address(RVA = "0x997714", Offset = "0x997714", VA = "0x997714")]
	protected LazyReferenceUsageWrapperBase(DisposeAction disposeAction = DisposeAction.Clear)
	{
	}
}
