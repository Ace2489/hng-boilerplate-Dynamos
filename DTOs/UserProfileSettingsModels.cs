
namespace HNG_stage3.DTOs;

public class UserProfileResponseDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ProfileSettingsDto ProfileSettings { get; set; }
}

public class ProfileSettingsDto
{
    public string Bio { get; set; }
    public string AvatarUrl { get; set; }
    public string ThemePreference { get; set; }
    public NotificationPreferencesDto NotificationPreferences { get; set; }
    public string Language { get; set; }
    public string Region { get; set; }
}

public class NotificationPreferencesDto
{
    public bool EmailNotifications { get; set; }
    public bool PushNotifications { get; set; }
    public bool NewsletterSubscription { get; set; }
}

public class UpdateUserProfileRequestDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Bio { get; set; }
    public string AvatarUrl { get; set; }
    public string ThemePreference { get; set; }
    public NotificationPreferencesDto NotificationPreferences { get; set; }
    public int? LanguageId { get; set; }
    public int? RegionId { get; set; }
}

public class UpdateUserProfileResponseDto
{
    public string Message { get; set; }
    public ProfileSettingsDto Profile { get; set; }
}

public class UpdateAvatarResponseDto
{
    public string Message { get; set; }
    public string AvatarUrl { get; set; }
}

public class UpdateNotificationPreferencesRequestDto
{
    public bool? EmailNotifications { get; set; }
    public bool? PushNotifications { get; set; }
    public bool? NewsletterSubscription { get; set; }
}

public class UpdateNotificationPreferencesResponseDto
{
    public string Message { get; set; }
    public NotificationPreferencesDto Preferences { get; set; }
}

public class LocalizationDataDto
{
    public List<LocalizationItemDto> Languages { get; set; }
    public List<LocalizationItemDto> Regions { get; set; }
}

public class LocalizationItemDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}