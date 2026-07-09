using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000909")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x596E2C", Offset = "0x596E2C")]
public class HelpshiftConfiguration : ScriptableObject
{
	[Token(Token = "0x40031A3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal string _apiKey;

	[Token(Token = "0x40031A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal string _domainName;

	[Token(Token = "0x40031A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal string _androidAppId;

	[Token(Token = "0x40031A6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal string _iosAppId;

	[Token(Token = "0x60039DC")]
	[Address(RVA = "0xA0ED30", Offset = "0xA0ED30", VA = "0xA0ED30")]
	public HelpshiftConfiguration()
	{
	}
}
