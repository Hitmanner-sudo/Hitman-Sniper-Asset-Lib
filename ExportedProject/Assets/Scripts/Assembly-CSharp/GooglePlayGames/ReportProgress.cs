using System;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000958")]
	internal delegate void ReportProgress(string id, double progress, Action<bool> callback);
}
