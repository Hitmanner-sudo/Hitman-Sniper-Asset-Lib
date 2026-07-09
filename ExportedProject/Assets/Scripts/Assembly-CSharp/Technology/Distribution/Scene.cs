using System;
using Il2CppDummyDll;
using Technology.Core.Common;
using UnityEngine;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BFB")]
	public class Scene : NamedObject
	{
		[Token(Token = "0x4003BED")]
		[FieldOffset(Offset = "0x18")]
		public bool LoadImmediately;

		[Token(Token = "0x4003BEE")]
		[FieldOffset(Offset = "0x19")]
		public bool LoadAdditive;

		[Token(Token = "0x4003BEF")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool _loadRemotely;

		[Token(Token = "0x170009B0")]
		public bool LoadRemotely
		{
			[Token(Token = "0x6004BE0")]
			[Address(RVA = "0xBB29C8", Offset = "0xBB29C8", VA = "0xBB29C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170009B1")]
		public bool IsValid
		{
			[Token(Token = "0x6004BE1")]
			[Address(RVA = "0xBB2A50", Offset = "0xBB2A50", VA = "0xBB2A50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0xBB2A74", Offset = "0xBB2A74", VA = "0xBB2A74")]
		public Scene(string name)
		{
		}
	}
}
