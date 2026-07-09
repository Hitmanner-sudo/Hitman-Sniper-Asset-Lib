using Il2CppDummyDll;
using Technology.Core;
using UnityEngine;

namespace Technology.Share
{
	[Token(Token = "0x2000B9C")]
	[Attribute(Name = "ResourcePathAttribute", RVA = "0x598280", Offset = "0x598280")]
	public class ShareConfiguration : ScriptableSingleton<ShareConfiguration>
	{
		[Token(Token = "0x4003AA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BD4EC", Offset = "0x5BD4EC")]
		private string _facebookClientToken;

		[Token(Token = "0x4003AA4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5BD538", Offset = "0x5BD538")]
		[SerializeField]
		private string _facebookAppId;

		[Token(Token = "0x17000941")]
		public string FacebookClientToken
		{
			[Token(Token = "0x60049C5")]
			[Address(RVA = "0x83DF14", Offset = "0x83DF14", VA = "0x83DF14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000942")]
		public string FacebookAppId
		{
			[Token(Token = "0x60049C6")]
			[Address(RVA = "0x83DF1C", Offset = "0x83DF1C", VA = "0x83DF1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x83DF24", Offset = "0x83DF24", VA = "0x83DF24")]
		public ShareConfiguration()
		{
		}
	}
}
