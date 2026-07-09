using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BE3")]
	public class IAPBundleEntry
	{
		[Token(Token = "0x4003B84")]
		[FieldOffset(Offset = "0x0")]
		private static int index;

		[Token(Token = "0x4003B85")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD894", Offset = "0x5BD894")]
		private int _003CVersion_003Ek__BackingField;

		[Token(Token = "0x4003B86")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD8A4", Offset = "0x5BD8A4")]
		private IAPBundlePrefabMeta _003CPrefabMeta_003Ek__BackingField;

		[Token(Token = "0x4003B87")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD8B4", Offset = "0x5BD8B4")]
		private bool _003CShowDependencies_003Ek__BackingField;

		[Token(Token = "0x1700098B")]
		public int Version
		{
			[Token(Token = "0x6004B52")]
			[Address(RVA = "0xA160F4", Offset = "0xA160F4", VA = "0xA160F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281B0", Offset = "0x6281B0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004B53")]
			[Address(RVA = "0xA160FC", Offset = "0xA160FC", VA = "0xA160FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281C0", Offset = "0x6281C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700098C")]
		public IAPBundlePrefabMeta PrefabMeta
		{
			[Token(Token = "0x6004B54")]
			[Address(RVA = "0xA16104", Offset = "0xA16104", VA = "0xA16104")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281D0", Offset = "0x6281D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B55")]
			[Address(RVA = "0xA1610C", Offset = "0xA1610C", VA = "0xA1610C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281E0", Offset = "0x6281E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700098D")]
		public bool ShowDependencies
		{
			[Token(Token = "0x6004B56")]
			[Address(RVA = "0xA16114", Offset = "0xA16114", VA = "0xA16114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6281F0", Offset = "0x6281F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B57")]
			[Address(RVA = "0xA1611C", Offset = "0xA1611C", VA = "0xA1611C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x628200", Offset = "0x628200")]
			set
			{
			}
		}

		[Token(Token = "0x6004B58")]
		[Address(RVA = "0xA16128", Offset = "0xA16128", VA = "0xA16128")]
		public IAPBundleEntry()
		{
		}

		[Token(Token = "0x6004B59")]
		[Address(RVA = "0xA161C0", Offset = "0xA161C0", VA = "0xA161C0")]
		public JSONNode ToJSON()
		{
			return null;
		}
	}
}
