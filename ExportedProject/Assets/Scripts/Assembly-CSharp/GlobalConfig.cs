using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x20001FD")]
public class GlobalConfig : ISaveable
{
	[Token(Token = "0x20001FE")]
	public struct DocumentVersion : ISaveable
	{
		[Serializable]
		[Token(Token = "0x20001FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A1C", Offset = "0x592A1C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000B9A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0xA45CE8", Offset = "0xA45CE8", VA = "0xA45CE8")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string MAJOR_FIELD_NAME;

		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string MINOR_FIELD_NAME;

		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C88", Offset = "0x5B2C88")]
		private int _major;

		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C98", Offset = "0x5B2C98")]
		private int _minor;

		[Token(Token = "0x170001ED")]
		public int Major
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x876650", Offset = "0x876650", VA = "0x876650")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001EE")]
		public int Minor
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x876658", Offset = "0x876658", VA = "0x876658")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x876660", Offset = "0x876660", VA = "0x876660")]
		public DocumentVersion(int major, int minor)
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x876668", Offset = "0x876668", VA = "0x876668", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x876728", Offset = "0x876728", VA = "0x876728", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x4000B8F")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C18", Offset = "0x5B2C18")]
	public int MinimumMajorBuildVersion;

	[Token(Token = "0x4000B90")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C28", Offset = "0x5B2C28")]
	public int MinimumMinorBuildVersion;

	[Token(Token = "0x4000B91")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C38", Offset = "0x5B2C38")]
	public int MinimumRevisionBuildVersion;

	[Token(Token = "0x4000B92")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C48", Offset = "0x5B2C48")]
	private int _latestPrivacyPolicyVersionMajor;

	[Token(Token = "0x4000B93")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C58", Offset = "0x5B2C58")]
	private int _latestPrivacyPolicyVersionMinor;

	[Token(Token = "0x4000B94")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C68", Offset = "0x5B2C68")]
	private int _latestTermsVersionMajor;

	[Token(Token = "0x4000B95")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B2C78", Offset = "0x5B2C78")]
	private int _latestTermsVersionMinor;

	[Token(Token = "0x170001EB")]
	public DocumentVersion LatestPrivacyPolicyVersion
	{
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0xC82660", Offset = "0xC82660", VA = "0xC82660")]
		get
		{
			return default(DocumentVersion);
		}
	}

	[Token(Token = "0x170001EC")]
	public DocumentVersion LatestTermsVersion
	{
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0xC82690", Offset = "0xC82690", VA = "0xC82690")]
		get
		{
			return default(DocumentVersion);
		}
	}

	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0xC826C0", Offset = "0xC826C0", VA = "0xC826C0")]
	public GlobalConfig ShallowCopy()
	{
		return null;
	}

	[Token(Token = "0x6000C30")]
	[Address(RVA = "0xC82744", Offset = "0xC82744", VA = "0xC82744", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6000C31")]
	[Address(RVA = "0xC827CC", Offset = "0xC827CC", VA = "0xC827CC", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0xC82844", Offset = "0xC82844", VA = "0xC82844")]
	public bool Read(Dictionary<string, object> dictionary)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C33")]
	[Address(RVA = "0xC82F08", Offset = "0xC82F08", VA = "0xC82F08")]
	public GlobalConfig()
	{
	}
}
