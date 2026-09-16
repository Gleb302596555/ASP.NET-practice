namespace GameStore.api.Dtos;

public record GameSummmaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);