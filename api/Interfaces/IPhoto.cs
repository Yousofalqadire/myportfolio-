using System.Threading.Tasks;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace api.Interfaces
{
    public interface IPhoto
    {
         Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
         Task<DeletionResult> DeletPhotoAsync(string publicId);
    }
}