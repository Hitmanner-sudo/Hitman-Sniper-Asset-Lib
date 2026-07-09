using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Analytics;
using Technology.Core.ServiceOperations;

[Token(Token = "0x20007E6")]
public class DDNAAnalyticClient : AnalyticModule
{
	[Token(Token = "0x4002C25")]
	[FieldOffset(Offset = "0x28")]
	private AnalyticsPersistenceManager _analyticsPersistence;

	[Token(Token = "0x60033AC")]
	[Address(RVA = "0xBBF8F4", Offset = "0xBBF8F4", VA = "0xBBF8F4", Slot = "4")]
	protected override bool OnInitialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0xBBFBBC", Offset = "0xBBFBBC", VA = "0xBBFBBC")]
	public static void RegisterForPushNotifications()
	{
	}

	[Token(Token = "0x60033AE")]
	[Address(RVA = "0xBBFC5C", Offset = "0xBBFC5C", VA = "0xBBFC5C", Slot = "6")]
	protected override void OnSendEvent(EventKey eventKey, Dictionary<string, object> attributes)
	{
	}

	[Token(Token = "0x60033AF")]
	[Address(RVA = "0xBC0158", Offset = "0xBC0158", VA = "0xBC0158")]
	private void RequestEventRelatedEngagement(string eventID, Dictionary<string, object> attributes)
	{
	}

	[Token(Token = "0x60033B0")]
	[Address(RVA = "0xBC05F4", Offset = "0xBC05F4", VA = "0xBC05F4", Slot = "5")]
	protected override bool OnReset()
	{
		return default(bool);
	}

	[Token(Token = "0x60033B1")]
	[Address(RVA = "0xBC062C", Offset = "0xBC062C", VA = "0xBC062C", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60033B2")]
	[Address(RVA = "0xBC0630", Offset = "0xBC0630", VA = "0xBC0630", Slot = "11")]
	protected override void OnFlush(Action<OSRequestState> response, bool isAsync)
	{
	}

	[Token(Token = "0x60033B3")]
	[Address(RVA = "0xBC0720", Offset = "0xBC0720", VA = "0xBC0720", Slot = "13")]
	protected override void OnForceFlush(HashSet<string> eventNameFilter)
	{
	}

	[Token(Token = "0x60033B4")]
	[Address(RVA = "0xBC07FC", Offset = "0xBC07FC", VA = "0xBC07FC", Slot = "7")]
	protected override void OnPause()
	{
	}

	[Token(Token = "0x60033B5")]
	[Address(RVA = "0xBC0800", Offset = "0xBC0800", VA = "0xBC0800", Slot = "8")]
	protected override void OnResume()
	{
	}

	[Token(Token = "0x60033B6")]
	[Address(RVA = "0xBC0804", Offset = "0xBC0804", VA = "0xBC0804", Slot = "10")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x60033B7")]
	[Address(RVA = "0xBBFB34", Offset = "0xBBFB34", VA = "0xBBFB34")]
	private void InitializePersistence()
	{
	}

	[Token(Token = "0x60033B8")]
	[Address(RVA = "0xBC0808", Offset = "0xBC0808", VA = "0xBC0808")]
	public DDNAAnalyticClient()
	{
	}
}
