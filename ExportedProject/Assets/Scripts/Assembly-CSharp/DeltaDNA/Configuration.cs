using Il2CppDummyDll;
using UnityEngine;

namespace DeltaDNA
{
	[Token(Token = "0x2001303")]
	public class Configuration : ScriptableObject
	{
		[Token(Token = "0x4005B1C")]
		public const string RUNTIME_RSRC_PATH = "ddna_configuration";

		[Token(Token = "0x4005B1D")]
		public const string RESOURCES_CONTAINER = "Assets";

		[Token(Token = "0x4005B1E")]
		public const string RESOURCES_DIRECTORY = "Resources";

		[Token(Token = "0x4005B1F")]
		public const string ASSET_DIRECTORY = "Assets/Resources";

		[Token(Token = "0x4005B20")]
		public const string FULL_ASSET_PATH = "Assets/Resources/ddna_configuration.asset";

		[Token(Token = "0x4005B21")]
		[FieldOffset(Offset = "0x18")]
		public string environmentKeyDev;

		[Token(Token = "0x4005B22")]
		[FieldOffset(Offset = "0x20")]
		public string environmentKeyLive;

		[Token(Token = "0x4005B23")]
		[FieldOffset(Offset = "0x28")]
		public int environmentKey;

		[Token(Token = "0x4005B24")]
		[FieldOffset(Offset = "0x30")]
		public string collectUrl;

		[Token(Token = "0x4005B25")]
		[FieldOffset(Offset = "0x38")]
		public string engageUrl;

		[Token(Token = "0x4005B26")]
		[FieldOffset(Offset = "0x40")]
		public string hashSecret;

		[Token(Token = "0x4005B27")]
		[FieldOffset(Offset = "0x48")]
		public string clientVersion;

		[Token(Token = "0x4005B28")]
		[FieldOffset(Offset = "0x50")]
		public bool useApplicationVersion;

		[Token(Token = "0x6006FAB")]
		[Address(RVA = "0x8DFF6C", Offset = "0x8DFF6C", VA = "0x8DFF6C")]
		public static Configuration GetAssetInstance()
		{
			return null;
		}

		[Token(Token = "0x6006FAC")]
		[Address(RVA = "0x8E003C", Offset = "0x8E003C", VA = "0x8E003C")]
		public Configuration()
		{
		}
	}
}
