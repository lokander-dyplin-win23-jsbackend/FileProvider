using Azure.Storage.Blobs;
using Data.Contexts;
using Microsoft.Extensions.Logging;


namespace FileProvider.Services;

public class FileService(DataContext context, ILogger<FileService> logger, BlobServiceClient client)
{
    private readonly ILogger<FileService> _logger = logger;
    private readonly DataContext _context = context;
    private readonly BlobServiceClient _client = client;

    public async Task SetBlobContainerAsync(string containerName)
    {
        var container = _client.GetBlobContainerClient(containerName);
        await container.CreateIfNotExistsAsync();
    }
}
