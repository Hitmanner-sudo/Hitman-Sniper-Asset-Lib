using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Share
{
	[Token(Token = "0x2000B94")]
	public class AndroidShare : IShare
	{
		[Serializable]
		[Token(Token = "0x2000B95")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598270", Offset = "0x598270")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003A93")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003A94")]
			[FieldOffset(Offset = "0x8")]
			public static Func<string, bool> _003C_003E9__10_0;

			[Token(Token = "0x60049A0")]
			[Address(RVA = "0x91FC0C", Offset = "0x91FC0C", VA = "0x91FC0C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60049A1")]
			[Address(RVA = "0x91FC14", Offset = "0x91FC14", VA = "0x91FC14")]
			internal bool _003CSetImage_003Eb__10_0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003A8C")]
		private const string IMAGE_NAME = "ShareImage";

		[Token(Token = "0x4003A8D")]
		private const string SET_TEXT_METHOD = "SetText";

		[Token(Token = "0x4003A8E")]
		private const string SET_URL_METHOD = "SetUrl";

		[Token(Token = "0x4003A8F")]
		private const string SET_IMAGE_METHOD = "SetImage";

		[Token(Token = "0x4003A90")]
		private const string SET_TYPE_METHOD = "SetIntentType";

		[Token(Token = "0x4003A91")]
		private const string SHARE_METHOD = "Share";

		[Token(Token = "0x4003A92")]
		[FieldOffset(Offset = "0x10")]
		private readonly AndroidJavaObject _shareInstance;

		[Token(Token = "0x6004997")]
		[Address(RVA = "0xD7772C", Offset = "0xD7772C", VA = "0xD7772C")]
		public AndroidShare()
		{
		}

		[Token(Token = "0x6004998")]
		[Address(RVA = "0xD77850", Offset = "0xD77850", VA = "0xD77850", Slot = "6")]
		public void SetText(string text)
		{
		}

		[Token(Token = "0x6004999")]
		[Address(RVA = "0xD77920", Offset = "0xD77920", VA = "0xD77920", Slot = "7")]
		public void SetUrl(string url)
		{
		}

		[Token(Token = "0x600499A")]
		[Address(RVA = "0xD779F0", Offset = "0xD779F0", VA = "0xD779F0", Slot = "8")]
		public void SetImage(byte[] image, ShareImageFormat format)
		{
		}

		[Token(Token = "0x600499B")]
		[Address(RVA = "0xD77D4C", Offset = "0xD77D4C", VA = "0xD77D4C", Slot = "9")]
		public void SetMimeType(string mimeType)
		{
		}

		[Token(Token = "0x600499C")]
		[Address(RVA = "0xD77E1C", Offset = "0xD77E1C", VA = "0xD77E1C", Slot = "4")]
		public void SetTitle(string title)
		{
		}

		[Token(Token = "0x600499D")]
		[Address(RVA = "0xD77E20", Offset = "0xD77E20", VA = "0xD77E20", Slot = "5")]
		public void SetDescription(string description)
		{
		}

		[Token(Token = "0x600499E")]
		[Address(RVA = "0xD77E24", Offset = "0xD77E24", VA = "0xD77E24", Slot = "10")]
		public void Share()
		{
		}
	}
}
