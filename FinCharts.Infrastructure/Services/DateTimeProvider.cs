using FinCharts.Application.Common.Interfaces.Services;

namespace FinCharts.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}