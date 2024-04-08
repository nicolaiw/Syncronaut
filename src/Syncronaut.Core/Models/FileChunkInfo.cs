using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncronaut.Core.Models;

public class FileChunkInfo
{
    public ulong Index { get; private set; }
    public uint ChunkSize { get; private set; }
    public string Hash { get; private set; }

    public FileChunkInfo(ulong index, uint chunkSize, string hash)
    {
        Index = index;
        ChunkSize = chunkSize;
        Hash = hash;
    }
}
