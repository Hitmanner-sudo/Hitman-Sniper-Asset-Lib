using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000516")]
public class DailyRewardButtonController : UIController
{
	[Token(Token = "0x2000517")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x594F8C", Offset = "0x594F8C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x10")]
		public PlayerProfileData playerProfile;

		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0x18")]
		public DailyRewardButtonController _003C_003E4__this;

		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x20")]
		public PopupClaimLootBoxView popup;

		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x869D10", Offset = "0x869D10", VA = "0x869D10")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x869D18", Offset = "0x869D18", VA = "0x869D18")]
		internal void _003COnCollectButtonClicked_003Eb__0(bool success)
		{
		}

		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x869E84", Offset = "0x869E84", VA = "0x869E84")]
		internal void _003COnCollectButtonClicked_003Eb__1(string msg)
		{
		}
	}

	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _collectButton;

	[Token(Token = "0x4001AE5")]
	[FieldOffset(Offset = "0x58")]
	private DailyRewardsData _data;

	[Token(Token = "0x6001F52")]
	[Address(RVA = "0xADC5D0", Offset = "0xADC5D0", VA = "0xADC5D0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001F53")]
	[Address(RVA = "0xADCA1C", Offset = "0xADCA1C", VA = "0xADCA1C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F54")]
	[Address(RVA = "0xADCAC8", Offset = "0xADCAC8", VA = "0xADCAC8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F55")]
	[Address(RVA = "0xADCB74", Offset = "0xADCB74", VA = "0xADCB74")]
	private void OnCollectButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001F56")]
	[Address(RVA = "0xADCDF4", Offset = "0xADCDF4", VA = "0xADCDF4")]
	private PopupClaimLootBoxView CollectLootBox(bool paused)
	{
		return null;
	}

	[Token(Token = "0x6001F57")]
	[Address(RVA = "0xADC6D8", Offset = "0xADC6D8", VA = "0xADC6D8")]
	private void RegisterDailyRewardsNotifications()
	{
	}

	[Token(Token = "0x6001F58")]
	[Address(RVA = "0xADD1DC", Offset = "0xADD1DC", VA = "0xADD1DC")]
	public DailyRewardButtonController()
	{
	}

	[Token(Token = "0x6001F59")]
	[Address(RVA = "0xADD1E4", Offset = "0xADD1E4", VA = "0xADD1E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x619068", Offset = "0x619068")]
	private void _003CCollectLootBox_003Eb__6_0()
	{
	}
}
