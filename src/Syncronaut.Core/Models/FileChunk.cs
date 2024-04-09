using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncronaut.Core.Models;

public class FileChunk
{
    public int Index { get; private set; }

    public byte[] ChunkData { get; private set; }

    public FileChunk(int index, byte[] chunkData)
    {
        Index = index;
        ChunkData = chunkData;
    }
}
