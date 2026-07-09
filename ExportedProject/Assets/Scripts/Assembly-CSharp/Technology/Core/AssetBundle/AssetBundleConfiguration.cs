using Il2CppDummyDll;

namespace Technology.Core.AssetBundle
{
	[Token(Token = "0x2000CA1")]
	public static class AssetBundleConfiguration
	{
		[Token(Token = "0x2000CA2")]
		public class Schema
		{
			[Token(Token = "0x4003D68")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string ROOT_NODE;

			[Token(Token = "0x4003D69")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string NAME;

			[Token(Token = "0x4003D6A")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string VERSION;

			[Token(Token = "0x4003D6B")]
			[FieldOffset(Offset = "0x18")]
			public static readonly string BUNDLETYPE;

			[Token(Token = "0x4003D6C")]
			[FieldOffset(Offset = "0x20")]
			public static readonly string BUNDLEASSETS;

			[Token(Token = "0x6004E4D")]
			[Address(RVA = "0x923B40", Offset = "0x923B40", VA = "0x923B40")]
			public Schema()
			{
			}
		}

		[Token(Token = "0x4003D5F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string OUTPUT_PATH;

		[Token(Token = "0x4003D60")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string SCENE_OUTPUT_EXTENSION;

		[Token(Token = "0x4003D61")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string SCENE_SOURCE_EXTENSION;

		[Token(Token = "0x4003D62")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string PREFAB_SOURCE_EXTENSION;

		[Token(Token = "0x4003D63")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string SCRIPTABLE_OBJECT_EXTENSION;

		[Token(Token = "0x4003D64")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string JSON_OBJECT_EXTENSION;

		[Token(Token = "0x4003D65")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string BUILDROOT;

		[Token(Token = "0x4003D66")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string INITIAL_CONTENT_SEED_NAME;

		[Token(Token = "0x4003D67")]
		[FieldOffset(Offset = "0x40")]
		public static readonly char OUTPUT_FILENAME_SEGMENT_SEPARATOR;
	}
}
