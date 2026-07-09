using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using Technology.Analytics;

[Token(Token = "0x20004A2")]
public class GDPRData : ISaveable
{
	[Token(Token = "0x20004A3")]
	public class AnalyticsFlushPermissionProvider : IFlushPermissionProvider
	{
		[Token(Token = "0x17000464")]
		private bool Technology_002EAnalytics_002EIFlushPermissionProvider_002ECanFlush
		{
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x871BB0", Offset = "0x871BB0", VA = "0x871BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400006D")]
		public event Action<bool> CanFlushStateChanged
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x871A80", Offset = "0x871A80", VA = "0x871A80", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x871B18", Offset = "0x871B18", VA = "0x871B18", Slot = "5")]
			remove
			{
			}
		}

		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x871C40", Offset = "0x871C40", VA = "0x871C40")]
		public AnalyticsFlushPermissionProvider()
		{
		}
	}

	[Token(Token = "0x20004A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594C48", Offset = "0x594C48")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x10")]
		public GDPRData _003C_003E4__this;

		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x18")]
		public ModelContainer modelContainer;

		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x871A54", Offset = "0x871A54", VA = "0x871A54")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x871A5C", Offset = "0x871A5C", VA = "0x871A5C")]
		internal void _003CShowPopup_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x18")]
	private bool _documentsAccepted;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6D5C", Offset = "0x5B6D5C")]
	private long _dateAcceptedBinary;

	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6D6C", Offset = "0x5B6D6C")]
	private GlobalConfig.DocumentVersion _privacyPolicyVersionAccepted;

	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B6D7C", Offset = "0x5B6D7C")]
	private GlobalConfig.DocumentVersion _termsVersionAccepted;

	[Token(Token = "0x17000463")]
	public bool DocumentsAccepted
	{
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x95E1E4", Offset = "0x95E1E4", VA = "0x95E1E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x95E1EC", Offset = "0x95E1EC", VA = "0x95E1EC")]
		set
		{
		}
	}

	[Token(Token = "0x1400006C")]
	public event Action<bool> DocumentsAcceptedChanged
	{
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x95E0A4", Offset = "0x95E0A4", VA = "0x95E0A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618598", Offset = "0x618598")]
		add
		{
		}
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x95E144", Offset = "0x95E144", VA = "0x95E144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6185A8", Offset = "0x6185A8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x95E270", Offset = "0x95E270", VA = "0x95E270")]
	public bool CheckDocumentsAccepted(ModelContainer modelContainer)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x95E420", Offset = "0x95E420", VA = "0x95E420")]
	private void ShowPopup(ModelContainer modelContainer)
	{
	}

	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x95E5DC", Offset = "0x95E5DC", VA = "0x95E5DC")]
	private void OnGDPRAccepted(ModelContainer modelContainer)
	{
	}

	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x95E3C0", Offset = "0x95E3C0", VA = "0x95E3C0")]
	private bool IsPrivacyPolicyAndTermsVersionsAccepted(GlobalConfig.DocumentVersion privacyPolicyVersion, GlobalConfig.DocumentVersion termsVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x95E754", Offset = "0x95E754", VA = "0x95E754")]
	private void SetAcceptedVersion(GlobalConfig.DocumentVersion privacyPolicy, GlobalConfig.DocumentVersion terms)
	{
	}

	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x95E7EC", Offset = "0x95E7EC", VA = "0x95E7EC")]
	private bool IsVersionAlreadyAccepted(GlobalConfig.DocumentVersion lastAccepted, GlobalConfig.DocumentVersion latestVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x95E81C", Offset = "0x95E81C", VA = "0x95E81C", Slot = "4")]
	private void Technology_002EISaveable_002EOnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x95E8A4", Offset = "0x95E8A4", VA = "0x95E8A4", Slot = "5")]
	private JSONNode Technology_002EISaveable_002EOnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x95E91C", Offset = "0x95E91C", VA = "0x95E91C")]
	public GDPRData()
	{
	}
}
