using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStory.Frontend.Converters;

namespace GameStory.Frontend.Models;

public class GameDetails
{

    public int Id { get; set;}

    [Required, StringLength(50)]
    public required string Name { get; set;}

    [Required(ErrorMessage = "Genere field is required"),
    JsonConverter(typeof(StringConverter))]
    public string? GenreId { get; set;}
    
    [Required, Range(1, 100)]
    public decimal Price { get; set;}
    public DateOnly ReleaseDate { get; set;}

}
