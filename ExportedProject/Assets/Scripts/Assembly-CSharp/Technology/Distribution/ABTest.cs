using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BB5")]
	public class ABTest
	{
		[Token(Token = "0x4003AEB")]
		public const int TIMEOUT = 5000;

		[Token(Token = "0x4003AEC")]
		public const string URL_KEY = "ABTestURL";

		[Token(Token = "0x4003AEF")]
		[FieldOffset(Offset = "0x10")]
		private static Seeder _seeder;

		[Token(Token = "0x4003AF0")]
		[FieldOffset(Offset = "0x18")]
		private static ManifestAugmentor _manifestAugmentor;

		[Token(Token = "0x4003AF1")]
		[FieldOffset(Offset = "0x20")]
		private static Download _download;

		[Token(Token = "0x4003AF2")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BD6E4", Offset = "0x5BD6E4")]
		private bool _003CIsLoadingFromCache_003Ek__BackingField;

		[Token(Token = "0x17000961")]
		public ManifestAugmentor ManifestAugmentor
		{
			[Token(Token = "0x6004A55")]
			[Address(RVA = "0xA9112C", Offset = "0xA9112C", VA = "0xA9112C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000962")]
		public static bool IsEventOnErrorDefined
		{
			[Token(Token = "0x6004A56")]
			[Address(RVA = "0xA91178", Offset = "0xA91178", VA = "0xA91178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000963")]
		public static bool IsEventOnInitializedDefined
		{
			[Token(Token = "0x6004A57")]
			[Address(RVA = "0xA911CC", Offset = "0xA911CC", VA = "0xA911CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000964")]
		public bool IsLoadingFromCache
		{
			[Token(Token = "0x6004A58")]
			[Address(RVA = "0xA91220", Offset = "0xA91220", VA = "0xA91220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A50", Offset = "0x627A50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A59")]
			[Address(RVA = "0xA91228", Offset = "0xA91228", VA = "0xA91228")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A60", Offset = "0x627A60")]
			set
			{
			}
		}

		[Token(Token = "0x1400011A")]
		public static event ABTestEventHandler OnInitialized
		{
			[Token(Token = "0x6004A51")]
			[Address(RVA = "0xA90E34", Offset = "0xA90E34", VA = "0xA90E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A10", Offset = "0x627A10")]
			add
			{
			}
			[Token(Token = "0x6004A52")]
			[Address(RVA = "0xA90EF0", Offset = "0xA90EF0", VA = "0xA90EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A20", Offset = "0x627A20")]
			remove
			{
			}
		}

		[Token(Token = "0x1400011B")]
		public static event ABTestEventHandler OnError
		{
			[Token(Token = "0x6004A53")]
			[Address(RVA = "0xA90FAC", Offset = "0xA90FAC", VA = "0xA90FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A30", Offset = "0x627A30")]
			add
			{
			}
			[Token(Token = "0x6004A54")]
			[Address(RVA = "0xA9106C", Offset = "0xA9106C", VA = "0xA9106C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x627A40", Offset = "0x627A40")]
			remove
			{
			}
		}

		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0xA91234", Offset = "0xA91234", VA = "0xA91234")]
		public ABTest(ABConfiguration abConfig, PlayerProfile playerprofile, Download download)
		{
		}

		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0xA9143C", Offset = "0xA9143C", VA = "0xA9143C")]
		private void AddEventHandlers(Download download)
		{
		}

		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0xA915DC", Offset = "0xA915DC", VA = "0xA915DC")]
		private void RemoveEventHandlers(Download download)
		{
		}

		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0xA916E4", Offset = "0xA916E4", VA = "0xA916E4")]
		private void HandleRequestSuccess(Bundle bundle)
		{
		}

		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0xA91548", Offset = "0xA91548", VA = "0xA91548")]
		private void HandleRequestError(Bundle bundle)
		{
		}

		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0xA919E8", Offset = "0xA919E8", VA = "0xA919E8")]
		public void Destroy()
		{
		}
	}
}
