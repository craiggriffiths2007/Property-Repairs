namespace PropertySurveyService.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Insurer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? LegalName { get; set; }

        [MaxLength(50)]
        public string? Code { get; set; }

        public bool IsActive { get; set; } = true;

        // Contact & communication
        [MaxLength(100)]
        public string? MainPhone { get; set; }

        [MaxLength(320), EmailAddress]
        public string? MainEmail { get; set; }

        [MaxLength(2083), Url]
        public string? Website { get; set; }

        [MaxLength(200)]
        public string? PrimaryContactName { get; set; }

        [MaxLength(100)]
        public string? PrimaryContactPhone { get; set; }

        [MaxLength(320), EmailAddress]
        public string? PrimaryContactEmail { get; set; }

        // Regulatory / external identifiers
        [MaxLength(100)]
        public string? RegistrationNumber { get; set; }

        [MaxLength(100)]
        public string? TaxId { get; set; }

        // Simple address fields (consider normalizing into a separate Address entity)
        [MaxLength(200)]
        public string? AddressLine1 { get; set; }

        [MaxLength(200)]
        public string? AddressLine2 { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? State { get; set; }

        [MaxLength(20)]
        public string? PostalCode { get; set; }

        [MaxLength(100)]
        public string? Country { get; set; }

        // Operational / metadata
        public DateOnly? EstablishedDate { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        [MaxLength(2083)]
        public string? LogoUrl { get; set; }

        // Auditing
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        [MaxLength(200)]
        public string? CreatedBy { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        [MaxLength(200)]
        public string? UpdatedBy { get; set; }

        // Concurrency token for EF Core
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
