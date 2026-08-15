// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class TestIOUtils {
internal virtual void testPopulateBuffer() {
sbyte[] data = global::DripSharp.Runtime.JavaCompat.StringGetBytes("Hello World!", global::System.Text.Encoding.UTF8);
sbyte[] buffer = new sbyte[data.Length];
long count = global::DripSharp.PdfCarton.IO.IOUtils.PopulateBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data), buffer);
global::DripSharp.Testing.JavaAssertions.Equal((long)(12), count, null);
buffer = new sbyte[(data.Length - 2)];
global::System.IO.Stream @in = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data);
count = global::DripSharp.PdfCarton.IO.IOUtils.PopulateBuffer(@in, buffer);
global::DripSharp.Testing.JavaAssertions.Equal((long)(10), count, null);
sbyte[] leftOver = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@in);
global::DripSharp.Testing.JavaAssertions.Equal(2, leftOver.Length, null);
buffer = new sbyte[(data.Length + 2)];
@in = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data);
count = global::DripSharp.PdfCarton.IO.IOUtils.PopulateBuffer(@in, buffer);
global::DripSharp.Testing.JavaAssertions.Equal((long)(12), count, null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@in), null);
}

internal virtual void testPopulateBufferEmpty() {
sbyte[] buffer = new sbyte[10];
global::System.IO.Stream @in = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[0]);
long count = global::DripSharp.PdfCarton.IO.IOUtils.PopulateBuffer(@in, buffer);
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), count, null);
}

internal virtual void testToByteArray() {
sbyte[] data = global::DripSharp.Runtime.JavaCompat.StringGetBytes("Test Data", global::System.Text.Encoding.UTF8);
sbyte[] result = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data));
global::DripSharp.Testing.JavaAssertions.Equal(data.Length, result.Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(data, global::System.Text.Encoding.UTF8), global::DripSharp.Runtime.JavaCompat.NewString(result, global::System.Text.Encoding.UTF8), null);
}

internal virtual void testToByteArrayEmpty() {
sbyte[] result = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[0]));
global::DripSharp.Testing.JavaAssertions.Equal(0, result.Length, null);
}

internal virtual void testToByteArrayLarge() {
sbyte[] data = new sbyte[10000];
for (int i = 0; (i < data.Length); i++) {
data[i] = unchecked((sbyte)(unchecked((sbyte)((i % 256)))));
}
sbyte[] result = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data));
global::DripSharp.Testing.JavaAssertions.Equal(data.Length, result.Length, null);
}

internal virtual void testCopy() {
sbyte[] data = global::DripSharp.Runtime.JavaCompat.StringGetBytes("Copy Test Content", global::System.Text.Encoding.UTF8);
global::System.IO.Stream input = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data);
global::DripSharp.Runtime.JavaByteArrayOutputStream output = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
long copied = global::DripSharp.PdfCarton.IO.IOUtils.Copy(input, output);
global::DripSharp.Testing.JavaAssertions.Equal((long)(data.Length), copied, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(data, global::System.Text.Encoding.UTF8), global::DripSharp.PdfCarton.Tests.Support.OutputText(output), null);
}

internal virtual void testCopyEmpty() {
global::System.IO.Stream input = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[0]);
global::DripSharp.Runtime.JavaByteArrayOutputStream output = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
long copied = global::DripSharp.PdfCarton.IO.IOUtils.Copy(input, output);
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), copied, null);
global::DripSharp.Testing.JavaAssertions.Equal(0, checked((int)output.Length), null);
}

internal virtual void testCopyLarge() {
sbyte[] data = new sbyte[50000];
for (int i = 0; (i < data.Length); i++) {
data[i] = unchecked((sbyte)(unchecked((sbyte)((i % 256)))));
}
global::System.IO.Stream input = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(data);
global::DripSharp.Runtime.JavaByteArrayOutputStream output = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
long copied = global::DripSharp.PdfCarton.IO.IOUtils.Copy(input, output);
global::DripSharp.Testing.JavaAssertions.Equal((long)(data.Length), copied, null);
global::DripSharp.Testing.JavaAssertions.Equal(data.Length, checked((int)output.Length), null);
}

internal virtual void testCloseQuietlyNull() {
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.Tests.Support.CloseQuietly((global::System.Action)default!), null);
}

internal virtual void testCloseQuietly() {
global::System.IO.MemoryStream stream = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[10]);
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(stream), null);
}

internal virtual void testCloseQuietlySuppressesException() {
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
global::System.Action failingCloseable = () => {
throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Test IOException"));
};
global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(failingCloseable);
}, null);
}

internal virtual void testCloseAndLogExceptionSuccess() {
global::Microsoft.Extensions.Logging.ILogger logger = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
global::System.IO.MemoryStream stream = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[10]);
global::System.IO.IOException result = global::DripSharp.PdfCarton.Tests.Support.CloseAndLogException(stream, logger, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "testResource"), (global::System.IO.IOException)default!);
global::DripSharp.Testing.JavaAssertions.Null(result, null);
}

