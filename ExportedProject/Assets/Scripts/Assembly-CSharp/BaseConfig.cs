using Il2CppDummyDll;
using Technology.Distribution;

[Token(Token = "0x2000845")]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x5967D8", Offset = "0x5967D8")]
public class BaseConfig<T> : DisplayableConfig where T : BaseConfig<T>
{
	[Token(Token = "0x4002EBF")]
	[FieldOffset(Offset = "0x0")]
	public string ConfigSubPath;

	[Token(Token = "0x4002EC0")]
	[FieldOffset(Offset = "0x0")]
	private static bool _bundleEventRegistered;

	[Token(Token = "0x4002EC1")]
	[FieldOffset(Offset = "0x0")]
	private static BaseConfig<T>[] ms_Configs;

	[Token(Token = "0x4002EC2")]
	[FieldOffset(Offset = "0x0")]
	private static int m_CurrentConfigIndex;

	[Token(Token = "0x4002EC3")]
	[FieldOffset(Offset = "0x0")]
	private static T ms_Instance;

	[Token(Token = "0x170006DD")]
	public static T Instance
	{
		[Token(Token = "0x6003609")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DE")]
	private static string PrefKeyIndex
	{
		[Token(Token = "0x600360A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DF")]
	public override DisplayableConfig Item
	{
		[Token(Token = "0x600360B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E0")]
	public override int Count
	{
		[Token(Token = "0x600360C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006E1")]
	public override int CurrentIndex
	{
		[Token(Token = "0x600360D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600360E")]
	public override void SetInstance(int index)
	{
	}

	[Token(Token = "0x600360F")]
	public static void Create()
	{
	}

	[Token(Token = "0x6003610")]
	public override void ResetInstance()
	{
	}

	[Token(Token = "0x6003611")]
	private static void OnDownloadReady(Bundle b)
	{
	}

	[Token(Token = "0x6003612")]
	private static void StaticSetInstance(int index)
	{
	}

	[Token(Token = "0x6003613")]
	public BaseConfig()
	{
	}
}
