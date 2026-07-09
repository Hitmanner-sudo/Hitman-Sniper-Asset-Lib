using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200000F")]
public class HelpshiftConfig : ScriptableObject
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x0")]
	private static HelpshiftConfig instance;

	[Token(Token = "0x4000016")]
	private const string helpshiftConfigAssetName = "HelpshiftConfig";

	[Token(Token = "0x4000017")]
	private const string helpshiftConfigPath = "Helpshift/Resources";

	[Token(Token = "0x4000018")]
	public const string pluginVersion = "5.6.1";

	[Token(Token = "0x1700000F")]
	public static HelpshiftConfig Instance
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA0EC08", Offset = "0xA0EC08", VA = "0xA0EC08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xA0ED28", Offset = "0xA0ED28", VA = "0xA0ED28")]
	public HelpshiftConfig()
	{
	}
}
