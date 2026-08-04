// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class TestDateUtil {
private const int MINS = (60 * 1000);

private static readonly int HRS = (60 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS);

private const int BAD = -666;

internal virtual void testExtract() {
global::System.TimeZoneInfo timezone = global::System.TimeZoneInfo.Local;
global::DripSharp.PdfCarton.Tests.Support.SetDefaultTimeZone(global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "UTC")));
this.assertCalendarEquals(global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2005, 4, 12), global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:05/12/2005")));
this.assertCalendarEquals(global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2005, 4, 12, 15, 57, 16), global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "5/12/2005 15:57:16")));
global::DripSharp.PdfCarton.Tests.Support.SetDefaultTimeZone(timezone);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar((string)default!), null);
}

private void assertCalendarEquals(global::System.DateTimeOffset? expect, global::System.DateTimeOffset? was) {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CalendarGetTimeInMillis(expect), global::DripSharp.Runtime.JavaCompat.CalendarGetTimeInMillis(was), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.TimeZoneRawOffset(global::DripSharp.Runtime.JavaCompat.CalendarGetTimeZone(expect)), global::DripSharp.Runtime.JavaCompat.TimeZoneRawOffset(global::DripSharp.Runtime.JavaCompat.CalendarGetTimeZone(was)), null);
}

internal virtual void testDateConversion() {
global::System.DateTimeOffset? c = global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:20050526205258+01'00'"));
global::DripSharp.Testing.JavaAssertions.Equal(2005, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal((5 - 1), global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 2), null);
global::DripSharp.Testing.JavaAssertions.Equal(26, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 5), null);
global::DripSharp.Testing.JavaAssertions.Equal(20, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 11), null);
global::DripSharp.Testing.JavaAssertions.Equal(52, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 12), null);
global::DripSharp.Testing.JavaAssertions.Equal(58, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 13), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CalendarGet(c, 14), null);
}

private static void checkParse(int yr, int mon, int day, int hr, int min, int sec, int offsetHours, int offsetMinutes, string orig) {
string pdfDate = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::System.Globalization.CultureInfo.GetCultureInfo("en-US"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:%04d%02d%02d%02d%02d%02d%+03d'%02d'"), yr, mon, day, hr, min, sec, offsetHours, offsetMinutes);
string iso8601Date = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::System.Globalization.CultureInfo.GetCultureInfo("en-US"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("%04d-%02d-%02d", "T%02d:%02d:%02d%+03d:%02d")), yr, mon, day, hr, min, sec, offsetHours, offsetMinutes);
global::System.DateTimeOffset? cal = global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", orig));
if ((cal != default!)) {
global::DripSharp.Testing.JavaAssertions.Equal(iso8601Date, global::DripSharp.PdfCarton.Util.DateConverter.ToISO8601(cal), null);
global::DripSharp.Testing.JavaAssertions.Equal(pdfDate, global::DripSharp.PdfCarton.Util.DateConverter.ToString(cal), null);
}
cal = global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", orig));
if ((yr == global::DripSharp.PdfCarton.Util.TestDateUtil.BAD)) {
global::DripSharp.Testing.JavaAssertions.Equal((object)default!, cal, null);
} else {
global::DripSharp.Testing.JavaAssertions.Equal(pdfDate, global::DripSharp.PdfCarton.Util.DateConverter.ToString(cal), null);
}
}

