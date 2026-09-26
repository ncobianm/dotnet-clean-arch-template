using CleanArch.Application.Common.Interfaces.Services;

namespace CleanArch.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}