internal virtual void testCloseAndLogExceptionCloseThrows() {
global::Microsoft.Extensions.Logging.ILogger logger = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
global::System.IO.IOException closeException = new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Close error"));
global::System.Action failingCloseable = () => {
throw closeException;
};
global::System.IO.IOException result = global::DripSharp.PdfCarton.Tests.Support.CloseAndLogException(failingCloseable, logger, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "testResource"), (global::System.IO.IOException)default!);
global::DripSharp.Testing.JavaAssertions.Equal(closeException, result, null);
}

internal virtual void testCloseAndLogExceptionPreservesInitialException() {
global::Microsoft.Extensions.Logging.ILogger logger = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
global::System.IO.IOException initialException = new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Initial error"));
global::System.Action failingCloseable = () => {
throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Close error"));
};
global::System.IO.IOException result = global::DripSharp.PdfCarton.Tests.Support.CloseAndLogException(failingCloseable, logger, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "testResource"), initialException);
global::DripSharp.Testing.JavaAssertions.Equal(initialException, result, null);
}

internal virtual void testUnmapNull() {
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.IO.IOUtils.Unmap((global::DripSharp.Runtime.JavaByteBuffer)default!), null);
}

internal virtual void testUnmapHeapBuffer() {
global::DripSharp.Runtime.JavaByteBuffer buffer = global::DripSharp.Runtime.JavaByteBuffer.allocate(1024);
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.IO.IOUtils.Unmap(buffer), null);
}

internal virtual void testCreateMemoryOnlyStreamCache() {
global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction function = global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache();
global::DripSharp.Testing.JavaAssertions.NotNull(function, null);
}

internal virtual void testCreateTempFileOnlyStreamCache() {
global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction function = global::DripSharp.PdfCarton.IO.IOUtils.CreateTempFileOnlyStreamCache();
global::DripSharp.Testing.JavaAssertions.NotNull(function, null);
}

internal virtual void testCreateProtectedTempDir() {
global::DripSharp.Runtime.JavaPath tempDir = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempDir();
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Temporary directory should exist"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.IsDirectory(tempDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Path should be a directory"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringStartsWith(global::System.IO.Path.GetFileName(tempDir).ToString()!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "pdfbox-")), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Directory name should start with 'pdfbox-'"));
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempDir)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempDir);
}
}
}

internal virtual void testCreateProtectedTempDirPermissions() {
global::DripSharp.Runtime.JavaPath tempDir = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempDir();
try {
if (global::DripSharp.PdfCarton.Tests.Support.SupportsFileAttributeView(global::DripSharp.PdfCarton.Tests.Support.FileStore(tempDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "posix"))) {
global::System.Collections.Generic.ISet<global::DripSharp.Runtime.JavaUnixFileMode> perms = global::DripSharp.PdfCarton.Tests.Support.GetPosixFilePermissions(tempDir);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserRead), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserWrite), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserExecute), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupRead), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupWrite), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupExecute), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherRead), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherWrite), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherExecute), null);
}
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempDir)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempDir);
}
}
}

internal virtual void testCreateProtectedTempDirMultiple() {
global::DripSharp.Runtime.JavaPath tempDir1 = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempDir();
global::DripSharp.Runtime.JavaPath tempDir2 = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempDir();
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempDir1), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempDir2), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(tempDir1, tempDir2, null);
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempDir1)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempDir1);
}
if (global::DripSharp.Runtime.JavaCompat.Exists(tempDir2)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempDir2);
}
}
}

internal virtual void testCreateProtectedTempFileDefaultDir() {
global::DripSharp.Runtime.JavaPath tempFile = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".tmp"));
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Temporary file should exist"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.PathIsRegularFile(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Path should be a file"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringStartsWith(global::System.IO.Path.GetFileName(tempFile).ToString()!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "test")), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "File name should start with 'test'"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringEndsWith(global::System.IO.Path.GetFileName(tempFile).ToString()!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".tmp")), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "File name should end with '.tmp'"));
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
}
}
}

internal virtual void testCreateProtectedTempFileSpecifiedDir() {
global::DripSharp.Runtime.JavaPath tempDir = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempDir();
try {
global::DripSharp.Runtime.JavaPath tempFile = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile(tempDir, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "myfile"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".bin"));
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Temporary file should exist"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.PathIsRegularFile(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Path should be a file"));
global::DripSharp.Testing.JavaAssertions.Equal(tempDir, global::DripSharp.Runtime.JavaCompat.PathParent(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "File should be in specified directory"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringStartsWith(global::System.IO.Path.GetFileName(tempFile).ToString()!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "myfile")), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "File name should start with 'myfile'"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringEndsWith(global::System.IO.Path.GetFileName(tempFile).ToString()!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".bin")), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "File name should end with '.bin'"));
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
}
}
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempDir)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempDir);
}
}
}

internal virtual void testCreateProtectedTempFilePermissions() {
global::DripSharp.Runtime.JavaPath tempFile = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "perm"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".test"));
try {
if (global::DripSharp.PdfCarton.Tests.Support.SupportsFileAttributeView(global::DripSharp.PdfCarton.Tests.Support.FileStore(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "posix"))) {
global::System.Collections.Generic.ISet<global::DripSharp.Runtime.JavaUnixFileMode> perms = global::DripSharp.PdfCarton.Tests.Support.GetPosixFilePermissions(tempFile);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserRead), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserWrite), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.UserExecute), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupRead), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupWrite), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.GroupExecute), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherRead), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherWrite), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(perms, global::DripSharp.Runtime.JavaUnixFileMode.OtherExecute), null);
}
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
}
}
}

