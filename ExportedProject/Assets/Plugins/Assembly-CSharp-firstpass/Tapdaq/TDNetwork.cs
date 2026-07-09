using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000073")]
	public class TDNetwork
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public readonly string name;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public TDSDKTargetVersion sdkTargetVersion;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public readonly string cocoapodsAdapterDependency;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public readonly string mavenAdapterDependency;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public readonly string mavenNetworkRepository;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool androidEnabled;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		public bool iOSEnabled;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly List<TDNetwork> AllNetworks;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x18BA534", Offset = "0x18BA534", VA = "0x18BA534")]
		public TDNetwork(string network_name, TDSDKTargetVersion targetSdkVersion, string cocoapods_dependency, string maven_dependency, [Optional] string maven_network_repository)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x18BA588", Offset = "0x18BA588", VA = "0x18BA588")]
		public static bool IsAndroidSupported(TDNetwork network)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x18BA5A8", Offset = "0x18BA5A8", VA = "0x18BA5A8")]
		public static bool IsIOSSupported(TDNetwork network)
		{
			return default(bool);
		}
	}
}
