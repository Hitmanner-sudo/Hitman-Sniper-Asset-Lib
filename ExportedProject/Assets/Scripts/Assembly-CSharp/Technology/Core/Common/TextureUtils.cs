using Il2CppDummyDll;
using Technology.Core.ServiceOperations;
using UnityEngine;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DFE")]
	public static class TextureUtils
	{
		[Token(Token = "0x2000DFF")]
		public class Texture2DAsync
		{
			[Token(Token = "0x400424E")]
			[FieldOffset(Offset = "0x10")]
			public byte[] Data;

			[Token(Token = "0x400424F")]
			[FieldOffset(Offset = "0x18")]
			public string Url;

			[Token(Token = "0x4004250")]
			[FieldOffset(Offset = "0x20")]
			public int Width;

			[Token(Token = "0x4004251")]
			[FieldOffset(Offset = "0x24")]
			public int Height;

			[Token(Token = "0x4004252")]
			[FieldOffset(Offset = "0x28")]
			public DownloadStatus Status;

			[Token(Token = "0x4004253")]
			[FieldOffset(Offset = "0x30")]
			private Texture2D _cachedTexture;

			[Token(Token = "0x17000B70")]
			public Texture2D Texture
			{
				[Token(Token = "0x600560A")]
				[Address(RVA = "0xA56BA4", Offset = "0xA56BA4", VA = "0xA56BA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600560B")]
			[Address(RVA = "0xA56C8C", Offset = "0xA56C8C", VA = "0xA56C8C")]
			private void Reset()
			{
			}

			[Token(Token = "0x600560C")]
			[Address(RVA = "0xA56CEC", Offset = "0xA56CEC", VA = "0xA56CEC")]
			internal void DownloadTextureAsync(string url, int width, int height, int timeoutInSeconds = 10)
			{
			}

			[Token(Token = "0x600560D")]
			[Address(RVA = "0xA572F0", Offset = "0xA572F0", VA = "0xA572F0")]
			private void OnDownloadTextureDataCompleted(object sender, DownloadDataCompletedEventArgs e)
			{
			}

			[Token(Token = "0x600560E")]
			[Address(RVA = "0xA573F4", Offset = "0xA573F4", VA = "0xA573F4")]
			private void OnUpdate()
			{
			}

			[Token(Token = "0x600560F")]
			[Address(RVA = "0xA575E0", Offset = "0xA575E0", VA = "0xA575E0")]
			public Texture2DAsync()
			{
			}
		}

		[Token(Token = "0x2000E00")]
		public delegate void TextureDownloadHandler(Texture2D texture);

		[Token(Token = "0x400424D")]
		[FieldOffset(Offset = "0x8")]
		private static Texture2DAsync _cachedTexture2DAsync;

		[Token(Token = "0x17000B6F")]
		public static Texture2DAsync Texture2DAsynch
		{
			[Token(Token = "0x6005606")]
			[Address(RVA = "0xAC485C", Offset = "0xAC485C", VA = "0xAC485C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400016F")]
		public static event TextureDownloadHandler OnTextureDownloadCompleted
		{
			[Token(Token = "0x6005604")]
			[Address(RVA = "0xAC4674", Offset = "0xAC4674", VA = "0xAC4674")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B160", Offset = "0x62B160")]
			add
			{
			}
			[Token(Token = "0x6005605")]
			[Address(RVA = "0xAC4768", Offset = "0xAC4768", VA = "0xAC4768")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B170", Offset = "0x62B170")]
			remove
			{
			}
		}

		[Token(Token = "0x6005607")]
		[Address(RVA = "0xAC48C0", Offset = "0xAC48C0", VA = "0xAC48C0")]
		public static Texture2D DownloadTexture(string url, int width, int height, int timeoutInSeconds = 10)
		{
			return null;
		}

		[Token(Token = "0x6005608")]
		[Address(RVA = "0xAC49B4", Offset = "0xAC49B4", VA = "0xAC49B4")]
		public static void DownloadTextureAsync(string url, int width, int height, int timeoutInSeconds = 10)
		{
		}
	}
}
