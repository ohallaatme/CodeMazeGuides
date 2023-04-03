using System;
namespace ReadRequestBody.Shared.DataTransferObjects
{
	public record UserDto
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public string? Email { get; set; }
	}
}

