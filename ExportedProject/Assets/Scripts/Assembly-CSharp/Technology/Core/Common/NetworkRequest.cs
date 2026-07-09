using System;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DEF")]
	public class NetworkRequest
	{
		[Token(Token = "0x4004221")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF494", Offset = "0x5BF494")]
		private string _003CUrl_003Ek__BackingField;

		[Token(Token = "0x4004222")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4A4", Offset = "0x5BF4A4")]
		private Action<NetworkResponse> _003CResultAction_003Ek__BackingField;

		[Token(Token = "0x4004223")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4B4", Offset = "0x5BF4B4")]
		private bool _003CIsCacheable_003Ek__BackingField;

		[Token(Token = "0x4004224")]
		[FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4C4", Offset = "0x5BF4C4")]
		private bool _003CIsAssetBundle_003Ek__BackingField;

		[Token(Token = "0x4004225")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4D4", Offset = "0x5BF4D4")]
		private int _003CVersion_003Ek__BackingField;

		[Token(Token = "0x17000B5F")]
		public string Url
		{
			[Token(Token = "0x60055BA")]
			[Address(RVA = "0xC5C52C", Offset = "0xC5C52C", VA = "0xC5C52C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AED0", Offset = "0x62AED0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055BB")]
			[Address(RVA = "0xC5C534", Offset = "0xC5C534", VA = "0xC5C534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AEE0", Offset = "0x62AEE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B60")]
		public Action<NetworkResponse> ResultAction
		{
			[Token(Token = "0x60055BC")]
			[Address(RVA = "0xC5C53C", Offset = "0xC5C53C", VA = "0xC5C53C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AEF0", Offset = "0x62AEF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055BD")]
			[Address(RVA = "0xC5C544", Offset = "0xC5C544", VA = "0xC5C544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF00", Offset = "0x62AF00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B61")]
		public bool IsCacheable
		{
			[Token(Token = "0x60055BE")]
			[Address(RVA = "0xC5C54C", Offset = "0xC5C54C", VA = "0xC5C54C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF10", Offset = "0x62AF10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055BF")]
			[Address(RVA = "0xC5C554", Offset = "0xC5C554", VA = "0xC5C554")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF20", Offset = "0x62AF20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B62")]
		public bool IsAssetBundle
		{
			[Token(Token = "0x60055C0")]
			[Address(RVA = "0xC5C560", Offset = "0xC5C560", VA = "0xC5C560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF30", Offset = "0x62AF30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055C1")]
			[Address(RVA = "0xC5C568", Offset = "0xC5C568", VA = "0xC5C568")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF40", Offset = "0x62AF40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B63")]
		public int Version
		{
			[Token(Token = "0x60055C2")]
			[Address(RVA = "0xC5C574", Offset = "0xC5C574", VA = "0xC5C574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF50", Offset = "0x62AF50")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60055C3")]
			[Address(RVA = "0xC5C57C", Offset = "0xC5C57C", VA = "0xC5C57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF60", Offset = "0x62AF60")]
			private set
			{
			}
		}

		[Token(Token = "0x60055C4")]
		[Address(RVA = "0xC5C584", Offset = "0xC5C584", VA = "0xC5C584")]
		public NetworkRequest(string url, Action<NetworkResponse> subscriberAction)
		{
		}

		[Token(Token = "0x60055C5")]
		[Address(RVA = "0xC5C5C8", Offset = "0xC5C5C8", VA = "0xC5C5C8")]
		public NetworkRequest(string url, Action<NetworkResponse> subscriberAction, bool iscacheable, bool isassetbundle, int version)
		{
		}
	}
}
