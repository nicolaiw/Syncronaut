using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Syncronaut.Core.Services;

public static class FileService
{
    public static IEnumerable<string> CalculateFileChunkHashes(ArraySegment<byte> fileBytes, uint chunkSize)
    {
        var fullChunks = fileBytes.Count / chunkSize;
        var lastChunkSize = fileBytes.Count % chunkSize;

        for(int i = 0; i < fullChunks; i++)
        {

        }

        if (lastChunkSize == 0)
            yield break;
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
