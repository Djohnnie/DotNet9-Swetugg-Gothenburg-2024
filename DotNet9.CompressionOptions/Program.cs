﻿using System.IO.Compression;



var zlibCompressionOptions = new ZLibCompressionOptions
{
    CompressionLevel = 1,
    CompressionStrategy = ZLibCompressionStrategy.Default,
};

var brotliCompressionOptions = new BrotliCompressionOptions
{
    Quality = 1
};

using var file = new FileStream("file.txt", FileMode.Open);

using var stream1 = new ZLibStream(file, zlibCompressionOptions);
using var stream2 = new GZipStream(file, zlibCompressionOptions);
using var stream3 = new DeflateStream(file, zlibCompressionOptions);
using var stream4 = new BrotliStream(file, brotliCompressionOptions);