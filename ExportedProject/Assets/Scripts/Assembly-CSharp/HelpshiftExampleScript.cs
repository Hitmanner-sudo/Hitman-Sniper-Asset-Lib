using System.Collections.Generic;
using Helpshift;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000E")]
public class HelpshiftExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x18")]
	private HelpshiftSdk _support;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xA0EDB0", Offset = "0xA0EDB0", VA = "0xA0EDB0")]
	public void updateMetaData(string nothing)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xA0EFF4", Offset = "0xA0EFF4", VA = "0xA0EFF4")]
	public void helpshiftSessionBegan(string message)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xA0F068", Offset = "0xA0F068", VA = "0xA0F068")]
	public void helpshiftSessionEnded(string message)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xA0F0DC", Offset = "0xA0F0DC", VA = "0xA0F0DC")]
	public void alertToRateAppAction(string result)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xA0F16C", Offset = "0xA0F16C", VA = "0xA0F16C")]
	public void didReceiveNotificationCount(string count)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xA0F1FC", Offset = "0xA0F1FC", VA = "0xA0F1FC")]
	public void didReceiveInAppNotificationCount(string count)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xA0F28C", Offset = "0xA0F28C", VA = "0xA0F28C")]
	public void conversationEnded()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xA0F300", Offset = "0xA0F300", VA = "0xA0F300")]
	public void didReceiveUnreadMessagesCount(string count)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xA0F390", Offset = "0xA0F390", VA = "0xA0F390")]
	public void didCheckIfConversationActive(string active)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xA0F420", Offset = "0xA0F420", VA = "0xA0F420")]
	public void displayAttachmentFile(string path)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xA0F4FC", Offset = "0xA0F4FC", VA = "0xA0F4FC")]
	public void newConversationStarted(string message)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xA0F570", Offset = "0xA0F570", VA = "0xA0F570")]
	public void userRepliedToConversation(string newMessage)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xA0F5E4", Offset = "0xA0F5E4", VA = "0xA0F5E4")]
	public void userCompletedCustomerSatisfactionSurvey(string json)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xA0F6E8", Offset = "0xA0F6E8", VA = "0xA0F6E8")]
	public void authenticationFailed(string serializedJSONUserData)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xA0FCC4", Offset = "0xA0FCC4", VA = "0xA0FCC4")]
	public void userClickOnAction(string serializedJSONUserActionData)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xA0FEF4", Offset = "0xA0FEF4", VA = "0xA0FEF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xA10558", Offset = "0xA10558", VA = "0xA10558")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xA10670", Offset = "0xA10670", VA = "0xA10670")]
	public void onShowFAQsClick()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xA10770", Offset = "0xA10770", VA = "0xA10770")]
	public void onCustomContactUsClick()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xA10840", Offset = "0xA10840", VA = "0xA10840")]
	protected Dictionary<string, object>[] getDynamicFlows()
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xA10DE8", Offset = "0xA10DE8", VA = "0xA10DE8")]
	public void onShowDynamicClick()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xA10EC8", Offset = "0xA10EC8", VA = "0xA10EC8")]
	public void onShowConversationClick()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xA11200", Offset = "0xA11200", VA = "0xA11200")]
	public void onShowFAQSectionClick()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xA1147C", Offset = "0xA1147C", VA = "0xA1147C")]
	public void onShowFAQClick()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xA116F8", Offset = "0xA116F8", VA = "0xA116F8")]
	public void onShowReviewReminderClick()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xA10F58", Offset = "0xA10F58", VA = "0xA10F58")]
	private Dictionary<string, object> getApiConfig()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xA100B4", Offset = "0xA100B4", VA = "0xA100B4")]
	private Dictionary<string, object> getInstallConfig()
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xA117C0", Offset = "0xA117C0", VA = "0xA117C0")]
	public HelpshiftExampleScript()
	{
	}
}
