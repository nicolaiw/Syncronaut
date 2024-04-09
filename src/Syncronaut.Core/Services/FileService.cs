using Syncronaut.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Syncronaut.Core.Services;

public static class FileService
{
    public static IEnumerable<FileChunkInfo> CalculateFileChunkInfos(ArraySegment<byte> fileBytes, int chunkSize)
    {
        var fullChunks = fileBytes.Count / chunkSize;
        var lastChunkSize = fileBytes.Count % chunkSize;

        for(int i = 0; i < fullChunks; i++)
        {
            var offset = i * chunkSize;
            var chunk = fileBytes.Slice(offset, chunkSize);
            var hash = ComputeSha256HashString(chunk);
            var fileChunkInfo = new FileChunkInfo(i, chunkSize, hash);

            yield return fileChunkInfo;
        }

        if (lastChunkSize == 0)
            yield break;

        var lastChunkBytes = fileBytes.Slice(fullChunks * chunkSize, lastChunkSize);
        var lastChunkHash = ComputeSha256HashString(lastChunkBytes);
        var lastFileChunkInfo = new FileChunkInfo(fullChunks + 1, lastChunkSize, lastChunkHash);

        yield return lastFileChunkInfo;
    }

    public static IEnumerable<FileChunkInfo> GetFileChunkDiffs(IEnumerable<FileChunkInfo> originFileChunkInfos, ArraySegment<byte> destFileBytes)
    {
        throw new NotImplementedException();
    }

    private static string ComputeSha256HashString(ArraySegment<byte> data)
    {
        // Create a SHA256
        // ComputeHash - returns byte array
        byte[] bytes = SHA256.HashData(data);

        // Convert byte array to a string
        StringBuilder builder = new();

        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
        
        return builder.ToString();
    }
}
