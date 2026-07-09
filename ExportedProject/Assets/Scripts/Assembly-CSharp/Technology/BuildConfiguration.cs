using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A6A")]
	public class BuildConfiguration : ScriptableObject
	{
		[Token(Token = "0x4003656")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlatformID _bundleIdentifier;

		[Token(Token = "0x4003657")]
		[FieldOffset(Offset = "0x30")]
		public int BuildIdentifier;

		[Token(Token = "0x4003658")]
		[FieldOffset(Offset = "0x34")]
		public bool EnableIOSLocalBundles;

		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x35")]
		public bool EnableAndroidLocalBundles;

		[Token(Token = "0x400365A")]
		[FieldOffset(Offset = "0x36")]
		public bool EnableStandaloneLocalBundles;

		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x37")]
		public bool EnableLocalPrefabBundleBuilds;

		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x38")]
		public bool EnableLoadFromBundles;

		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x39")]
		public bool EnableRemoteBundles;

		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x3A")]
		public bool EnableReleaseDevBuild;

		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x0")]
		private static BuildConfiguration _buildSettings;

		[Token(Token = "0x17000870")]
		public static bool IsBuildServer
		{
			[Token(Token = "0x60041C3")]
			[Address(RVA = "0xA80F98", Offset = "0xA80F98", VA = "0xA80F98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000871")]
		public string BundleIdentifier
		{
			[Token(Token = "0x60041C4")]
			[Address(RVA = "0xA80FA0", Offset = "0xA80FA0", VA = "0xA80FA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000872")]
		public static BuildConfiguration Settings
		{
			[Token(Token = "0x60041C5")]
			[Address(RVA = "0xA80FD4", Offset = "0xA80FD4", VA = "0xA80FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60041C6")]
		[Address(RVA = "0xA8112C", Offset = "0xA8112C", VA = "0xA8112C")]
		public BuildConfiguration()
		{
		}
	}
}
