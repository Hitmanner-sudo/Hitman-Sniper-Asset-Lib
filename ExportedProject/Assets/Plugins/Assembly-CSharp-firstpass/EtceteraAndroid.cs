using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000009")]
public class EtceteraAndroid
{
	[Token(Token = "0x200000A")]
	public enum ScalingMode
	{
		[Token(Token = "0x4000051")]
		None = 0,
		[Token(Token = "0x4000052")]
		AspectFit = 1,
		[Token(Token = "0x4000053")]
		Fill = 2
	}

	[Token(Token = "0x200000B")]
	public class Contact
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> emails;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> phoneNumbers;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x18BF4E4", Offset = "0x18BF4E4", VA = "0x18BF4E4")]
		public Contact()
		{
		}
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaObject _plugin;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x10DFF14", Offset = "0x10DFF14", VA = "0x10DFF14")]
	static EtceteraAndroid()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x10E0170", Offset = "0x10E0170", VA = "0x10E0170")]
	public static Texture2D textureFromFileAtPath(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x10E020C", Offset = "0x10E020C", VA = "0x10E020C")]
	public static void setSystemUiVisibilityToLowProfile(bool useLowProfile)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x10E034C", Offset = "0x10E034C", VA = "0x10E034C")]
	public static void playMovie(string pathOrUrl, uint bgColor, bool showControls, ScalingMode scalingMode, bool closeOnTouch)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x10E05A8", Offset = "0x10E05A8", VA = "0x10E05A8")]
	public static void showToast(string text, bool useShortDuration)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x10E071C", Offset = "0x10E071C", VA = "0x10E071C")]
	public static void showAlert(string title, string message, string positiveButton)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10E07B8", Offset = "0x10E07B8", VA = "0x10E07B8")]
	public static void showAlert(string title, string message, string positiveButton, string negativeButton)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x10E0968", Offset = "0x10E0968", VA = "0x10E0968")]
	public static void showAlertPrompt(string title, string message, string promptHint, string promptText, string positiveButton, string negativeButton)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x10E0B7C", Offset = "0x10E0B7C", VA = "0x10E0B7C")]
	public static void showAlertPromptWithTwoFields(string title, string message, string promptHintOne, string promptTextOne, string promptHintTwo, string promptTextTwo, string positiveButton, string negativeButton)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x10E0DF4", Offset = "0x10E0DF4", VA = "0x10E0DF4")]
	public static void showProgressDialog(string title, string message)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10E0F40", Offset = "0x10E0F40", VA = "0x10E0F40")]
	public static void hideProgressDialog()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10E108C", Offset = "0x10E108C", VA = "0x10E108C")]
	public static void showWebView(string url)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x10E11AC", Offset = "0x10E11AC", VA = "0x10E11AC")]
	public static void showCustomWebView(string url, bool disableTitle, bool disableBackButton)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10E1364", Offset = "0x10E1364", VA = "0x10E1364")]
	public static void showEmailComposer(string toAddress, string subject, string text, bool isHTML)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x10E1410", Offset = "0x10E1410", VA = "0x10E1410")]
	public static void showEmailComposer(string toAddress, string subject, string text, bool isHTML, string attachmentFilePath)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10E1610", Offset = "0x10E1610", VA = "0x10E1610")]
	public static bool isSMSComposerAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10E1774", Offset = "0x10E1774", VA = "0x10E1774")]
	public static void showSMSComposer(string body)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x10E17D8", Offset = "0x10E17D8", VA = "0x10E17D8")]
	public static void showSMSComposer(string body, string[] recipients)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x10E19C8", Offset = "0x10E19C8", VA = "0x10E19C8")]
	public static void shareImageWithNativeShareIntent(string pathToImage, string chooserText)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x10E1B14", Offset = "0x10E1B14", VA = "0x10E1B14")]
	public static void shareWithNativeShareIntent(string text, string subject, string chooserText, [Optional] string pathToImage)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x10E1CC4", Offset = "0x10E1CC4", VA = "0x10E1CC4")]
	public static void promptToTakePhoto(string name)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x10E1DE4", Offset = "0x10E1DE4", VA = "0x10E1DE4")]
	public static void promptForPictureFromAlbum(string name)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x10E1F04", Offset = "0x10E1F04", VA = "0x10E1F04")]
	public static void promptToTakeVideo(string name)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x10E2024", Offset = "0x10E2024", VA = "0x10E2024")]
	public static bool saveImageToGallery(string pathToPhoto, string title)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x10E2188", Offset = "0x10E2188", VA = "0x10E2188")]
	public static void scaleImageAtPath(string pathToImage, float scale)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x10E2300", Offset = "0x10E2300", VA = "0x10E2300")]
	public static Vector2 getImageSizeAtPath(string pathToImage)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x10E24C4", Offset = "0x10E24C4", VA = "0x10E24C4")]
	public static void enableImmersiveMode(bool shouldEnable)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x10E2610", Offset = "0x10E2610", VA = "0x10E2610")]
	public static void loadContacts(int startingIndex, int totalToRetrieve)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x10E2794", Offset = "0x10E2794", VA = "0x10E2794")]
	public static void initTTS()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x10E28E0", Offset = "0x10E28E0", VA = "0x10E28E0")]
	public static void teardownTTS()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x10E2A2C", Offset = "0x10E2A2C", VA = "0x10E2A2C")]
	public static void speak(string text)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x10E2A90", Offset = "0x10E2A90", VA = "0x10E2A90")]
	public static void speak(string text, TTSQueueMode queueMode)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x10E2C00", Offset = "0x10E2C00", VA = "0x10E2C00")]
	public static void stop()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x10E2D4C", Offset = "0x10E2D4C", VA = "0x10E2D4C")]
	public static void playSilence(long durationInMs, TTSQueueMode queueMode)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x10E2EE4", Offset = "0x10E2EE4", VA = "0x10E2EE4")]
	public static void setPitch(float pitch)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x10E3030", Offset = "0x10E3030", VA = "0x10E3030")]
	public static void setSpeechRate(float rate)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x10E317C", Offset = "0x10E317C", VA = "0x10E317C")]
	public static void askForReviewSetButtonTitles(string remindMeLaterTitle, string dontAskAgainTitle, string rateItTitle)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x10E3300", Offset = "0x10E3300", VA = "0x10E3300")]
	public static void askForReview(int launchesUntilPrompt, int hoursUntilFirstPrompt, int hoursBetweenPrompts, string title, string message, bool isAmazonAppStore = false)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x10E359C", Offset = "0x10E359C", VA = "0x10E359C")]
	public static void askForReviewNow(string title, string message, bool isAmazonAppStore = false)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x10E3758", Offset = "0x10E3758", VA = "0x10E3758")]
	public static void resetAskForReview()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x10E38A4", Offset = "0x10E38A4", VA = "0x10E38A4")]
	public static void openReviewPageInPlayStore(bool isAmazonAppStore = false)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x10E3A60", Offset = "0x10E3A60", VA = "0x10E3A60")]
	public static void inlineWebViewShow(string url, int x, int y, int width, int height)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x10E3CA0", Offset = "0x10E3CA0", VA = "0x10E3CA0")]
	public static void inlineWebViewClose()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x10E3DEC", Offset = "0x10E3DEC", VA = "0x10E3DEC")]
	public static void inlineWebViewSetUrl(string url)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x10E3F0C", Offset = "0x10E3F0C", VA = "0x10E3F0C")]
	public static void inlineWebViewSetFrame(int x, int y, int width, int height)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x10E4120", Offset = "0x10E4120", VA = "0x10E4120")]
	public static int scheduleNotification(long secondsFromNow, string title, string subtitle, string tickerText, string extraData, int requestCode = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x10E43B0", Offset = "0x10E43B0", VA = "0x10E43B0")]
	public static void cancelNotification(int notificationId)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x10E44EC", Offset = "0x10E44EC", VA = "0x10E44EC")]
	public static void cancelAllNotifications()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x10E4638", Offset = "0x10E4638", VA = "0x10E4638")]
	public static void checkForNotifications()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x10E4784", Offset = "0x10E4784", VA = "0x10E4784")]
	public EtceteraAndroid()
	{
	}
}