internal virtual void testCreateProtectedTempFileMultiple() {
global::DripSharp.Runtime.JavaPath tempFile1 = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "test1"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".tmp"));
global::DripSharp.Runtime.JavaPath tempFile2 = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "test1"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".tmp"));
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempFile1), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempFile2), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(tempFile1, tempFile2, null);
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile1)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile1);
}
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile2)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile2);
}
}
}

internal virtual void testCreateProtectedTempFileNullSuffix() {
global::DripSharp.Runtime.JavaPath tempFile = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "test"), (string)default!);
try {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Exists(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Temporary file should exist"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.PathIsRegularFile(tempFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "Path should be a file"));
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
}
}
}

internal virtual void testCreateProtectedTempFileWriteable() {
global::DripSharp.Runtime.JavaPath tempFile = global::DripSharp.PdfCarton.IO.IOUtils.CreateProtectedTempFile((global::DripSharp.Runtime.JavaPath)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "writable"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".dat"));
try {
sbyte[] testData = global::DripSharp.Runtime.JavaCompat.StringGetBytes("Test content", global::System.Text.Encoding.UTF8);
global::DripSharp.PdfCarton.Tests.Support.WriteAllBytes(tempFile, testData);
sbyte[] readData = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(tempFile);
global::DripSharp.Testing.JavaAssertions.Equal(testData.Length, readData.Length, null);
global::DripSharp.Testing.JavaAssertions.Equal("Test content", global::DripSharp.Runtime.JavaCompat.NewString(readData, global::System.Text.Encoding.UTF8), null);
} finally {
if (global::DripSharp.Runtime.JavaCompat.Exists(tempFile)) {
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
}
}
}

[Xunit.Fact]
public void __Upstream_4003882313_f4391127d310a4a7()
{
        try
        {
            this.testCloseAndLogExceptionCloseThrows();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3352401686_72a83b4d18574cb9()
{
        try
        {
            this.testCloseAndLogExceptionPreservesInitialException();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2396721383_c0bc7415dabbe92c()
{
        try
        {
            this.testCloseAndLogExceptionSuccess();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2491897691_9d8b80106727861c()
{
        try
        {
            this.testCloseQuietly();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3358288770_66e64306f3d9e923()
{
        try
        {
            this.testCloseQuietlyNull();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3529511441_0a70595b6181f22e()
{
        try
        {
            this.testCloseQuietlySuppressesException();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1000197927_e9ea241370edac44()
{
        try
        {
            this.testCopy();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0003679846_6d95e4398b7f01c5()
{
        try
        {
            this.testCopyEmpty();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0009788500_1b5697ce452277b5()
{
        try
        {
            this.testCopyLarge();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1668045255_cb082bd728295291()
{
        try
        {
            this.testCreateMemoryOnlyStreamCache();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1258969305_a87db13149db0bb6()
{
        try
        {
            this.testCreateProtectedTempDir();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0000489993_e8103791d77d7fc5()
{
        try
        {
            this.testCreateProtectedTempDirMultiple();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2283827691_cbaffac0453caad0()
{
        try
        {
            this.testCreateProtectedTempDirPermissions();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3560238428_73ed6f0e442f1a44()
{
        try
        {
            this.testCreateProtectedTempFileDefaultDir();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3503752416_9f1bde4e353e4abb()
{
        try
        {
            this.testCreateProtectedTempFileMultiple();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0519705224_fc6810b393fb7d3a()
{
        try
        {
            this.testCreateProtectedTempFileNullSuffix();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0269378484_94df9d1da6e7a68e()
{
        try
        {
            this.testCreateProtectedTempFilePermissions();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2067801997_a67139cdd3b36906()
{
        try
        {
            this.testCreateProtectedTempFileSpecifiedDir();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1042309353_0f1b91d54543ff14()
{
        try
        {
            this.testCreateProtectedTempFileWriteable();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1914606328_ad1d10fd7b93b952()
{
        try
        {
            this.testCreateTempFileOnlyStreamCache();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2155264764_50616d0e829ed092()
{
        try
        {
            this.testPopulateBuffer();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1890736049_49b4cdd65269cdba()
{
        try
        {
            this.testPopulateBufferEmpty();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3081954820_06b64a0db61ef32a()
{
        try
        {
            this.testToByteArray();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3439317417_e03f60c562d13a25()
{
        try
        {
            this.testToByteArrayEmpty();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3445426071_fc9ba39d9930386b()
{
        try
        {
            this.testToByteArrayLarge();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1550605021_f4824e70a8f0231a()
{
        try
        {
            this.testUnmapHeapBuffer();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1070576600_65e8eab50b1f5f74()
{
        try
        {
            this.testUnmapNull();
        }
        finally
        {
        }
}
}
