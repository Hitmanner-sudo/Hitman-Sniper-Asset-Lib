using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	[Token(Token = "0x200007F")]
	public class GoogleIAB
	{
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject _plugin;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x10EA158", Offset = "0x10EA158", VA = "0x10EA158")]
		static GoogleIAB()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x10EA3B4", Offset = "0x10EA3B4", VA = "0x10EA3B4")]
		public static void enableLogging(bool shouldEnable)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x10EA544", Offset = "0x10EA544", VA = "0x10EA544")]
		public static void setAutoVerifySignatures(bool shouldVerify)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x10EA684", Offset = "0x10EA684", VA = "0x10EA684")]
		public static void init(string publicKey)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x10EA7A4", Offset = "0x10EA7A4", VA = "0x10EA7A4")]
		public static void unbindService()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x10EA8F0", Offset = "0x10EA8F0", VA = "0x10EA8F0")]
		public static bool areSubscriptionsSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x10EAA54", Offset = "0x10EAA54", VA = "0x10EAA54")]
		public static void queryInventory(string[] skus)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x10EAB74", Offset = "0x10EAB74", VA = "0x10EAB74")]
		public static List<GooglePurchase> getPurchaseHistory()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x10EAD5C", Offset = "0x10EAD5C", VA = "0x10EAD5C")]
		public static void purchaseProduct(string sku)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x10EAE7C", Offset = "0x10EAE7C", VA = "0x10EAE7C")]
		public static void consumeProduct(string sku)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x10EAF9C", Offset = "0x10EAF9C", VA = "0x10EAF9C")]
		public static void acknowledgePurchase(string sku)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x10EB0BC", Offset = "0x10EB0BC", VA = "0x10EB0BC")]
		public GoogleIAB()
		{
		}
	}
}
