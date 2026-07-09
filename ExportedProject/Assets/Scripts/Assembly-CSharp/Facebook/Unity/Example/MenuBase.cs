using Il2CppDummyDll;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x20012DA")]
	internal abstract class MenuBase : ConsoleBase
	{
		[Token(Token = "0x4005A66")]
		[FieldOffset(Offset = "0x0")]
		private static ShareDialogMode shareDialogMode;

		[Token(Token = "0x6006E1A")]
		protected abstract void GetGui();

		[Token(Token = "0x6006E1B")]
		[Address(RVA = "0x9BA3D4", Offset = "0x9BA3D4", VA = "0x9BA3D4", Slot = "6")]
		protected virtual bool ShowDialogModeSelector()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E1C")]
		[Address(RVA = "0x9BA3DC", Offset = "0x9BA3DC", VA = "0x9BA3DC", Slot = "7")]
		protected virtual bool ShowBackButton()
		{
			return default(bool);
		}

		[Token(Token = "0x6006E1D")]
		[Address(RVA = "0x9BA3E4", Offset = "0x9BA3E4", VA = "0x9BA3E4")]
		protected void HandleResult(IResult result)
		{
		}

		[Token(Token = "0x6006E1E")]
		[Address(RVA = "0x9BA800", Offset = "0x9BA800", VA = "0x9BA800")]
		protected void HandleLimitedLoginResult(IResult result)
		{
		}

		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x9BAF18", Offset = "0x9BAF18", VA = "0x9BAF18")]
		protected void OnGUI()
		{
		}

		[Token(Token = "0x6006E20")]
		[Address(RVA = "0x9BB52C", Offset = "0x9BB52C", VA = "0x9BB52C")]
		private void AddStatus()
		{
		}

		[Token(Token = "0x6006E21")]
		[Address(RVA = "0x9BB66C", Offset = "0x9BB66C", VA = "0x9BB66C")]
		private void AddBackButton()
		{
		}

		[Token(Token = "0x6006E22")]
		[Address(RVA = "0x9BB7C4", Offset = "0x9BB7C4", VA = "0x9BB7C4")]
		private void AddLogButton()
		{
		}

		[Token(Token = "0x6006E23")]
		[Address(RVA = "0x9BB884", Offset = "0x9BB884", VA = "0x9BB884")]
		private void AddDialogModeButtons()
		{
		}

		[Token(Token = "0x6006E24")]
		[Address(RVA = "0x9BBC3C", Offset = "0x9BBC3C", VA = "0x9BBC3C")]
		private void AddDialogModeButton(ShareDialogMode mode)
		{
		}

		[Token(Token = "0x6006E25")]
		[Address(RVA = "0x9AD6F4", Offset = "0x9AD6F4", VA = "0x9AD6F4")]
		protected MenuBase()
		{
		}
	}
}
