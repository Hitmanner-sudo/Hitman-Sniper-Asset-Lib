using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DF0")]
	public class NetworkResponse
	{
		[Token(Token = "0x4004226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4E4", Offset = "0x5BF4E4")]
		private NetworkRequest _003CRequest_003Ek__BackingField;

		[Token(Token = "0x4004227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF4F4", Offset = "0x5BF4F4")]
		private NetworkResponseState _003CState_003Ek__BackingField;

		[Token(Token = "0x4004228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF504", Offset = "0x5BF504")]
		private string _003CContent_003Ek__BackingField;

		[Token(Token = "0x4004229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF514", Offset = "0x5BF514")]
		private string _003CErrorMsg_003Ek__BackingField;

		[Token(Token = "0x400422A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF524", Offset = "0x5BF524")]
		private UnityEngine.AssetBundle _003CBundle_003Ek__BackingField;

		[Token(Token = "0x17000B64")]
		public NetworkRequest Request
		{
			[Token(Token = "0x60055C6")]
			[Address(RVA = "0xC5C628", Offset = "0xC5C628", VA = "0xC5C628")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF70", Offset = "0x62AF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055C7")]
			[Address(RVA = "0xC5C630", Offset = "0xC5C630", VA = "0xC5C630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF80", Offset = "0x62AF80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B65")]
		public NetworkResponseState State
		{
			[Token(Token = "0x60055C8")]
			[Address(RVA = "0xC5C638", Offset = "0xC5C638", VA = "0xC5C638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AF90", Offset = "0x62AF90")]
			get
			{
				return default(NetworkResponseState);
			}
			[Token(Token = "0x60055C9")]
			[Address(RVA = "0xC5C640", Offset = "0xC5C640", VA = "0xC5C640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFA0", Offset = "0x62AFA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B66")]
		public string Content
		{
			[Token(Token = "0x60055CA")]
			[Address(RVA = "0xC5C648", Offset = "0xC5C648", VA = "0xC5C648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFB0", Offset = "0x62AFB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055CB")]
			[Address(RVA = "0xC5C650", Offset = "0xC5C650", VA = "0xC5C650")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFC0", Offset = "0x62AFC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B67")]
		public string ErrorMsg
		{
			[Token(Token = "0x60055CC")]
			[Address(RVA = "0xC5C658", Offset = "0xC5C658", VA = "0xC5C658")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFD0", Offset = "0x62AFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055CD")]
			[Address(RVA = "0xC5C660", Offset = "0xC5C660", VA = "0xC5C660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFE0", Offset = "0x62AFE0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B68")]
		public UnityEngine.AssetBundle Bundle
		{
			[Token(Token = "0x60055CE")]
			[Address(RVA = "0xC5C668", Offset = "0xC5C668", VA = "0xC5C668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62AFF0", Offset = "0x62AFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60055CF")]
			[Address(RVA = "0xC5C670", Offset = "0xC5C670", VA = "0xC5C670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B000", Offset = "0x62B000")]
			set
			{
			}
		}

		[Token(Token = "0x60055D0")]
		[Address(RVA = "0xC5C678", Offset = "0xC5C678", VA = "0xC5C678")]
		public NetworkResponse(string content, NetworkRequest request, [Optional][DefaultParameterValue("")] string errormsg, [Optional] UnityEngine.AssetBundle bundle)
		{
		}
	}
}
