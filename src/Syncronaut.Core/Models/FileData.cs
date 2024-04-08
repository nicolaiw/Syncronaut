using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syncronaut.Core.Models;

public class FileData
{
    /// <summary>
    /// Full name with path within the watched directory.
    /// </summary>
    public string FullName { get; private set; }

    public IEnumerable<FileChunkInfo> FileChunkInfos { get; private set; }
}
