using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Syncronaut.Client.Services;

public class FileSystemService : IDisposable
{
    private FileSystemWatcher? _fsWatcher;
    private bool disposedValue;

    public void StartWatching(string path)
    {
        _fsWatcher = new FileSystemWatcher
        {
            NotifyFilter = NotifyFilters.Attributes
                            | NotifyFilters.CreationTime
                            | NotifyFilters.DirectoryName
                            | NotifyFilters.FileName
                            | NotifyFilters.LastAccess
                            | NotifyFilters.LastWrite
                            | NotifyFilters.Security
                            | NotifyFilters.Size
        };

        _fsWatcher.Changed += OnChanged;
        _fsWatcher.Created += OnCreated;
        _fsWatcher.Deleted += OnDeleted;
        _fsWatcher.Renamed += OnRenamed;
        _fsWatcher.Error += OnError;

        _fsWatcher.IncludeSubdirectories = true;
        _fsWatcher.EnableRaisingEvents = true;
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {

    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {

    }

    private void OnDeleted(object sender, FileSystemEventArgs e)
    {

    }

    private void OnRenamed(object sender, RenamedEventArgs e)
    {

    }

    private void OnError(object sender, ErrorEventArgs e)
    {

    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // Dispose managed state (managed objects)
                _fsWatcher?.Dispose();
            }

            // Free unmanaged resources (unmanaged objects) and override finalizer
            // Set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
