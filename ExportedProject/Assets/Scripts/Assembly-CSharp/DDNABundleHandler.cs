using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Shop;

[Token(Token = "0x20007FD")]
public static class DDNABundleHandler
{
	[Token(Token = "0x20007FE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965EC", Offset = "0x5965EC")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002CC0")]
		[FieldOffset(Offset = "0x10")]
		public PopupManager popupManager;

		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x18")]
		public PopupOverlayViewBase popup;

		[Token(Token = "0x6003444")]
		[Address(RVA = "0x865AB4", Offset = "0x865AB4", VA = "0x865AB4")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6003445")]
		[Address(RVA = "0x865ABC", Offset = "0x865ABC", VA = "0x865ABC")]
		internal void _003CHandleCancelled_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002CBD")]
	private const string CHANGE_BUNDLE_KEY = "changeBundle";

	[Token(Token = "0x4002CBE")]
	private const string CREDITS_KEY = "credits";

	[Token(Token = "0x4002CBF")]
	private const string PRICE_POINT_KEY = "pricePoint";

	[Token(Token = "0x600343E")]
	[Address(RVA = "0xBC16C0", Offset = "0xBC16C0", VA = "0xBC16C0")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId, bool fromUserInteraction)
	{
		return default(bool);
	}

	[Token(Token = "0x600343F")]
	[Address(RVA = "0xBC1B50", Offset = "0xBC1B50", VA = "0xBC1B50")]
	public static bool HandleCancelled(Dictionary<string, object> parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0xBC19DC", Offset = "0xBC19DC", VA = "0xBC19DC")]
	private static bool TryGetCredits(JSONNode json, out List<Credit> credits)
	{
		return default(bool);
	}

	[Token(Token = "0x6003441")]
	[Address(RVA = "0xBC1ED0", Offset = "0xBC1ED0", VA = "0xBC1ED0")]
	private static bool TryGetCredit(string creditString, out Credit credit)
	{
		return default(bool);
	}

	[Token(Token = "0x6003442")]
	[Address(RVA = "0xBC1DDC", Offset = "0xBC1DDC", VA = "0xBC1DDC")]
	private static bool TryGetArray(JSONNode json, string key, out string[] array)
	{
		return default(bool);
	}

	[Token(Token = "0x6003443")]
	[Address(RVA = "0xBC190C", Offset = "0xBC190C", VA = "0xBC190C")]
	private static void Fail(string message, long transactionId)
	{
	}
}
