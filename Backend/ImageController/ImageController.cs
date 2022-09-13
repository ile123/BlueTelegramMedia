using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Backend.ImageController
{
    public class ImageController
    {
		[ApiController]
		[Route("api/[controller]")]
		public class UploadController : ControllerBase
		{
			private readonly IWebHostEnvironment _env;

			public UploadController(IWebHostEnvironment env) => _env = env;

			[HttpPost]
			public async Task UploadImage([FromBody] ImageFile file)
			{
				var buf = Convert.FromBase64String(file.base64data);
				await System.IO.File.WriteAllBytesAsync(_env.ContentRootPath + System.IO.Path.DirectorySeparatorChar + Guid.NewGuid().ToString("N") + "-" + file.fileName, buf);
			}
		}
	}
}
