using System;
using Facebook.Unity;
using Il2CppDummyDll;
using Technology.Social;

[Token(Token = "0x2000549")]
public class ScoreTallyController : UIController
{
	[Token(Token = "0x200054A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595194", Offset = "0x595194")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4001C19")]
		[FieldOffset(Offset = "0x10")]
		public int score;

		[Token(Token = "0x4001C1A")]
		[FieldOffset(Offset = "0x18")]
		public ScoreTallyController _003C_003E4__this;

		[Token(Token = "0x600213E")]
		[Address(RVA = "0x8B84A8", Offset = "0x8B84A8", VA = "0x8B84A8")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600213F")]
		[Address(RVA = "0x8B84B0", Offset = "0x8B84B0", VA = "0x8B84B0")]
		internal void _003CPostScore_003Eb__0(IShareResult fbr)
		{
		}
	}

	[Token(Token = "0x200054B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5951A4", Offset = "0x5951A4")]
	private sealed class _003C_003Ec__DisplayClass23_1
	{
		[Token(Token = "0x4001C1B")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardRecord localPlayer;

		[Token(Token = "0x4001C1C")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002140")]
		[Address(RVA = "0x8B89A0", Offset = "0x8B89A0", VA = "0x8B89A0")]
		public _003C_003Ec__DisplayClass23_1()
		{
		}

		[Token(Token = "0x6002141")]
		[Address(RVA = "0x8B89A8", Offset = "0x8B89A8", VA = "0x8B89A8")]
		internal bool _003CPostScore_003Eb__2(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200054C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5951B4", Offset = "0x5951B4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001C1D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001C1E")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<LeaderboardRecord> _003C_003E9__23_1;

		[Token(Token = "0x6002143")]
		[Address(RVA = "0x8B8488", Offset = "0x8B8488", VA = "0x8B8488")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002144")]
		[Address(RVA = "0x8B8490", Offset = "0x8B8490", VA = "0x8B8490")]
		internal bool _003CPostScore_003Eb__23_1(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001C0E")]
	private const string FACEBOOK_SCORE_POST_FAILED = "LOC_Facebook_ScorePostFailed";

	[Token(Token = "0x4001C0F")]
	private const string FACEBOOK_ERROR_CODE_OF_NO_POST_PERMISSION = "LOC_Facebook_ErrorCodeOfNoPostPermission";

	[Token(Token = "0x4001C10")]
	private const string FACEBOOK_NO_POST_PERMISSION_ERROR_TEXT = "LOC_Facebook_NoPostPermissionErrorText";

	[Token(Token = "0x4001C11")]
	private const string FACEBOOK_GENERIC_ERROR_TEXT = "LOC_Facebook_GenericErrorText";

	[Token(Token = "0x4001C12")]
	private const string INVITE_URL = "LOC_Facebook_Post_Hyperlink";

	[Token(Token = "0x4001C13")]
	private const string INVITE_IMAGE_URL = "LOC_Facebook_Post_ImageLink";

	[Token(Token = "0x4001C14")]
	private const string INVITE_URL_TITLE = "LOC_Facebook_Post_HyperlinkText";

	[Token(Token = "0x4001C15")]
	[FieldOffset(Offset = "0x50")]
	public BlinkButtonHandler NextButton;

	[Token(Token = "0x4001C16")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler ShareScoreButton;

	[Token(Token = "0x4001C17")]
	[FieldOffset(Offset = "0x60")]
	public BlinkButtonHandler RestartButton;

	[Token(Token = "0x4001C18")]
	[FieldOffset(Offset = "0x68")]
	public BlinkButtonHandler FeedbackButton;

	[Token(Token = "0x6002129")]
	[Address(RVA = "0xB5E68C", Offset = "0xB5E68C", VA = "0xB5E68C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600212A")]
	[Address(RVA = "0xB5E95C", Offset = "0xB5E95C", VA = "0xB5E95C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600212B")]
	[Address(RVA = "0xB5EC8C", Offset = "0xB5EC8C", VA = "0xB5EC8C")]
	protected void Update()
	{
	}

	[Token(Token = "0x600212C")]
	[Address(RVA = "0xB5EC90", Offset = "0xB5EC90", VA = "0xB5EC90")]
	private void HandleAndroidHardwareButtons()
	{
	}

	[Token(Token = "0x600212D")]
	[Address(RVA = "0xB5EDC0", Offset = "0xB5EDC0", VA = "0xB5EDC0", Slot = "14")]
	protected virtual void OnRestartBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600212E")]
	[Address(RVA = "0xB5EF38", Offset = "0xB5EF38", VA = "0xB5EF38", Slot = "15")]
	protected virtual void OnNextBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x600212F")]
	[Address(RVA = "0xB5EFFC", Offset = "0xB5EFFC", VA = "0xB5EFFC")]
	private void RequestNextMission()
	{
	}

	[Token(Token = "0x6002130")]
	[Address(RVA = "0xB5F430", Offset = "0xB5F430", VA = "0xB5F430")]
	public static void OnFeedbackBlinkFinished(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6002131")]
	[Address(RVA = "0xB5F4B0", Offset = "0xB5F4B0", VA = "0xB5F4B0")]
	private void OnShareScoreBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6002132")]
	[Address(RVA = "0xB5F56C", Offset = "0xB5F56C", VA = "0xB5F56C")]
	private void HookFacebookCallbacks()
	{
	}

	[Token(Token = "0x6002133")]
	[Address(RVA = "0xB5EB8C", Offset = "0xB5EB8C", VA = "0xB5EB8C")]
	private void UnhookFacebookCallbacks(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6002134")]
	[Address(RVA = "0xB5F674", Offset = "0xB5F674", VA = "0xB5F674")]
	private void OnFacebookConnectSuccess(object sender, SocialManager.LinkEvent args)
	{
	}

	[Token(Token = "0x6002135")]
	[Address(RVA = "0xB5F6E8", Offset = "0xB5F6E8", VA = "0xB5F6E8")]
	private void PostScore()
	{
	}

	[Token(Token = "0x6002136")]
	[Address(RVA = "0xB60264", Offset = "0xB60264", VA = "0xB60264")]
	private static string[] GetMessages(string[] defaultMessages, string[] contractMessage)
	{
		return null;
	}

	[Token(Token = "0x6002137")]
	[Address(RVA = "0xB6027C", Offset = "0xB6027C", VA = "0xB6027C")]
	private void ActivateScoreButton(bool isActive)
	{
	}

	[Token(Token = "0x6002138")]
	[Address(RVA = "0xB602B8", Offset = "0xB602B8", VA = "0xB602B8")]
	protected void OnCloseWeaponBlinkFinished(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002139")]
	[Address(RVA = "0xB6032C", Offset = "0xB6032C", VA = "0xB6032C")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600213A")]
	[Address(RVA = "0xB6041C", Offset = "0xB6041C", VA = "0xB6041C")]
	private void OnAllPagesDisplayedChanged(bool value)
	{
	}

	[Token(Token = "0x600213B")]
	[Address(RVA = "0xB60724", Offset = "0xB60724", VA = "0xB60724")]
	public ScoreTallyController()
	{
	}

	[Token(Token = "0x600213C")]
	[Address(RVA = "0xB6072C", Offset = "0xB6072C", VA = "0xB6072C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619878", Offset = "0x619878")]
	private void _003COnNextBlinkFinished_003Eb__16_0(bool isReachable)
	{
	}

	[Token(Token = "0x600213D")]
	[Address(RVA = "0xB608A8", Offset = "0xB608A8", VA = "0xB608A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619888", Offset = "0x619888")]
	private void _003COnShareScoreBlinkFinished_003Eb__19_0(bool isAvailable)
	{
	}
}