internal virtual void testDateConverter() {
int year = global::DripSharp.Runtime.JavaCompat.CalendarGet(global::System.DateTimeOffset.Now, 1);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2010, 4, 23, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:20100423"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2011, 4, 23, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20110423"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2012, 1, 1, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:2012"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2013, 1, 1, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2013"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2001, 1, 31, 10, 33, 0, +1, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2001-01-31T10:33+01:00  "));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2001, 1, 31, 10, 33, 0, +1, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2001-01-31T10:33.123+01:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2002, 5, 12, 9, 47, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "9:47 5/12/2002"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2003, 12, 17, 2, 2, 3, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "200312172:2:3"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2009, 3, 19, 20, 1, 22, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "  20090319 200122"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2014, 4, 1, 0, 0, 0, +2, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20140401+0200"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2115, 1, 11, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Friday, January 11, 2115"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1915, 1, 11, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Monday, Jan 11, 1915"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2215, 1, 11, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wed, January 11, 2215"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2015, 1, 11, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", " Sun, January 11, 2015 "));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2016, 4, 1, 0, 0, 0, +4, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20160401+04'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2017, 4, 1, 0, 0, 0, +9, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20170401+09'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2017, 4, 1, 0, 0, 0, +9, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20170401+09'30'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2018, 4, 1, 0, 0, 0, -2, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20180401-02'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2019, 4, 1, 6, 1, 1, -11, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20190401 6:1:1 -1100"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2020, 5, 26, 11, 25, 10, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "26 May 2020 11:25:10"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2021, 5, 26, 11, 23, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "26 May 2021 11:23"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2016, 4, 1, 0, 0, 0, +4, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20160401+04'30'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2017, 4, 1, 0, 0, 0, +9, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20170401+09'30'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2018, 4, 1, 0, 0, 0, -2, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20180401-02'30'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2019, 4, 1, 6, 1, 1, -11, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20190401 6:1:1 -1130"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2000, 2, 29, 0, 0, 0, +11, 30, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", " 2000 Feb 29 GMT + 11:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Tuesday, May 32 2000 11:27 UCT"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "32 May 2000 11:25"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Tuesday, May 32 2000 11:25"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19921301 11:25"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19921232 11:25"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19921001 11:60"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19920401 24:25"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "20070430193647+713'00' illegal tz hr"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "nodigits"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Unknown"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "333three digit year"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2000, 2, 29, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2000 Feb 29"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2000, 2, 29, 0, 0, 0, +11, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", " 2000 Feb 29 GMT + 11:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2000, 2, 29, 0, 0, 0, +11, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", " 2000 Feb 29 UTC + 11:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2100 Feb 29 GMT+11"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2012, 2, 29, 0, 0, 0, +11, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2012 Feb 29 GMT+11"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 0, 0, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2012 Feb 30 GMT+11"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1970, 12, 23, 0, 8, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1970 12 23:08"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1971, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Tuesday, 6 Jul 1971 5:22:1 PM"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1972, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Thu, July 6, 1972 5:22:1 pm"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1973, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1973 17:22:1"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1974, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1974"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1975, 7, 6, 17, 22, 1, -10, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1975-7-6T17:22:1-1000"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1976, 7, 6, 17, 22, 1, -4, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1976-7-6T17:22:1GMT-4"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(global::DripSharp.PdfCarton.Util.TestDateUtil.BAD, 7, 6, 17, 22, 1, -4, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2076-7-6T17:22:1EDT"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1960, 7, 6, 17, 22, 1, -5, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1960-7-6T17:22:1EST"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1977, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wednesday, Jul 6, 1977"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1978, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Thu Jul 6, 1978 17:22:1"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1979, 7, 6, 17, 22, 1, +8, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Friday July 6 17:22:1 GMT+08:00 1979"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1980, 7, 6, 16, 23, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Sun, Jul 6, 1980 at 4:23pm"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1981, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Monday, July 6, 1981"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1982, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "6 Jul 1982 17:22:1"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1983, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1983 17:22:1"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1984, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1984 17:22:01"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1985, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1985"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1986, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "07/06/1986"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1987, 7, 6, 17, 22, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1987 17:22:1"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1988, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7/6/1988"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse((year - 79), 1, 1, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("1/1/", ((year - 79) % 100)), " 00:00:00")));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse((year + 19), 1, 1, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("1/1/", ((year + 19) % 100))));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1991, 7, 6, 17, 7, 1, +6, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19910706 17:7:1 Z+0600"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1992, 7, 6, 17, 7, 1, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19920706 17:07:01"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1993, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19930706+00'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1994, 7, 6, 0, 0, 0, 1, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19940706+01'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1995, 7, 6, 0, 0, 0, 2, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19950706+02'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1996, 7, 6, 0, 0, 0, 3, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19960706+03'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1997, 7, 6, 0, 0, 0, -10, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19970706-10'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1998, 7, 6, 0, 0, 0, -11, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19980706-11'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(1999, 7, 6, 0, 0, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "19990706"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2073, 12, 25, 0, 8, 0, 0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2073 12 25:08"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParse(2016, 4, 11, 16, 1, 15, 12, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:20160411160115+12'00'"));
}

private static void checkToString(int yr, int mon, int day, int hr, int min, int sec, global::System.TimeZoneInfo tz, int offsetHours, int offsetMinutes) {
global::System.DateTimeOffset? cal = global::DripSharp.Runtime.JavaCompat.CalendarInstance(tz);
cal = global::DripSharp.Runtime.JavaCompat.CalendarSet(cal, yr, (mon - 1), day, hr, min, sec);
string pdfDate = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::System.Globalization.CultureInfo.GetCultureInfo("en-US"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:%04d%02d%02d%02d%02d%02d%+03d'%02d'"), yr, mon, day, hr, min, sec, offsetHours, offsetMinutes);
string iso8601Date = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::System.Globalization.CultureInfo.GetCultureInfo("en-US"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("%04d-%02d-%02d", "T%02d:%02d:%02d%+03d:%02d")), yr, mon, day, hr, min, sec, offsetHours, offsetMinutes);
global::DripSharp.Testing.JavaAssertions.Equal(pdfDate, global::DripSharp.PdfCarton.Util.DateConverter.ToString(cal), null);
global::DripSharp.Testing.JavaAssertions.Equal(iso8601Date, global::DripSharp.PdfCarton.Util.DateConverter.ToISO8601(cal), null);
}

