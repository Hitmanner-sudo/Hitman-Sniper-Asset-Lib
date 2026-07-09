using Il2CppDummyDll;

namespace Technology.Share
{
	[Token(Token = "0x2000B9B")]
	public abstract class ShareAction
	{
		[Token(Token = "0x60049C1")]
		protected abstract void SetShareData(IShare share);

		[Token(Token = "0x60049C2")]
		[Address(RVA = "0x83DE0C", Offset = "0x83DE0C", VA = "0x83DE0C")]
		public void Share()
		{
		}

		[Token(Token = "0x60049C3")]
		[Address(RVA = "0x83DE14", Offset = "0x83DE14", VA = "0x83DE14")]
		protected void LaunchShare(ShareAction share)
		{
		}

		[Token(Token = "0x60049C4")]
		[Address(RVA = "0x83DF0C", Offset = "0x83DF0C", VA = "0x83DF0C")]
		protected ShareAction()
		{
		}
	}
}
