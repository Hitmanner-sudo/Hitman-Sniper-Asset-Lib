using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BDF")]
	public abstract class ManifestAugmentor
	{
		[Token(Token = "0x4003B81")]
		[FieldOffset(Offset = "0x10")]
		protected ManifestConfiguration _manifestConfiguration;

		[Token(Token = "0x6004B43")]
		public abstract void SetBundleParameters(Bundle bundle);

		[Token(Token = "0x6004B44")]
		[Address(RVA = "0x9AED08", Offset = "0x9AED08", VA = "0x9AED08")]
		protected ManifestAugmentor()
		{
		}

		[Token(Token = "0x6004B45")]
		[Address(RVA = "0x9AED10", Offset = "0x9AED10", VA = "0x9AED10")]
		public void Initialize(ManifestConfiguration manifest)
		{
		}
	}
}
