using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Prime31;

[Token(Token = "0x200000C")]
public class EtceteraAndroidManager : AbstractManager
{
	[Token(Token = "0x14000003")]
	public static event Action<string> alertButtonClickedEvent
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x10E478C", Offset = "0x10E478C", VA = "0x10E478C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9990", Offset = "0x6F9990")]
		add
		{
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x10E4880", Offset = "0x10E4880", VA = "0x10E4880")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99A0", Offset = "0x6F99A0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public static event Action alertCancelledEvent
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x10E4974", Offset = "0x10E4974", VA = "0x10E4974")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99B0", Offset = "0x6F99B0")]
		add
		{
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x10E4A6C", Offset = "0x10E4A6C", VA = "0x10E4A6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99C0", Offset = "0x6F99C0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event Action<string> promptFinishedWithTextEvent
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x10E4B64", Offset = "0x10E4B64", VA = "0x10E4B64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99D0", Offset = "0x6F99D0")]
		add
		{
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x10E4C5C", Offset = "0x10E4C5C", VA = "0x10E4C5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99E0", Offset = "0x6F99E0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event Action promptCancelledEvent
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x10E4D54", Offset = "0x10E4D54", VA = "0x10E4D54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F99F0", Offset = "0x6F99F0")]
		add
		{
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x10E4E4C", Offset = "0x10E4E4C", VA = "0x10E4E4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A00", Offset = "0x6F9A00")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public static event Action<string, string> twoFieldPromptFinishedWithTextEvent
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x10E4F44", Offset = "0x10E4F44", VA = "0x10E4F44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A10", Offset = "0x6F9A10")]
		add
		{
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x10E503C", Offset = "0x10E503C", VA = "0x10E503C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A20", Offset = "0x6F9A20")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event Action twoFieldPromptCancelledEvent
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x10E5134", Offset = "0x10E5134", VA = "0x10E5134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A30", Offset = "0x6F9A30")]
		add
		{
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x10E522C", Offset = "0x10E522C", VA = "0x10E522C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A40", Offset = "0x6F9A40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event Action webViewCancelledEvent
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x10E5324", Offset = "0x10E5324", VA = "0x10E5324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A50", Offset = "0x6F9A50")]
		add
		{
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x10E541C", Offset = "0x10E541C", VA = "0x10E541C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A60", Offset = "0x6F9A60")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event Action albumChooserCancelledEvent
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x10E5514", Offset = "0x10E5514", VA = "0x10E5514")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A70", Offset = "0x6F9A70")]
		add
		{
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x10E560C", Offset = "0x10E560C", VA = "0x10E560C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A80", Offset = "0x6F9A80")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public static event Action<string> albumChooserSucceededEvent
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x10E5704", Offset = "0x10E5704", VA = "0x10E5704")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9A90", Offset = "0x6F9A90")]
		add
		{
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x10E57FC", Offset = "0x10E57FC", VA = "0x10E57FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AA0", Offset = "0x6F9AA0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public static event Action photoChooserCancelledEvent
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x10E58F4", Offset = "0x10E58F4", VA = "0x10E58F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AB0", Offset = "0x6F9AB0")]
		add
		{
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x10E59EC", Offset = "0x10E59EC", VA = "0x10E59EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AC0", Offset = "0x6F9AC0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public static event Action<string> photoChooserSucceededEvent
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x10E5AE4", Offset = "0x10E5AE4", VA = "0x10E5AE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AD0", Offset = "0x6F9AD0")]
		add
		{
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x10E5BDC", Offset = "0x10E5BDC", VA = "0x10E5BDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AE0", Offset = "0x6F9AE0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public static event Action<string> videoRecordingSucceededEvent
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x10E5CD4", Offset = "0x10E5CD4", VA = "0x10E5CD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9AF0", Offset = "0x6F9AF0")]
		add
		{
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x10E5DCC", Offset = "0x10E5DCC", VA = "0x10E5DCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B00", Offset = "0x6F9B00")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public static event Action videoRecordingCancelledEvent
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x10E5EC4", Offset = "0x10E5EC4", VA = "0x10E5EC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B10", Offset = "0x6F9B10")]
		add
		{
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x10E5FBC", Offset = "0x10E5FBC", VA = "0x10E5FBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B20", Offset = "0x6F9B20")]
		remove
		{
		}
	}

	[Token(Token = "0x14000010")]
	public static event Action ttsInitializedEvent
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x10E60B4", Offset = "0x10E60B4", VA = "0x10E60B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B30", Offset = "0x6F9B30")]
		add
		{
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x10E61AC", Offset = "0x10E61AC", VA = "0x10E61AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B40", Offset = "0x6F9B40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public static event Action ttsFailedToInitializeEvent
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x10E62A4", Offset = "0x10E62A4", VA = "0x10E62A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B50", Offset = "0x6F9B50")]
		add
		{
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x10E639C", Offset = "0x10E639C", VA = "0x10E639C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B60", Offset = "0x6F9B60")]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	public static event Action askForReviewWillOpenMarketEvent
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x10E6494", Offset = "0x10E6494", VA = "0x10E6494")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B70", Offset = "0x6F9B70")]
		add
		{
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x10E658C", Offset = "0x10E658C", VA = "0x10E658C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B80", Offset = "0x6F9B80")]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	public static event Action askForReviewRemindMeLaterEvent
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x10E6684", Offset = "0x10E6684", VA = "0x10E6684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9B90", Offset = "0x6F9B90")]
		add
		{
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x10E677C", Offset = "0x10E677C", VA = "0x10E677C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BA0", Offset = "0x6F9BA0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000014")]
	public static event Action askForReviewDontAskAgainEvent
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x10E6874", Offset = "0x10E6874", VA = "0x10E6874")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BB0", Offset = "0x6F9BB0")]
		add
		{
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x10E696C", Offset = "0x10E696C", VA = "0x10E696C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BC0", Offset = "0x6F9BC0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	public static event Action<string> inlineWebViewJSCallbackEvent
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x10E6A64", Offset = "0x10E6A64", VA = "0x10E6A64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BD0", Offset = "0x6F9BD0")]
		add
		{
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x10E6B5C", Offset = "0x10E6B5C", VA = "0x10E6B5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BE0", Offset = "0x6F9BE0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public static event Action<string> notificationReceivedEvent
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x10E6C54", Offset = "0x10E6C54", VA = "0x10E6C54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9BF0", Offset = "0x6F9BF0")]
		add
		{
		}
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x10E6D4C", Offset = "0x10E6D4C", VA = "0x10E6D4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C00", Offset = "0x6F9C00")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public static event Action<List<EtceteraAndroid.Contact>> contactsLoadedEvent
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x10E6E44", Offset = "0x10E6E44", VA = "0x10E6E44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C10", Offset = "0x6F9C10")]
		add
		{
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x10E6F3C", Offset = "0x10E6F3C", VA = "0x10E6F3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9C20", Offset = "0x6F9C20")]
		remove
		{
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x10E7034", Offset = "0x10E7034", VA = "0x10E7034")]
	static EtceteraAndroidManager()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x10E70B4", Offset = "0x10E70B4", VA = "0x10E70B4")]
	public void alertButtonClicked(string positiveButton)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x10E7174", Offset = "0x10E7174", VA = "0x10E7174")]
	public void alertCancelled(string empty)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x10E7218", Offset = "0x10E7218", VA = "0x10E7218")]
	public void promptFinishedWithText(string text)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x10E742C", Offset = "0x10E742C", VA = "0x10E742C")]
	public void promptCancelled(string empty)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x10E74D0", Offset = "0x10E74D0", VA = "0x10E74D0")]
	public void twoFieldPromptCancelled(string empty)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x10E7574", Offset = "0x10E7574", VA = "0x10E7574")]
	public void webViewCancelled(string empty)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x10E7618", Offset = "0x10E7618", VA = "0x10E7618")]
	public void albumChooserCancelled(string empty)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x10E76BC", Offset = "0x10E76BC", VA = "0x10E76BC")]
	public void albumChooserSucceeded(string path)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x10E77EC", Offset = "0x10E77EC", VA = "0x10E77EC")]
	public void photoChooserCancelled(string empty)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x10E7890", Offset = "0x10E7890", VA = "0x10E7890")]
	public void photoChooserSucceeded(string path)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x10E79C0", Offset = "0x10E79C0", VA = "0x10E79C0")]
	public void videoRecordingSucceeded(string path)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x10E7A80", Offset = "0x10E7A80", VA = "0x10E7A80")]
	public void videoRecordingCancelled(string empty)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x10E7B24", Offset = "0x10E7B24", VA = "0x10E7B24")]
	public void ttsInitialized(string result)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x10E7C48", Offset = "0x10E7C48", VA = "0x10E7C48")]
	public void ttsUtteranceCompleted(string utteranceId)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x10E7C4C", Offset = "0x10E7C4C", VA = "0x10E7C4C")]
	public void askForReviewWillOpenMarket(string empty)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x10E7CF0", Offset = "0x10E7CF0", VA = "0x10E7CF0")]
	public void askForReviewRemindMeLater(string empty)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x10E7D94", Offset = "0x10E7D94", VA = "0x10E7D94")]
	public void askForReviewDontAskAgain(string empty)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x10E7E38", Offset = "0x10E7E38", VA = "0x10E7E38")]
	public void inlineWebViewJSCallback(string message)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x10E7EBC", Offset = "0x10E7EBC", VA = "0x10E7EBC")]
	public void notificationReceived(string extraData)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x10E7F40", Offset = "0x10E7F40", VA = "0x10E7F40")]
	private void contactsLoaded(string json)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x10E8058", Offset = "0x10E8058", VA = "0x10E8058")]
	public EtceteraAndroidManager()
	{
	}
}
