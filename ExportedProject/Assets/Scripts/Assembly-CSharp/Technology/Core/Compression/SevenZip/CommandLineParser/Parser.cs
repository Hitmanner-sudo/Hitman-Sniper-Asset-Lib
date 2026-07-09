using System.Collections;
using Il2CppDummyDll;

namespace Technology.Core.Compression.SevenZip.CommandLineParser
{
	[Token(Token = "0x2000D79")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x5988AC", Offset = "0x5988AC")]
	public class Parser
	{
		[Token(Token = "0x400407E")]
		[FieldOffset(Offset = "0x10")]
		public ArrayList NonSwitchStrings;

		[Token(Token = "0x400407F")]
		[FieldOffset(Offset = "0x18")]
		private SwitchResult[] _switches;

		[Token(Token = "0x4004080")]
		private const char kSwitchID1 = '-';

		[Token(Token = "0x4004081")]
		private const char kSwitchID2 = '/';

		[Token(Token = "0x4004082")]
		private const char kSwitchMinus = '-';

		[Token(Token = "0x4004083")]
		private const string kStopSwitchParsing = "--";

		[Token(Token = "0x17000AE2")]
		public SwitchResult Item
		{
			[Token(Token = "0x6005349")]
			[Address(RVA = "0x8F53EC", Offset = "0x8F53EC", VA = "0x8F53EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005346")]
		[Address(RVA = "0x8F4D68", Offset = "0x8F4D68", VA = "0x8F4D68")]
		public Parser(int numSwitches)
		{
		}

		[Token(Token = "0x6005347")]
		[Address(RVA = "0x8F4EB8", Offset = "0x8F4EB8", VA = "0x8F4EB8")]
		private bool ParseString(string srcString, SwitchForm[] switchForms)
		{
			return default(bool);
		}

		[Token(Token = "0x6005348")]
		[Address(RVA = "0x8F52C0", Offset = "0x8F52C0", VA = "0x8F52C0")]
		public void ParseStrings(SwitchForm[] switchForms, string[] commandStrings)
		{
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x8F5428", Offset = "0x8F5428", VA = "0x8F5428")]
		public static int ParseCommand(CommandForm[] commandForms, string commandString, out string postString)
		{
			return default(int);
		}

		[Token(Token = "0x600534B")]
		[Address(RVA = "0x8F5540", Offset = "0x8F5540", VA = "0x8F5540")]
		private static bool ParseSubCharsCommand(int numForms, CommandSubCharsSet[] forms, string commandString, ArrayList indices)
		{
			return default(bool);
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x8F52AC", Offset = "0x8F52AC", VA = "0x8F52AC")]
		private static bool IsItSwitchChar(char c)
		{
			return default(bool);
		}
	}
}
