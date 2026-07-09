using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using Technology.Core.ServiceOperations;

[Token(Token = "0x2000245")]
[Scope]
public class GenuineDateTimeManager : GameSingleton<GenuineDateTimeManager>
{
	[Token(Token = "0x2000246")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592CF0", Offset = "0x592CF0")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4000CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GenuineDateTimeManager _003C_003E4__this;

		[Token(Token = "0x4000CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool> onComplete;

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x873FF8", Offset = "0x873FF8", VA = "0x873FF8")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x874000", Offset = "0x874000", VA = "0x874000")]
		internal void _003CFetchServerDateTime_003Eb__0(IResponseContext response, IRequestContext request, OSRequestState state, Dictionary<string, object> subAction)
		{
		}
	}

	[Token(Token = "0x4000CC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3688", Offset = "0x5B3688")]
	private bool _003CTimeIsGenuine_003Ek__BackingField;

	[Token(Token = "0x4000CC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private DateTime _servertUtcAtGet;

	[Token(Token = "0x4000CC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _realtimeSinceStartupAtGet;

	[Token(Token = "0x17000232")]
	public bool TimeIsGenuine
	{
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0xD9EA5C", Offset = "0xD9EA5C", VA = "0xD9EA5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E24", Offset = "0x614E24")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0xD9EA64", Offset = "0xD9EA64", VA = "0xD9EA64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E34", Offset = "0x614E34")]
		private set
		{
		}
	}

	[Token(Token = "0x14000033")]
	public event EventHandler<EventArgs> OnTimeBecomesGenuine
	{
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0xD9EA70", Offset = "0xD9EA70", VA = "0xD9EA70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E44", Offset = "0x614E44")]
		add
		{
		}
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0xD9EB10", Offset = "0xD9EB10", VA = "0xD9EB10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E54", Offset = "0x614E54")]
		remove
		{
		}
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0xD9EBB0", Offset = "0xD9EBB0", VA = "0xD9EBB0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0xD9EC38", Offset = "0xD9EC38", VA = "0xD9EC38")]
	protected void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0xD9ED78", Offset = "0xD9ED78", VA = "0xD9ED78")]
	public void FetchServerDateTime([Optional] Action<bool> onComplete)
	{
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0xD9EF0C", Offset = "0xD9EF0C", VA = "0xD9EF0C")]
	public GenuineDateTimeManager()
	{
	}
}
