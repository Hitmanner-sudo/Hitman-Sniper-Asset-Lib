using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core;
using UnityEngine;

[Token(Token = "0x2000200")]
[AttributeAttribute(Name = "ResourcePathAttribute", RVA = "0x592A2C", Offset = "0x592A2C")]
public class GlobalConfigManager : ScriptableSingleton<GlobalConfigManager>
{
	[Token(Token = "0x2000201")]
	public enum VersionCheckResult
	{
		[Token(Token = "0x4000BA6")]
		Unavailable = 0,
		[Token(Token = "0x4000BA7")]
		ClientUpdateRequired = 1,
		[Token(Token = "0x4000BA8")]
		Ok = 2
	}

	[Token(Token = "0x2000202")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A64", Offset = "0x592A64")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x10")]
		public Action<VersionCheckResult> result;

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x876A54", Offset = "0x876A54", VA = "0x876A54")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x876A5C", Offset = "0x876A5C", VA = "0x876A5C")]
		internal void _003CCheckGlobalVersionRequirement_003Eb__0(GlobalConfig cfg, bool success)
		{
		}
	}

	[Token(Token = "0x2000203")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A74", Offset = "0x592A74")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x10")]
		public Action<GlobalConfig.DocumentVersion, GlobalConfig.DocumentVersion> onComplete;

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x876BBC", Offset = "0x876BBC", VA = "0x876BBC")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x876BC4", Offset = "0x876BC4", VA = "0x876BC4")]
		internal void _003CCheckPrivacyPolicyAndTermsVersion_003Eb__0(GlobalConfig cfg, bool success)
		{
		}
	}

	[Token(Token = "0x4000B9B")]
	private const string TARGET = "androidgoogleplay";

	[Token(Token = "0x4000B9C")]
	private const string CONFIG_VERSION = "1.0";

	[Token(Token = "0x4000B9D")]
	private const float MIN_TIME_BETWEEN_GET_CONFIG = 60f;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string _id;

	[Token(Token = "0x4000B9F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string _key;

	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GlobalConfig _defaultConfig;

	[NonSerialized]
	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<Action<GlobalConfig, bool>> _getConfigRequests;

	[NonSerialized]
	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x28")]
	private GlobalConfig _lastConfig;

	[NonSerialized]
	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x30")]
	private bool _lastConfigFetchSuccedded;

	[NonSerialized]
	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x34")]
	private float _realtimeAtLastConfigFetch;

	[Token(Token = "0x170001EF")]
	public GlobalConfig CachedConfig
	{
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0xC82F18", Offset = "0xC82F18", VA = "0xC82F18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0xC82F20", Offset = "0xC82F20", VA = "0xC82F20", Slot = "4")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0xC83244", Offset = "0xC83244", VA = "0xC83244")]
	public void CheckGlobalVersionRequirement(Action<VersionCheckResult> result)
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0xC83314", Offset = "0xC83314", VA = "0xC83314")]
	public void CheckPrivacyPolicyAndTermsVersion(Action<GlobalConfig.DocumentVersion, GlobalConfig.DocumentVersion> onComplete)
	{
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0xC8307C", Offset = "0xC8307C", VA = "0xC8307C")]
	public void GetGlobalConfig(Action<GlobalConfig, bool> callback)
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0xC833E4", Offset = "0xC833E4", VA = "0xC833E4")]
	private void OnGetDatabaseComplete(JSONNode valueNode)
	{
	}

	[Token(Token = "0x6000C42")]
	[Address(RVA = "0xC835A8", Offset = "0xC835A8", VA = "0xC835A8")]
	private void Save()
	{
	}

	[Token(Token = "0x6000C43")]
	[Address(RVA = "0xC82F94", Offset = "0xC82F94", VA = "0xC82F94")]
	private void Load()
	{
	}

	[Token(Token = "0x6000C44")]
	[Address(RVA = "0xC83668", Offset = "0xC83668", VA = "0xC83668")]
	public GlobalConfigManager()
	{
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0xC83804", Offset = "0xC83804", VA = "0xC83804")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614254", Offset = "0x614254")]
	private void _003COnGetDatabaseComplete_003Eb__17_1(Action<GlobalConfig, bool> cb)
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0xC83864", Offset = "0xC83864", VA = "0xC83864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614264", Offset = "0x614264")]
	private void _003COnGetDatabaseComplete_003Eb__17_2(Action<GlobalConfig, bool> cb)
	{
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0xC838C4", Offset = "0xC838C4", VA = "0xC838C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614274", Offset = "0x614274")]
	private void _003COnGetDatabaseComplete_003Eb__17_0(Action<GlobalConfig, bool> cb)
	{
	}
}