internal virtual void testToString() {
global::System.TimeZoneInfo tzPgh = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "America/New_York"));
global::System.TimeZoneInfo tzBerlin = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Europe/Berlin"));
global::System.TimeZoneInfo tzMaputo = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Africa/Maputo"));
global::System.TimeZoneInfo tzAruba = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "America/Aruba"));
global::System.TimeZoneInfo tzJamaica = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "America/Jamaica"));
global::System.TimeZoneInfo tzMcMurdo = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Antartica/McMurdo"));
global::System.TimeZoneInfo tzAdelaide = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Australia/Adelaide"));
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar((global::DripSharp.PdfCarton.Cos.COSString)default!), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar((string)default!), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:    ")), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D:")), null);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2013, 8, 28, 3, 14, 15, tzPgh, -4, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2014, 2, 28, 3, 14, 15, tzPgh, -5, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2015, 8, 28, 3, 14, 15, tzBerlin, +2, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2016, 2, 28, 3, 14, 15, tzBerlin, +1, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2017, 8, 28, 3, 14, 15, tzAruba, -4, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2018, 1, 1, 1, 14, 15, tzJamaica, -5, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2019, 12, 31, 12, 59, 59, tzJamaica, -5, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2020, 2, 29, 0, 0, 0, tzMaputo, +2, 0);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2015, 8, 28, 3, 14, 15, tzAdelaide, +9, 30);
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString(2016, 2, 28, 3, 14, 15, tzAdelaide, +10, 30);
for (int m = 1; (m <= 12); ++m) {
global::DripSharp.PdfCarton.Util.TestDateUtil.checkToString((1980 + m), m, 1, 1, 14, 15, tzMcMurdo, +0, 0);
}
}

private static void checkParseTZ(int expect, string src) {
global::System.DateTimeOffset? dest = global::DripSharp.PdfCarton.Util.DateConverter.newGreg();
global::DripSharp.PdfCarton.Util.DateConverter.parseTZoffset(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", src), ref dest, new global::DripSharp.Runtime.JavaParsePosition(0));
global::DripSharp.Testing.JavaAssertions.Equal(expect, global::DripSharp.Runtime.JavaCompat.CalendarGet(dest, 15), null);
}

internal virtual void testParseTZ() {
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((0 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+00:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((0 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0000"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((1 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+1:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((1 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-1:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((1 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (30 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0130"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((11 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (59 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1159"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((12 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (30 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1230"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((12 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (30 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((0 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Z"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((8 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PST"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((0 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EDT"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((3 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "GMT-0300"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(+(((11 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "GMT+11:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((6 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "America/Chicago"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(+(((3 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Europe/Moscow"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(+(((9 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (30 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Australia/Adelaide"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((5 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0500"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((5 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+0500"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((11 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+11'00'"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Z"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((12 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+12:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((12 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(((14 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1400"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkParseTZ(-(((14 * global::DripSharp.PdfCarton.Util.TestDateUtil.HRS) + (0 * global::DripSharp.PdfCarton.Util.TestDateUtil.MINS))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-1400"));
}

private static void checkFormatOffset(double off, string expect) {
global::System.TimeZoneInfo tz = global::DripSharp.Runtime.JavaCompat.NewSimpleTimeZone((int)((int)((((off * 60) * 60) * 1000))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "junkID"));
string got = global::DripSharp.PdfCarton.Util.DateConverter.formatTZoffset((long)(global::DripSharp.Runtime.JavaCompat.TimeZoneRawOffset(tz)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ":"));
global::DripSharp.Testing.JavaAssertions.Equal(expect, got, null);
}

internal virtual void testFormatTZoffset() {
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-12.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(12.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+12:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(0), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+00:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(-1), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-01:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(0.5D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+00:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-0.5D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-00:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(0.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+00:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-0.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-00:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(-12), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(12), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+12:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-11.5D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-11:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(11.5D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+11:30"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(11.9D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+11:54"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(11.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+11:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-11.9D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-11:54"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset(-11.1D, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-11:06"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(14), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+14:00"));
global::DripSharp.PdfCarton.Util.TestDateUtil.checkFormatOffset((double)(-14), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-14:00"));
}

[Xunit.Fact]
public void __Upstream_4210391190_44b5dc4960ebb745()
{
        try
        {
            this.testDateConversion();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1105651232_503f3547b5b2d5e7()
{
        try
        {
            this.testDateConverter();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0449595279_c89c40a307bd56d2()
{
        try
        {
            this.testExtract();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2716052674_8ca3708f17633427()
{
        try
        {
            this.testFormatTZoffset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0961916807_41ab5fda86585707()
{
        try
        {
            this.testParseTZ();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1084901662_54565a0602417721()
{
        try
        {
            this.testToString();
        }
        finally
        {
        }
}
}
