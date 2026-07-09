using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Token(Token = "0x2000078")]
	public class TDSettings : ScriptableObject
	{
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x0")]
		private static TDSettings instance;

		[Token(Token = "0x400022B")]
		public const string pluginVersion = "unity_7.10.0";

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x18")]
		public string ios_applicationID;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x20")]
		public string ios_clientKey;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x28")]
		public string android_applicationID;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x30")]
		public string android_clientKey;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x38")]
		public string admob_appid_ios;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x40")]
		public string admob_appid_android;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x48")]
		public bool isDebugMode;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x49")]
		public bool autoReloadAds;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public List<TDNetwork> networks;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public List<TestDevice> testDevices;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<TDKeyValuePair> skAdNetworkIds;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x18BAF60", Offset = "0x18BAF60", VA = "0x18BAF60")]
		public static TDSettings getInstance()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x18BB088", Offset = "0x18BB088", VA = "0x18BB088")]
		private void clean()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x18BB374", Offset = "0x18BB374", VA = "0x18BB374")]
		public TDSettings()
		{
		}
	}
}
