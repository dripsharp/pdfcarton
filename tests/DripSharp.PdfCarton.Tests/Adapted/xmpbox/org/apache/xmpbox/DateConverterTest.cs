// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class DateConverterTest {
  internal virtual void testDateConversion() {
    global::System.DateTimeOffset? convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015"));
    global::DripSharp.Testing.JavaAssertions.Equal(2015,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 1), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-05"));
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 2), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-05-02"));
    global::DripSharp.Testing.JavaAssertions.Equal(2015,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 5), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "D:2015-02-02"));
    global::DripSharp.Testing.JavaAssertions.Equal(2015,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 1), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "D:2015-02-03T10:11:12"));
    global::DripSharp.Testing.JavaAssertions.Equal(2015,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 5), null);
    global::DripSharp.Testing.JavaAssertions.Equal(10,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 11), null);
    global::DripSharp.Testing.JavaAssertions.Equal(11,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 12), null);
    global::DripSharp.Testing.JavaAssertions.Equal(12,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 13), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "D:2015-02-03T10:11:12Z"));
    global::DripSharp.Testing.JavaAssertions.Equal(2015,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 5), null);
    global::DripSharp.Testing.JavaAssertions.Equal(10,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 11), null);
    global::DripSharp.Testing.JavaAssertions.Equal(11,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 12), null);
    global::DripSharp.Testing.JavaAssertions.Equal(12,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 13), null);
    convDate
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2025-09-03T15:43:47.989082+00:00"));
    global::DripSharp.Testing.JavaAssertions.Equal(989,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(convDate, 14), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "123")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2008-12-31T19:48:30+19:00")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2008-12-31T19:48:30-19:00")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2008-12-02T21:04:0Z")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "0-01-01T00:00:00Z")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2009-03-16T01:15:19-0-4:00")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "0-00-00T00:00:00-04:00")), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-12-08T12:07:00-05:00")),
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-12-08T12:07-05:00")), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2011-11-20T10:09:00Z")),
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2011-11-20T10:09Z")), null);
    string testString1 = "";
    string testString2 = "";
    global::DripSharp.Runtime.JavaDateTimeFormatter dateTimeFormatter
      = global::DripSharp.Runtime.JavaDateTimeFormatter.IsoLocalDateTimeOffset();
    testString1 = "2015-12-08T12:07:00-05:00";
    testString2 = "2015-12-08T12:07-05:00";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1)),
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString2)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString2))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString2,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192Z";
    testString2 = "2015-02-02T16:37:19.192Z";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString2))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192+00:00";
    testString2 = "2015-02-02T16:37:19.192Z";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString2))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192+02:00";
    testString2 = "2015-02-02T16:37:19.192+02:00";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString2))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192+05:30";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192-05:30";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2015-02-02T16:37:19.192+10:30";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.ParseZonedDateTime(testString1,
      dateTimeFormatter)), null);
    testString1 = "2024-04-09T14:41:38";
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      testString1))),
      global::DripSharp.Runtime.JavaCompat.ToInstant(global::DripSharp.Runtime.JavaCompat.LocalDateTimeAtZone(global::DripSharp.Runtime.JavaCompat.ParseLocalDateTime(testString1,
      global::DripSharp.Runtime.JavaDateTimeFormatter.IsoLocalDateTime),
      global::DripSharp.Runtime.JavaCompat.ZoneIdOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "UTC")))), null);
    global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar((string)default!),
      null);
    global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "")), null);
  }

  internal virtual void testDateFormatting() {
    global::DripSharp.Runtime.JavaSimpleDateFormat dateFormat
      = new global::DripSharp.Runtime.JavaSimpleDateFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "yyyy-MM-dd'T'HH:mm:ss.SSSZ"), global::System.Globalization.CultureInfo.InvariantCulture);
    global::System.DateTimeOffset? cal
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-02-02T16:37:19.192Z"));
    global::DripSharp.Testing.JavaAssertions.Equal(dateFormat.Format(cal),
      dateFormat.Format(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToISO8601(cal, true)))), null);
    cal
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-02-02T16:37:19.192+09:09"));
    global::DripSharp.Testing.JavaAssertions.Equal(dateFormat.Format(cal),
      dateFormat.Format(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToISO8601(cal, true)))), null);
    cal
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "2015-02-02T16:37:19.192+10:10"));
    global::DripSharp.Testing.JavaAssertions.Equal(dateFormat.Format(cal),
      dateFormat.Format(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToISO8601(cal, true)))), null);
    cal
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "0000-01-01"));
    cal = global::DripSharp.Runtime.JavaCompat.CalendarSetTimeZone(cal,
      global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "UTC")));
    global::DripSharp.Testing.JavaAssertions.Equal("0001-01-01T00:00:00+00:00",
      global::DripSharp.PdfCarton.Xmp.DateConverter.ToISO8601(cal), null);
  }

  [Xunit.Fact]
  public void __Upstream_4210391190_d8514de537a71abf() {
    try {
      this.testDateConversion();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2491919077_1603a915d7c171c4() {
    try {
      this.testDateFormatting();
    } finally {
    }
  }
}
